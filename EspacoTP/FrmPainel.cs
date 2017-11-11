using EspacoTP.MODEL;
using System;
using System.Windows.Forms;

namespace EspacoTP
{
    public partial class FrmPainel : Form
    {
        bool booUsuarioAdmin = false;
        public FrmPainel(bool pUsuarioLogado)
        {
            InitializeComponent();
            this.booUsuarioAdmin = pUsuarioLogado;

        }

        private void mniUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios Usu = new FrmUsuarios(booUsuarioAdmin);
            Usu.Show();
        }

        private void mniInstrutores_Click(object sender, EventArgs e)
        {
            FrmInstrutores Ins = new FrmInstrutores();
            Ins.Show();
        }

        private void mniAlunos_Click(object sender, EventArgs e)
        {
            FrmAlunos Alu = new FrmAlunos();
            Alu.Show();
        }        

        private void mniAgenda_Click(object sender, EventArgs e)
        {
            FrmAgenda Age = new FrmAgenda();
            Age.Show();
        }

        private void FrmPainel_Load(object sender, EventArgs e)
        {            
        }
    }
}