using System;
using System.Windows.Forms;

namespace EspacoTP
{
    public partial class FrmPagamentosConsulta : Form
    {
        public FrmPagamentosConsulta()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            FrmPagamentosCadastro PgCad = new FrmPagamentosCadastro();
            PgCad.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FrmPagamentosCadastro PgCad = new FrmPagamentosCadastro();
            PgCad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmPagamentosCadastro PgCad = new FrmPagamentosCadastro();
            PgCad.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmPagamentosCadastro PgCad = new FrmPagamentosCadastro();
            PgCad.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmPagamentosCadastro PgCad = new FrmPagamentosCadastro();
            PgCad.Show();
        }
    }
}
