using EspacoTP.BLL;
using EspacoTP.MODEL;
using EspacoTP.UTIL;
using System;
using System.Windows.Forms;

namespace EspacoTP
{
    public partial class FrmUsuarios : Form
    {
        #region construtor
        public FrmUsuarios(bool pbooUsuarioLogadoAdministrador)
        {
            InitializeComponent();
            this.booUsuarioLogadoAdministrador = pbooUsuarioLogadoAdministrador;
        }

        #endregion

        #region variáveis

        bool booRetorno = default(bool);
        string strMensagem = default(string);

        bool booModoEscrita = false;
        bool booInclusao = false;
        bool booUsuarioLogadoAdministrador = default(bool);

        #endregion

        #region métodos

        public void HabilitarObjetos()
        {
            // tela em modo de escrita apenas para usuários com perfil de administrador
            if (booUsuarioLogadoAdministrador && booModoEscrita)
            {
                btnIncluir.Enabled = false;
                btnAlterar.Enabled = false;
                btnDesfazer.Enabled = true;
                btnSalvar.Enabled = true;

                txtNome.Enabled = true;
                txtUsuario.Enabled = booInclusao;
                txtSenha.Enabled = true;
                chkAtivo.Enabled = true;
                radAdministrador.Enabled = true;
                radPadrao.Enabled = true;

            }
            else
            {
                btnIncluir.Enabled = booUsuarioLogadoAdministrador;
                btnAlterar.Enabled = booUsuarioLogadoAdministrador;
                btnDesfazer.Enabled = false;
                btnSalvar.Enabled = false;

                txtNome.Enabled = false;
                txtUsuario.Enabled = false;
                txtSenha.Enabled = false;
                chkAtivo.Enabled = false;
                radAdministrador.Enabled = false;
                radPadrao.Enabled = false;
            }
        }

        public void LimparCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
            chkAtivo.Checked = true;
            radPadrao.Checked = true;
            radAdministrador.Checked = false;
        }

        public void MontarGrid()
        {
            grdUsuarios.DataSource = UsuariosBLL.Buscar(out strMensagem, out booRetorno);
        }

        public void MontarDetalhe()
        {
            txtCodigo.Text = grdUsuarios.Rows[grdUsuarios.CurrentRow.Index].Cells["colId"].Value.ToString();
            txtNome.Text = grdUsuarios.Rows[grdUsuarios.CurrentRow.Index].Cells["colNome"].Value.ToString();
            txtUsuario.Text = grdUsuarios.Rows[grdUsuarios.CurrentRow.Index].Cells["colUsuario"].Value.ToString();
            txtSenha.Text = grdUsuarios.Rows[grdUsuarios.CurrentRow.Index].Cells["colSenha"].Value.ToString();
            chkAtivo.Checked = (bool)grdUsuarios.Rows[grdUsuarios.CurrentRow.Index].Cells["colAtivo"].Value;

            // tratamento para setar tipo do usuário selecionado na tabela
            bool booUsuarioSelecionadoAdministrador = false;
            booUsuarioSelecionadoAdministrador = (bool)grdUsuarios.Rows[grdUsuarios.CurrentRow.Index].Cells["colAdmin"].Value;
            radAdministrador.Checked = booUsuarioSelecionadoAdministrador;
            radPadrao.Checked = !booUsuarioSelecionadoAdministrador;
        }

        public bool ValidarEfetivacao()
        {
            string strMensagemValidacao = "";

            if (!Validacoes.ValidarCampoEmBranco(txtNome.Text.Trim()))
            {
                strMensagemValidacao = strMensagemValidacao + "\n - Campo NOME é obrigatório.";
            }

            if (!Validacoes.ValidarCampoEmBranco(txtUsuario.Text.Trim()))
            {
                strMensagemValidacao = strMensagemValidacao + "\n - Campo USUÁRIO é obrigatório.";
            }
            else
            {
                if (!Validacoes.ValidarCampoComEspaco(txtUsuario.Text.Trim()))
                {
                    strMensagemValidacao = strMensagemValidacao + "\n - Campo USUÁRIO não pode conter espaço.";
                }

                if (booInclusao)
                {
                    if (!UsuariosBLL.ValidarUsuarioExistente(out strMensagem, out booRetorno, txtUsuario.Text.Trim()))
                    {
                        strMensagemValidacao = strMensagemValidacao + "\n - USUÁRIO já cadastrado.";
                    }
                }

            }

            if (!Validacoes.ValidarCampoEmBranco(txtSenha.Text.Trim()))
            {
                strMensagemValidacao = strMensagemValidacao + "\n - Campo SENHA é obrigatório.";
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

            if (booUsuarioLogadoAdministrador)
            {
                // define o tipo de usuário padrão
                int intIndiceTipoUsuario = 2;

                // altera o índice no banco de dados, caso o radio 'administrador' esteja selecionado
                if (radAdministrador.Checked)
                {
                    intIndiceTipoUsuario = 1;
                }

                Cursor.Current = Cursors.WaitCursor;

                UsuariosTO usr = new UsuariosTO();
                usr.IdUsuario = Convert.ToInt32(txtCodigo.Text);
                usr.Nome = txtNome.Text.Trim();
                usr.Usuario = txtUsuario.Text.Trim();
                usr.Senha = txtSenha.Text.Trim();
                usr.IdTipoUsuario = intIndiceTipoUsuario;
                usr.Ativo = Convert.ToInt32(chkAtivo.Checked);

                UsuariosBLL.TratarEfetivacao(out strMensagem, out booRetorno, booInclusao, usr);

                Cursor.Current = Cursors.Default;
            }

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

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            booModoEscrita = false;
            HabilitarObjetos();

            MontarGrid();
        }

        private void grdUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MontarDetalhe();
        }

        private void grdUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            MontarDetalhe();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            booModoEscrita = true;
            booInclusao = true;

            HabilitarObjetos();

            LimparCampos();
            txtCodigo.Text = Convert.ToString(UsuariosBLL.ContarUsuarios(out strMensagem, out booRetorno));
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

        private void FrmUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (booModoEscrita)
            {
                ConfirmarSaida(e);
            }
        }

        #endregion
    }
}