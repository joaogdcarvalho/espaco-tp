using EspacoTP.BLL;
using EspacoTP.MODEL;
using EspacoTP.UTIL;
using System;
using System.Windows.Forms;

namespace EspacoTP
{
    public partial class FrmAlunos : Form
    {
        #region construtor
        public FrmAlunos()
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
                txtNome.Enabled = true;
                txtSobrenome.Enabled = true;
                txtCPF.Enabled = true;
                txtNumeroTelefone.Enabled = true;
                txtEmail.Enabled = true;
                dtpDataInicioContrato.Enabled = true;
                dtpDataTerminoContrato.Enabled = true;

                btnPeriodos.Enabled = false;
                btnAlterar.Enabled = false;
                btnFrequencia.Enabled = false;

                txtCEP.Enabled = true;
                txtLogradouro.Enabled = true;
                txtNumeroResidencia.Enabled = true;
                txtBairro.Enabled = true;
                txtMunicipio.Enabled = true;

                btnBuscarAlunos.Enabled = false;
                btnIncluir.Enabled = false;
                btnDesfazer.Enabled = true;
                btnSalvar.Enabled = true;
            }
            else
            {
                txtNome.Enabled = false;
                txtSobrenome.Enabled = false;
                txtCPF.Enabled = false;
                txtNumeroTelefone.Enabled = false;
                txtEmail.Enabled = false;
                dtpDataInicioContrato.Enabled = false;
                dtpDataTerminoContrato.Enabled = false;

                // permitir manipulação de dados de alunos, apenas caso haja alguma busca realizada
                if (txtCodigo.Text.Trim() == "")
                {
                    btnPeriodos.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnFrequencia.Enabled = false;
                }
                else
                {
                    btnPeriodos.Enabled = true;
                    btnAlterar.Enabled = true;
                    btnFrequencia.Enabled = true;
                }

                txtCEP.Enabled = false;
                txtLogradouro.Enabled = false;
                txtNumeroResidencia.Enabled = false;
                txtBairro.Enabled = false;
                txtMunicipio.Enabled = false;

                btnBuscarAlunos.Enabled = true;
                btnIncluir.Enabled = true;
                btnDesfazer.Enabled = false;
                btnSalvar.Enabled = false;
            }
        }

        public void LimparCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtCPF.Text = "";
            txtNumeroTelefone.Text = "";

            txtEmail.Text = "";
            dtpDataInicioContrato.Value = DateTime.Now;
            dtpDataTerminoContrato.Value = DateTime.Now;
            txtCEP.Text = "";
            txtLogradouro.Text = "";

            txtNumeroResidencia.Text = "";
            txtBairro.Text = "";
            txtMunicipio.Text = "";
        }

        public void MontarDetalhe()
        {
            if (txtCodigo.Text.Trim() != "")
            {
                Cursor.Current = Cursors.WaitCursor;

                AlunosTO alu = new AlunosTO();

                alu = AlunosBLL.DetalharAluno(out strMensagem, out booRetorno, Convert.ToInt32(txtCodigo.Text.Trim()));

                txtNome.Text = alu.Nome;
                txtSobrenome.Text = alu.Sobrenome;
                txtCPF.Text = alu.Cpf;
                txtNumeroTelefone.Text = alu.NumeroTelefone;
                txtEmail.Text = alu.Email;

                dtpDataInicioContrato.Value = alu.DataInicioContrato;
                dtpDataTerminoContrato.Value = alu.DataTerminoContrato;
                txtCEP.Text = alu.Cep;
                txtLogradouro.Text = alu.Logradouro;
                txtNumeroResidencia.Text = alu.NumeroResidencial.ToString();

                txtBairro.Text = alu.Bairro;
                //alu.Estado = "SP";
                txtMunicipio.Text = alu.Municipio;
                //alu.ValorAula = 14.95M;

                Cursor.Current = Cursors.Default;
            }
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

            AlunosTO alu = new AlunosTO();

            alu.IdAluno = Convert.ToInt32(txtCodigo.Text.Trim());
            alu.Nome = txtNome.Text.Trim();
            alu.Sobrenome = txtSobrenome.Text.Trim();
            alu.Cpf = txtCPF.Text.Trim();
            alu.IdTipoTelefone = 3;

            alu.NumeroTelefone = txtNumeroTelefone.Text.Trim();
            alu.Email = txtEmail.Text.Trim();
            alu.DataInicioContrato = dtpDataInicioContrato.Value;
            alu.DataTerminoContrato = dtpDataTerminoContrato.Value;
            if (!string.IsNullOrEmpty(txtCEP.Text.Trim()))
            {
                alu.Cep = txtCEP.Text.Trim();
            }
            

            alu.Logradouro = txtLogradouro.Text.Trim();
            if (!string.IsNullOrEmpty(txtNumeroResidencia.Text.Trim()))
            {
                alu.NumeroResidencial = txtNumeroResidencia.Text.Trim();
            }
            alu.Bairro = txtBairro.Text.Trim();
            alu.Estado = "SP";
            alu.Municipio = txtMunicipio.Text.Trim();

            alu.ValorAula = 14.95M;

            AlunosBLL.TratarEfetivacao(out strMensagem, out booRetorno, booInclusao, alu);

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

        private void FrmAlunos_Load(object sender, System.EventArgs e)
        {
            dtpDataInicioContrato.Value = DateTime.Now;
            dtpDataTerminoContrato.Value = DateTime.Now;

            booModoEscrita = false;
            HabilitarObjetos();
        }

        private void btnBuscarAlunos_Click(object sender, EventArgs e)
        {
            FrmAlunosConsulta AluCon = new FrmAlunosConsulta();
            AluCon.ShowDialog();

            if (AluCon.numIdAluno > 0)
            {
                int numIdAluno = AluCon.numIdAluno;
                txtCodigo.Text = numIdAluno.ToString();

                MontarDetalhe();

                booModoEscrita = false;
                booInclusao = false;

                HabilitarObjetos();
            }
        }

        private void btnPeriodos_Click(object sender, EventArgs e)
        {
            FrmPeriodos per = new FrmPeriodos(txtCodigo.Text);
            per.Show();
        }

        private void btnFrequencia_Click(object sender, EventArgs e)
        {
            FrmFrequencia fre = new FrmFrequencia();
            fre.Show();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            booModoEscrita = true;
            booInclusao = true;

            HabilitarObjetos();

            LimparCampos();
            txtCodigo.Text = Convert.ToString(AlunosBLL.ContarAlunos(out strMensagem, out booRetorno));
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
            // MontarGrid();

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
                    // atualizar campos
                    MontarDetalhe();

                    // desabilita modo de escrita
                    booModoEscrita = false;
                    booInclusao = false;

                    HabilitarObjetos();
                }
            }
        }

        private void FrmAlunos_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txtNumeroTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtNumeroResidencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}