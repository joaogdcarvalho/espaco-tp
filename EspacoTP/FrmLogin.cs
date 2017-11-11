using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using EspacoTP.UTIL;
using EspacoTP.MODEL;
using EspacoTP.BLL;

namespace EspacoTP
{
    public partial class FrmLogin : Form
    {
        #region construtor
        public FrmLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region variáveis

        bool booRetorno = default(bool);
        string strMensagem = default(string);
        bool booUsuarioAdmin = false;

        #endregion

        #region métodos
        private bool ValidarCampos()
        {
            if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                txtUsuario.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txtSenha.Text))
            {
                txtSenha.Focus();
                return false;
            }
            return true;
        }

        private void LimparDados()
        {
            txtUsuario.Text = null;
            txtSenha.Text = null;
        }

        private void ApresentarMensagemValidacao()
        {
            MessageBox.Show(
                String.Concat("USUÁRIO E/OU SENHA INVÁLIDOS."),
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        #endregion

        #region eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                ApresentarMensagemValidacao();
                return;
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;

                UsuariosTO usr = new UsuariosTO();
                usr.Usuario = txtUsuario.Text.Trim();
                usr.Senha = txtSenha.Text.Trim();

                if (UsuariosBLL.ValidarLogin(out strMensagem, out booRetorno, usr))
                {
                    booUsuarioAdmin = UsuariosBLL.ValidarUsuarioAdministrador(out strMensagem, out booRetorno, usr);

                    this.Hide();
                    FrmPainel Pai = new FrmPainel(booUsuarioAdmin);
                    Pai.Closed += (s, args) => this.Close();
                    Pai.Show();

                    FrmAgenda Age = new FrmAgenda();
                    Age.Show();
                }
                else
                {
                    ApresentarMensagemValidacao();
                    txtUsuario.Focus();
                }

                Cursor.Current = Cursors.Default;
            }
        }
        #endregion

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }
    }
}