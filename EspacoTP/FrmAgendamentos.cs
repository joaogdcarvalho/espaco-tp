using EspacoTP.BLL;
using EspacoTP.UTIL;
using estudio_tp.Model;
using System;
using System.Windows.Forms;

namespace EspacoTP
{
    public partial class FrmAgendamentos : Form
    {
        #region construtor

        public FrmAgendamentos(DateTime pdtDataAgendamento, int pnumIdHorarioAgendamento)
        {
            InitializeComponent();
            this.dtDataAgendamento = pdtDataAgendamento;
            this.numIdHorarioAgendamento = pnumIdHorarioAgendamento;
        }

        #endregion

        #region variáveis

        bool booRetorno = default(bool);
        string strMensagem = default(string);

        bool booModoEscrita = false;
        bool booInclusao = false;

        DateTime dtDataAgendamento = DateTime.Now;
        int numIdHorarioAgendamento = 0;

        #endregion

        #region métodos

        private void PopularComboHorario()
        {
            cboHorario.DataSource = AgendamentosBLL.PopularComboHorario(out strMensagem, out booRetorno);
            cboHorario.DisplayMember = "descricao";
        }

        private void PopularComboInstrutor()
        {
            cboInstrutor.DataSource = AgendamentosBLL.PopularComboInstrutor(out strMensagem, out booRetorno);
            cboInstrutor.DisplayMember = "descricao";
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
                    btnBuscarAlunos.Enabled = true;
                }

                chkAtivo.Enabled = true;
            }
            else
            {
                btnIncluir.Enabled = true;
                btnAlterar.Enabled = true;
                btnDesfazer.Enabled = false;
                btnSalvar.Enabled = false;

                btnBuscarAlunos.Enabled = false;

                chkAtivo.Enabled = false;
            }
        }

        public void LimparCampos()
        {
            txtCodigoAluno.Text = "";
            chkAtivo.Checked = true;
        }

        public void MontarGrid()
        {
            grdTurma.DataSource = AgendamentosBLL.Select(out strMensagem, out booRetorno, dtpData.Value.ToString("yyyy-MM-dd"), numIdHorarioAgendamento + 1);
        }

        public void MontarDetalhe()
        {
            txtCodigoAgendamento.Text = grdTurma.Rows[grdTurma.CurrentRow.Index].Cells["colIdAgendamento"].Value.ToString();
            txtCodigoAluno.Text = grdTurma.Rows[grdTurma.CurrentRow.Index].Cells["colIdAluno"].Value.ToString();
            chkAtivo.Checked = (bool)grdTurma.Rows[grdTurma.CurrentRow.Index].Cells["colAulaAgendada"].Value;
        }

        public bool ValidarEfetivacao()
        {
            string strMensagemValidacao = "";

            if (!Validacoes.ValidarCampoEmBranco(txtCodigoAluno.Text.Trim()))
            {
                strMensagemValidacao = strMensagemValidacao + "\n - Campo CÓDIGO DO ALUNO é obrigatório.";
            }
            else
            {
                int numCodigoAluno = Convert.ToInt32(txtCodigoAluno.Text);
                DateTime dtDataAgendamento = dtpData.Value;
                int numIdAgendamento = (numIdHorarioAgendamento + 1);

                // aluno agendado no dia
                if (!AgendamentosBLL.ValidarAlunoInclusoCronogramaDia(out strMensagem, out booRetorno, numCodigoAluno, dtDataAgendamento, numIdAgendamento))
                {
                    strMensagemValidacao = strMensagemValidacao + "\n - ALUNO possui agendamento ativo na data de hoje, às [xx:xx].";
                }

                if (booInclusao)
                {
                    // aluno agendado no mesmo horário
                    if (!AgendamentosBLL.ValidarTurma(out strMensagem, out booRetorno, numCodigoAluno, dtDataAgendamento, numIdAgendamento))
                    {
                        strMensagemValidacao = strMensagemValidacao + "\n - ALUNO já incluso na turma.";
                    }
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

            AgendamentosTO age = new AgendamentosTO();

            age.IdAgendamento = Convert.ToInt32(txtCodigoAgendamento.Text);
            age.IdInstrutor = 1; // manter 1 até que haja tratamento de instrutor
            age.IdAluno = Convert.ToInt32(txtCodigoAluno.Text);
            age.DataAgendamento = dtpData.Value;
            age.IdHorarioAgendamento = (numIdHorarioAgendamento + 1); // índice da combo inicia em zero, id_horario no banco inicia em 1
            age.Ativo = Convert.ToInt32(chkAtivo.Checked);

            AgendamentosBLL.TratarEfetivacao(out strMensagem, out booRetorno, booInclusao, age);

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

        private void FrmAgendamentos_Load(object sender, EventArgs e)
        {
            dtpData.Value = dtDataAgendamento;

            PopularComboHorario();
            cboHorario.SelectedIndex = numIdHorarioAgendamento;

            PopularComboInstrutor();

            booModoEscrita = false;
            HabilitarObjetos();

            MontarGrid();
        }

        private void grdTurma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MontarDetalhe();
        }
        private void grdTurma_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            MontarDetalhe();
        }

        private void btnBuscarAlunos_Click(object sender, EventArgs e)
        {
            FrmAlunosConsulta AluCon = new FrmAlunosConsulta();
            AluCon.ShowDialog();
            if (AluCon.numIdAluno > 0)
            {
                int numIdAluno = AluCon.numIdAluno;
                txtCodigoAluno.Text = numIdAluno.ToString();
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            booModoEscrita = true;
            booInclusao = true;

            HabilitarObjetos();

            LimparCampos();
            txtCodigoAgendamento.Text = Convert.ToString(AgendamentosBLL.ContarAgendamentos(out strMensagem, out booRetorno));
            //txtCodigoAgendamento.Text = Convert.ToString(grdTurma.RowCount + 1);
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

        private void FrmAgendamentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (booModoEscrita)
            {
                ConfirmarSaida(e);
            }
        }

        #endregion
    }
}