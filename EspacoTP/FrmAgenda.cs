using EspacoTP.BLL;
using System;
using System.Windows.Forms;

namespace EspacoTP
{
    public partial class FrmAgenda : Form
    {
        #region construtor
        public FrmAgenda()
        {
            InitializeComponent();
        }
        #endregion

        #region variáveis

        bool booRetorno = default(bool);
        string strMensagem = default(string);
        bool booModoEscrita = false;

        #endregion

        #region métodos

        public void HabilitarObjetos(bool pbooModoEscrita)
        {
            if (pbooModoEscrita)
            {
                dtpData.Enabled = false;

                BtnHora1.Enabled = true;
                BtnHora2.Enabled = true;
                BtnHora3.Enabled = true;
                BtnHora4.Enabled = true;
                BtnHora5.Enabled = true;
                BtnHora6.Enabled = true;
                BtnHora7.Enabled = true;
                BtnHora8.Enabled = true;
                BtnHora9.Enabled = true;
                BtnHora10.Enabled = true;
                BtnHora11.Enabled = true;
                BtnHora12.Enabled = true;
                BtnHora13.Enabled = true;
                BtnHora14.Enabled = true;
            }
            else
            {
                dtpData.Enabled = true;

                BtnHora1.Enabled = false;
                BtnHora2.Enabled = false;
                BtnHora3.Enabled = false;
                BtnHora4.Enabled = false;
                BtnHora5.Enabled = false;
                BtnHora6.Enabled = false;
                BtnHora7.Enabled = false;
                BtnHora8.Enabled = false;
                BtnHora9.Enabled = false;
                BtnHora10.Enabled = false;
                BtnHora11.Enabled = false;
                BtnHora12.Enabled = false;
                BtnHora13.Enabled = false;
                BtnHora14.Enabled = false;
            }
        }

        public void LimparCampos()
        {
            dtpData.Value = DateTime.Now;

            BtnHora1.Text = "";
            BtnHora2.Text = "";
            BtnHora3.Text = "";
            BtnHora4.Text = "";
            BtnHora5.Text = "";
            BtnHora6.Text = "";
            BtnHora7.Text = "";
            BtnHora8.Text = "";
            BtnHora9.Text = "";
            BtnHora10.Text = "";
            BtnHora11.Text = "";
            BtnHora12.Text = "";
            BtnHora13.Text = "";
            BtnHora14.Text = "";
        }

        public void ContarAgendamentos()
        {
            Cursor.Current = Cursors.WaitCursor;
            
            BtnHora1.Text = AgendamentosBLL.ContarAlunosTurma(out strMensagem, out booRetorno, dtpData.Value, 1).ToString();
            BtnHora2.Text = AgendamentosBLL.ContarAlunosTurma(out strMensagem, out booRetorno, dtpData.Value, 2).ToString();
            BtnHora3.Text = AgendamentosBLL.ContarAlunosTurma(out strMensagem, out booRetorno, dtpData.Value, 3).ToString();
            BtnHora4.Text = AgendamentosBLL.ContarAlunosTurma(out strMensagem, out booRetorno, dtpData.Value, 4).ToString();
            BtnHora5.Text = AgendamentosBLL.ContarAlunosTurma(out strMensagem, out booRetorno, dtpData.Value, 5).ToString();
            BtnHora6.Text = AgendamentosBLL.ContarAlunosTurma(out strMensagem, out booRetorno, dtpData.Value, 6).ToString();
            BtnHora7.Text = AgendamentosBLL.ContarAlunosTurma(out strMensagem, out booRetorno, dtpData.Value, 7).ToString();
            BtnHora8.Text = AgendamentosBLL.ContarAlunosTurma(out strMensagem, out booRetorno, dtpData.Value, 8).ToString();
            BtnHora9.Text = AgendamentosBLL.ContarAlunosTurma(out strMensagem, out booRetorno, dtpData.Value, 9).ToString();
            BtnHora10.Text = AgendamentosBLL.ContarAlunosTurma(out strMensagem, out booRetorno, dtpData.Value, 10).ToString();
            BtnHora11.Text = AgendamentosBLL.ContarAlunosTurma(out strMensagem, out booRetorno, dtpData.Value, 11).ToString();
            BtnHora12.Text = AgendamentosBLL.ContarAlunosTurma(out strMensagem, out booRetorno, dtpData.Value, 12).ToString();
            BtnHora13.Text = AgendamentosBLL.ContarAlunosTurma(out strMensagem, out booRetorno, dtpData.Value, 13).ToString();
            BtnHora14.Text = AgendamentosBLL.ContarAlunosTurma(out strMensagem, out booRetorno, dtpData.Value, 14).ToString();

            Cursor.Current = Cursors.Default;
        }

        #endregion

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            dtpData.Value = DateTime.Now;

            booModoEscrita = false;
            HabilitarObjetos(booModoEscrita);

            btnLimpar.Enabled = false;
            btnBuscar.Enabled = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();

            booModoEscrita = false;
            HabilitarObjetos(booModoEscrita);

            btnLimpar.Enabled = false;
            btnBuscar.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            booModoEscrita = true;
            HabilitarObjetos(booModoEscrita);

            ContarAgendamentos();

            btnLimpar.Enabled = true;
            btnBuscar.Enabled = false;            
        }

        private void BtnHora1_Click(object sender, EventArgs e)
        {
            FrmAgendamentos det = new FrmAgendamentos(dtpData.Value, 0);
            det.ShowDialog();
            ContarAgendamentos();
        }

        private void BtnHora2_Click(object sender, EventArgs e)
        {
            FrmAgendamentos det = new FrmAgendamentos(dtpData.Value, 1);
            det.ShowDialog();
            ContarAgendamentos();
        }

        private void BtnHora3_Click(object sender, EventArgs e)
        {
            FrmAgendamentos det = new FrmAgendamentos(dtpData.Value, 2);
            det.ShowDialog();
            ContarAgendamentos();
        }

        private void BtnHora4_Click(object sender, EventArgs e)
        {
            FrmAgendamentos det = new FrmAgendamentos(dtpData.Value, 3);
            det.ShowDialog();
            ContarAgendamentos();
        }

        private void BtnHora5_Click(object sender, EventArgs e)
        {
            FrmAgendamentos det = new FrmAgendamentos(dtpData.Value, 4);
            det.ShowDialog();
            ContarAgendamentos();
        }

        private void BtnHora6_Click(object sender, EventArgs e)
        {
            FrmAgendamentos det = new FrmAgendamentos(dtpData.Value, 5);
            det.ShowDialog();
            ContarAgendamentos();
        }

        private void BtnHora7_Click(object sender, EventArgs e)
        {
            FrmAgendamentos det = new FrmAgendamentos(dtpData.Value, 6);
            det.ShowDialog();
            ContarAgendamentos();
        }

        private void BtnHora8_Click(object sender, EventArgs e)
        {
            FrmAgendamentos det = new FrmAgendamentos(dtpData.Value, 7);
            det.ShowDialog();
            ContarAgendamentos();
        }

        private void BtnHora9_Click(object sender, EventArgs e)
        {
            FrmAgendamentos det = new FrmAgendamentos(dtpData.Value, 8);
            det.ShowDialog();
            ContarAgendamentos();
        }

        private void BtnHora10_Click(object sender, EventArgs e)
        {
            FrmAgendamentos det = new FrmAgendamentos(dtpData.Value, 9);
            det.ShowDialog();
            ContarAgendamentos();
        }

        private void BtnHora11_Click(object sender, EventArgs e)
        {
            FrmAgendamentos det = new FrmAgendamentos(dtpData.Value, 10);
            det.ShowDialog();
            ContarAgendamentos();
        }

        private void BtnHora12_Click(object sender, EventArgs e)
        {
            FrmAgendamentos det = new FrmAgendamentos(dtpData.Value, 11);
            det.ShowDialog();
            ContarAgendamentos();
        }

        private void BtnHora13_Click(object sender, EventArgs e)
        {
            FrmAgendamentos det = new FrmAgendamentos(dtpData.Value, 12);
            det.ShowDialog();
            ContarAgendamentos();
        }

        private void BtnHora14_Click(object sender, EventArgs e)
        {
            FrmAgendamentos det = new FrmAgendamentos(dtpData.Value, 13);
            det.ShowDialog();
            ContarAgendamentos();
        }
    }
}
