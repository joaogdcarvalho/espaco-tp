using EspacoTP.BLL;
using EspacoTP.UTIL;
using estudio_tp.Model;
using System;
using System.Windows.Forms;

namespace EspacoTP
{
    public partial class FrmPeriodos : Form
    {
        #region construtor
        public FrmPeriodos(string pstrIdAluno, DateTime pdtpDataInicioContrato, DateTime pdtpDataTerminoContrato)
        {
            InitializeComponent();
            this.numIdAluno = Convert.ToInt32(pstrIdAluno);
            this.dtInicioContrato = pdtpDataInicioContrato;
            this.dtTerminoContrato = pdtpDataTerminoContrato;
        }

        #endregion

        #region variáveis

        bool booRetorno = default(bool);
        string strMensagem = default(string);

        bool booModoEscrita = false;
        bool booInclusao = false;

        int numIdAluno = default(int);
        DateTime dtInicioContrato = default(DateTime);
        DateTime dtTerminoContrato = default(DateTime);

        #endregion

        #region métodos

        private void PopularComboHorario()
        {
            cboHorario.DataSource = AgendamentosBLL.PopularComboHorario(out strMensagem, out booRetorno);
            cboHorario.DisplayMember = "descricao";
        }

        private void PopularComboDia()
        {
            cboDia.DataSource = AgendamentosBLL.PopularComboDia(out strMensagem, out booRetorno);
            cboDia.DisplayMember = "descricao";
        }

        public void HabilitarObjetos()
        {
            if (booModoEscrita)
            {
                btnIncluir.Enabled = false;
                btnAlterar.Enabled = false;
                btnDesfazer.Enabled = true;
                btnSalvar.Enabled = true;

                if (booInclusao)
                {
                    cboDia.Enabled = true;
                    cboHorario.Enabled = true;
                    chkAtivo.Enabled = true;
                }
                else
                {
                    cboDia.Enabled = false;
                    cboHorario.Enabled = false;
                    chkAtivo.Enabled = true;
                }
            }
            else
            {
                btnIncluir.Enabled = true;
                btnAlterar.Enabled = true;
                btnDesfazer.Enabled = false;
                btnSalvar.Enabled = false;

                cboDia.Enabled = false;
                cboHorario.Enabled = false;
                chkAtivo.Enabled = false;
            }
        }

        public void LimparCampos()
        {
            cboDia.Text = "";
            cboHorario.Text = "";
            chkAtivo.Checked = true;
        }

        public void MontarGrid()
        {
            grdPeriodos.DataSource = PeriodosBLL.Buscar(out strMensagem, out booRetorno, numIdAluno);
        }

        public void MontarDetalhe()
        {
            txtCodigoPeriodo.Text = grdPeriodos.Rows[grdPeriodos.CurrentRow.Index].Cells["colIdPeriodo"].Value.ToString();
            cboDia.SelectedIndex = Convert.ToInt32(grdPeriodos.Rows[grdPeriodos.CurrentRow.Index].Cells["colIdDiaAgendamento"].Value) - 1;
            cboHorario.SelectedIndex = Convert.ToInt32(grdPeriodos.Rows[grdPeriodos.CurrentRow.Index].Cells["colIdHorarioAgendamento"].Value) - 1;
            chkAtivo.Checked = (bool)grdPeriodos.Rows[grdPeriodos.CurrentRow.Index].Cells["colAtivo"].Value;
        }

        public bool ValidarEfetivacao()
        {
            string strMensagemValidacao = "";

            if (!Validacoes.ValidarCampoEmBranco(cboHorario.SelectedValue.ToString()))
            {
                strMensagemValidacao = strMensagemValidacao + "\n - Campo HORÁRIO é obrigatório.";
            }
            else
            {
                int numCodigoAluno = Convert.ToInt32(txtCodigoAluno.Text);
                int numIdDiaPeriodo = (cboDia.SelectedIndex + 1);
                int numIdHorarioPeriodo = (cboHorario.SelectedIndex + 1);

                if (booInclusao)
                {
                    if (!PeriodosBLL.ValidarPeriodoRepetido(out strMensagem, out booRetorno, numCodigoAluno, numIdDiaPeriodo, numIdHorarioPeriodo))
                    {
                        strMensagemValidacao = strMensagemValidacao + "\n - PERÍODO já cadastrado.";
                    }
                }
                

                if (!PeriodosBLL.ValidarDiaRepetido(out strMensagem, out booRetorno, numCodigoAluno, numIdDiaPeriodo, numIdHorarioPeriodo))
                {
                    strMensagemValidacao = strMensagemValidacao + "\n - ALUNO possui PERÍODO ativo para esse dia. "; // + strHorarioAgendamento + ".";
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

            PeriodosTO per = new PeriodosTO();
            per.IdPeriodo = Convert.ToInt32(txtCodigoPeriodo.Text.Trim());
            per.IdAluno = Convert.ToInt32(txtCodigoAluno.Text.Trim());
            per.IdDiaAgendamento = Convert.ToInt32(cboDia.SelectedIndex) + 1;
            per.IdHoraAgendamento = Convert.ToInt32(cboHorario.SelectedIndex) + 1;
            per.Ativo = Convert.ToInt32(chkAtivo.Checked);

            PeriodosBLL.TratarEfetivacao(out strMensagem, out booRetorno, booInclusao, per);

            if (booInclusao)
            {
                AgendamentosBLL.IncluirAgendamentoFlexivel(out strMensagem, out booRetorno, per.IdAluno, dtpDataInicioContrato.Value, dtpDataTerminoContrato.Value, Convert.ToInt32(cboDia.SelectedIndex), per.IdHoraAgendamento);
            }

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

        private void FrmPeriodos_Load(object sender, EventArgs e)
        {
            txtCodigoAluno.Text = numIdAluno.ToString();
            dtpDataInicioContrato.Value = dtInicioContrato;
            dtpDataTerminoContrato.Value = dtTerminoContrato;

            PopularComboHorario();
            PopularComboDia();

            LimparCampos();

            booModoEscrita = false;
            HabilitarObjetos();

            MontarGrid();
        }

        private void grdPeriodos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MontarDetalhe();
        }

        private void grdPeriodos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            MontarDetalhe();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            booModoEscrita = true;
            booInclusao = true;

            HabilitarObjetos();

            LimparCampos();
            txtCodigoPeriodo.Text = Convert.ToString(PeriodosBLL.ContarPeriodos(out strMensagem, out booRetorno));
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

        private void FrmPeriodos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (booModoEscrita)
            {
                ConfirmarSaida(e);
            }
        }

        #endregion
    }
}