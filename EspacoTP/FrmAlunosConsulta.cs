using EspacoTP.BLL;
using EspacoTP.MODEL;
using System;
using System.Windows.Forms;

namespace EspacoTP
{
    public partial class FrmAlunosConsulta : Form
    {
        #region construtor
        public FrmAlunosConsulta()
        {
            InitializeComponent();
        }

        #endregion

        #region variaveis

        bool booRetorno = default(bool);
        string strMensagem = default(string);

        public int numIdAluno = default(int);
        bool booSelecao = false;

        #endregion

        #region métodos        

        public void LimparCampos()
        {
            txtCodigo.Text = "";
            txtNomeAluno.Text = "";
            txtSobrenomeAluno.Text = "";
            txtCPF.Text = "";
            dtpDataInicioContrato.Value = new DateTime(DateTime.Now.Year - 5, DateTime.Now.Month, DateTime.Now.Day);
            dtpDataTerminoContrato.Value = new DateTime(DateTime.Now.Year + 5, DateTime.Now.Month, DateTime.Now.Day);
        }

        public void MontarGrid()
        {
            AlunosTO alu = new AlunosTO();

            if (txtCodigo.Text.Trim() != "")
            {
                alu.IdAluno = Convert.ToInt32(txtCodigo.Text.Trim());
            }

            if (txtNomeAluno.Text.Trim() != "")
            {
                alu.Nome = txtNomeAluno.Text.Trim();
            }
            
            if (txtSobrenomeAluno.Text.Trim() != "")
            {
                alu.Sobrenome = txtSobrenomeAluno.Text.Trim();
            }

            if (txtCPF.Text.Trim() != "")
            {
                alu.Cpf = txtCPF.Text.Trim();
            }

            alu.DataInicioContrato = dtpDataInicioContrato.Value;
            alu.DataTerminoContrato = dtpDataTerminoContrato.Value;

            grdConsultaAlunos.DataSource = AlunosBLL.Select(out strMensagem, out booRetorno, alu);
        }

        public int ContarRegistros()
        {
            int intCont = grdConsultaAlunos.RowCount;
            return intCont;
        }

        public void HabilitarBtnSelecionarAluno()
        {
            btnSelecionarAluno.Enabled = (ContarRegistros() > 0);
        }

        
        public void MontarDetalhe()
        {
            numIdAluno = Convert.ToInt32(grdConsultaAlunos.Rows[grdConsultaAlunos.CurrentRow.Index].Cells["colId"].Value);
        }        

        public void HabilitarFiltros(bool booOperacao)
        {
            // habilita ou não filtros, conforme parâmetro passado
            txtCodigo.Enabled = booOperacao;
            txtNomeAluno.Enabled = booOperacao;
            txtSobrenomeAluno.Enabled = booOperacao;
            txtCPF.Enabled = booOperacao;
            dtpDataInicioContrato.Enabled = booOperacao;
            dtpDataTerminoContrato.Enabled = booOperacao;
        }

        #endregion

        #region eventos

        private void FrmAlunosConsulta_Load(object sender, EventArgs e)
        {
            dtpDataInicioContrato.Value = new DateTime(DateTime.Now.Year - 5, DateTime.Now.Month, DateTime.Now.Day);
            dtpDataTerminoContrato.Value = new DateTime(DateTime.Now.Year + 5, DateTime.Now.Month, DateTime.Now.Day);

            MontarGrid();

            HabilitarBtnSelecionarAluno();

            // desabilita modificação de valores dos filtros e realização de nova busca
            HabilitarFiltros(false);
            btnBuscar.Enabled = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            booSelecao = false;

            LimparCampos();
            HabilitarFiltros(true);

            MontarGrid();            
            
            btnBuscar.Enabled = true;
            HabilitarBtnSelecionarAluno();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            HabilitarFiltros(false);

            MontarGrid();

            btnBuscar.Enabled = false;
            HabilitarBtnSelecionarAluno();
        }

        private void grdConsultaAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MontarDetalhe();
        }

        private void grdConsultaAlunos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            MontarDetalhe();
        }

        private void btnSelecionarAluno_Click(object sender, EventArgs e)
        {
            booSelecao = true;
            MontarDetalhe();
            this.Close();
        }

        private void FrmAlunosConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!booSelecao)
            {
                numIdAluno = 0;
            }
        }

        #endregion
    }
}
