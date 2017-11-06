using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EspacoTP.MODEL;
using EspacoTP.DAL;
using EspacoTP.UTIL;
using System.Data;
using estudio_tp.Model;

namespace EspacoTP.BLL
{
    class AgendamentosBLL
    {
        public static DataTable Select(out string pstrMensagem, out bool pbooRetorno, string pDataAgendamento, int pNumIdHorarioAgendamento)
        {
            DataTable dtTabela = AgendamentosDAL.Select(out pstrMensagem, out pbooRetorno, pDataAgendamento, pNumIdHorarioAgendamento);

            return dtTabela;
        }

        public static int ContarAlunosTurma(out string pstrMensagem, out bool pbooRetorno, DateTime pDtDataAGendamento, int pNumIdHorarioAgendamento)
        {
            int intResult = AgendamentosDAL.ContarAlunosTurma(out pstrMensagem, out pbooRetorno, pDtDataAGendamento, pNumIdHorarioAgendamento);

            return intResult;
        }

        public static int ContarAgendamentos(out string pstrMensagem, out bool pbooRetorno)
        {
            int intResult = AgendamentosDAL.ContarAgendamentos(out pstrMensagem, out pbooRetorno);

            return intResult;
        }

        public static DataTable PopularComboHorario(out string pstrMensagem, out bool pbooRetorno)
        {
            DataTable dtTabela = AgendamentosDAL.PopularComboHorario(out pstrMensagem, out pbooRetorno);

            return dtTabela;
        }

        public static DataTable PopularComboInstrutor(out string pstrMensagem, out bool pbooRetorno)
        {
            DataTable dtTabela = AgendamentosDAL.PopularComboInstrutor(out pstrMensagem, out pbooRetorno);

            return dtTabela;
        }

        public static DataTable PopularComboDia(out string pstrMensagem, out bool pbooRetorno)
        {
            DataTable dtTabela = AgendamentosDAL.PopularComboDia(out pstrMensagem, out pbooRetorno);

            return dtTabela;
        }

        public static DataTable PopularComboTipoTelefone(out string pstrMensagem, out bool pbooRetorno)
        {
            DataTable dtTabela = AgendamentosDAL.PopularComboTipoTelefone(out pstrMensagem, out pbooRetorno);

            return dtTabela;
        }

        public static bool ValidarTurma(out string pstrMensagem, out bool pbooRetorno, int pnumIdAluno, DateTime pdtDataAgendamento, int pnumIdHorarioAgendamento)
        {
            bool booAlunoIncluso = AgendamentosDAL.ValidarTurma(out pstrMensagem, out pbooRetorno, pnumIdAluno, pdtDataAgendamento, pnumIdHorarioAgendamento);

            // caso já exista um agendamento na turma para o aluno, operação não será continuada
            return !booAlunoIncluso;
        }

        public static bool ValidarAlunoInclusoCronogramaDia(out string pstrMensagem, out bool pbooRetorno, int pnumIdAluno, DateTime pdtDataAgendamento, int pnumIdHorarioAgendamento)
        {
            bool booAlunoIncluso = AgendamentosDAL.ValidarAlunoInclusoCronogramaDia(out pstrMensagem, out pbooRetorno, pnumIdAluno, pdtDataAgendamento, pnumIdHorarioAgendamento);

            // caso já exista um agendamento ativo no dia para o aluno, operação não será continuada
            return !booAlunoIncluso;
        }

        public static bool TratarEfetivacao(out string pstrMensagem, out bool pbooRetorno, bool pbooInclusao, AgendamentosTO pAgendamento)
        {
            bool booEfetivacao = false;
            int intQuantidadeRg = 0;

            if (pbooInclusao)
            {
                intQuantidadeRg = AgendamentosDAL.Insert(out pstrMensagem, out pbooRetorno, pAgendamento);
            }
            else
            {
                intQuantidadeRg = AgendamentosDAL.Update(out pstrMensagem, out pbooRetorno, pAgendamento);
            }

            if (intQuantidadeRg > 0)
            {
                booEfetivacao = true;
            }

            return booEfetivacao;
        }
    }
}
