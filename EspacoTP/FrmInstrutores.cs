using EspacoTP.BLL;
using EspacoTP.MODEL;
using EspacoTP.UTIL;
using System;
using System.Windows.Forms;

namespace EspacoTP
{
    public partial class FrmInstrutores : Form
    {
        #region construtor
        public FrmInstrutores()
        {
            InitializeComponent();
        }

        #endregion

        #region variáveis

        bool booRetorno = default(bool);
        string strMensagem = default(string);

        bool booModoEscrita = false;
        bool booInclusao = false;

        #endregion

        #region métodos

        public void HabilitarObjetos()
        {
            if (booModoEscrita)
            {
                btnIncluir.Enabled = false;
                btnAlterar.Enabled = false;
                btnDesfazer.Enabled = true;
                btnSalvar.Enabled = true;

                txtNome.Enabled = true;
                txtSobrenome.Enabled = true;
                txtCPF.Enabled = true;
                chkAtivo.Enabled = true;
            }
            else
            {
                btnIncluir.Enabled = true;
                btnAlterar.Enabled = true;
                btnDesfazer.Enabled = false;
                btnSalvar.Enabled = false;

                txtNome.Enabled = false;
                txtSobrenome.Enabled = false;
                txtCPF.Enabled = false;
                chkAtivo.Enabled = false;
            }
        }

        public void LimparCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtCPF.Text = "";
            chkAtivo.Checked = true;
        }

        public void MontarGrid()
        {
            grdInstrutores.DataSource = InstrutoresBLL.Buscar(out strMensagem, out booRetorno);
        }

        public void MontarDetalhe()
        {
            txtCodigo.Text = grdInstrutores.Rows[grdInstrutores.CurrentRow.Index].Cells["colId"].Value.ToString();
            txtNome.Text = grdInstrutores.Rows[grdInstrutores.CurrentRow.Index].Cells["colNome"].Value.ToString();
            txtSobrenome.Text = grdInstrutores.Rows[grdInstrutores.CurrentRow.Index].Cells["colSobrenome"].Value.ToString();
            txtCPF.Text = grdInstrutores.Rows[grdInstrutores.CurrentRow.Index].Cells["colCpf"].Value.ToString();
            chkAtivo.Checked = (bool)grdInstrutores.Rows[grdInstrutores.CurrentRow.Index].Cells["colAtivo"].Value;
        }

        public bool ValidarEfetivacao()
        {
            string strMensagemValidacao = "";

            if (!Validacoes.ValidarCampoEmBranco(txtNome.Text.Trim()))
            {
                strMensagemValidacao = strMensagemValidacao + "\n - Campo NOME é obrigatório.";
            }

            if (!Validacoes.ValidarCampoEmBranco(txtSobrenome.Text.Trim()))
            {
                strMensagemValidacao = strMensagemValidacao + "\n - Campo SOBRENOME é obrigatório.";
            }

            if (!Validacoes.ValidarCampoEmBranco(txtCPF.Text.Trim()))
            {
                strMensagemValidacao = strMensagemValidacao + "\n - Campo CPF é obrigatório.";
            }
            else
            {
                if (!Validacoes.ValidarCPF(txtCPF.Text.Trim()))
                {
                    strMensagemValidacao = strMensagemValidacao + "\n - CPF inválido.";
                }
            }

            if ((!string.IsNullOrEmpty(strMensagemValidacao) || (strMensagemValidacao != "")))
            {
                MessageBox.Show(
                strMensagemValidacao,
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        public bool TratarEfetivacao()
        {
            if (!ValidarEfetivacao())
            {
                return false;
            }

            Cursor.Current = Cursors.WaitCursor;

            InstrutoresTO ins = new InstrutoresTO();

            ins.IdInstrutor = Convert.ToInt32(txtCodigo.Text);
            ins.Nome = txtNome.Text.Trim();
            ins.Sobrenome = txtSobrenome.Text.Trim();
            ins.Cpf = txtCPF.Text.Trim();
            ins.Ativo = Convert.ToInt32(chkAtivo.Checked);

            InstrutoresBLL.TratarEfetivacao(out strMensagem, out booRetorno, booInclusao, ins);

            Cursor.Current = Cursors.Default;

            return booRetorno;
        }

        public void ConfirmarSaida(FormClosingEventArgs pSaida)
        {
            // formatação da caixa de mensagem.
            String Mensagem = "Deseja efetivar operação em andamento ?";
            String Titulo = "Confirmação";
            MessageBoxButtons Botao = MessageBoxButtons.YesNo;
            MessageBoxIcon Icone = MessageBoxIcon.Question;

            // caso clique para não efetivar, tela será fechada ignorando processo em andamento
            if (MessageBox.Show(Mensagem, Titulo, Botao, Icone) == DialogResult.No)
            {
                Dispose(true);
            }
            // caso clique em sim, insert ou update será efetivado no banco
            else
            {
                if (!TratarEfetivacao())
                {
                    pSaida.Cancel = true;
                }
            }
        }

        #endregion

        #region eventos

        private void FrmInstrutores_Load(object sender, System.EventArgs e)
        {
            booModoEscrita = false;
            HabilitarObjetos();

            MontarGrid();
        }

        private void grdInstrutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MontarDetalhe();
        }

        private void grdInstrutores_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            MontarDetalhe();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            booModoEscrita = true;
            booInclusao = true;

            HabilitarObjetos();

            LimparCampos();
            txtCodigo.Text = Convert.ToString(InstrutoresBLL.ContarInstrutores(out strMensagem, out booRetorno));
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            booModoEscrita = true;
            booInclusao = false;

            HabilitarObjetos();
        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            LimparCampos();

            // atualizar tabela
            MontarGrid();

            booModoEscrita = false;
            booInclusao = false;

            HabilitarObjetos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // se tela estiver em modo de escrita, realizar insert/update no bd
            if (booModoEscrita)
            {
                if (TratarEfetivacao())
                {
                    // atualizar tabela
                    MontarGrid();

                    // desabilita modo de escrita
                    booModoEscrita = false;
                    booInclusao = false;

                    HabilitarObjetos();
                }
            }
        }

        private void FrmInstrutores_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (booModoEscrita)
            {
                ConfirmarSaida(e);
            }
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}