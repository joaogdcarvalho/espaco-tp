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
    class PeriodosBLL
    {
        public static DataTable Buscar(out string pstrMensagem, out bool pbooRetorno, int pnumIdAluno)
        {
            DataTable dtTabela = PeriodosDAL.Buscar(out pstrMensagem, out pbooRetorno, pnumIdAluno);

            return dtTabela;
        }

        public static bool TratarEfetivacao(out string pstrMensagem, out bool pbooRetorno, bool pbooInclusao, PeriodosTO pPeriodo)
        {
            bool booEfetivacao = false;
            int intQuantidadeReg = 0;

            if (pbooInclusao)
            {
                intQuantidadeReg = PeriodosDAL.Incluir(out pstrMensagem, out pbooRetorno, pPeriodo);
            }
            else
            {
                intQuantidadeReg = PeriodosDAL.Alterar(out pstrMensagem, out pbooRetorno, pPeriodo);
            }

            if (intQuantidadeReg > 0)
            {
                booEfetivacao = true;
            }

            return booEfetivacao;
        }

        public static int ContarPeriodos(out string pstrMensagem, out bool pbooRetorno)
        {
            int intResult = PeriodosDAL.ContarPeriodos(out pstrMensagem, out pbooRetorno);

            return intResult;
        }

        public static bool ValidarPeriodoRepetido(out string pstrMensagem, out bool pbooRetorno, int pnumIdAluno, int pnumIdDataAgendamento, int pnumIdHorarioAgendamento)
        {
            bool booPeriodoIncluso = PeriodosDAL.ValidarPeriodoRepetido(out pstrMensagem, out pbooRetorno, pnumIdAluno, pnumIdDataAgendamento, pnumIdHorarioAgendamento);
            
            return !booPeriodoIncluso;
        }

        public static bool ValidarDiaRepetido(out string pstrMensagem, out bool pbooRetorno, int pnumIdAluno, int pnumIdDataAgendamento, int pnumIdHorarioAgendamento)
        {
            bool booPeriodoIncluso = PeriodosDAL.ValidarDiaRepetido(out pstrMensagem, out pbooRetorno, pnumIdAluno, pnumIdDataAgendamento, pnumIdHorarioAgendamento);
            
            return !booPeriodoIncluso;
        }

    }
}