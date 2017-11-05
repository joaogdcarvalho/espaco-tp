using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EspacoTP.MODEL;
using EspacoTP.DAL;
using EspacoTP.UTIL;
using System.Data;

namespace EspacoTP.UTIL
{
    static class Validacoes
    {
        public static bool ValidarCampoEmBranco(string pstrCampo)
        {
            bool booResultado = false;

            if ((!string.IsNullOrEmpty(pstrCampo) || (pstrCampo != "")))
            {
                booResultado = true;
            }

            return booResultado;
        }

        public static bool ValidarCampoComEspaco(string pstrCampo)
        {
            bool booResultado = false;

            if (!pstrCampo.Contains(" "))
            {
                booResultado = true;
            }

            return booResultado;
        }

        public static bool ValidarCPF(string pCPF)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;
            string digito;
            int soma;
            int resto;

            pCPF = pCPF.Trim();
            pCPF = pCPF.Replace(".", "").Replace("-", "");

            if (pCPF.Length != 11)
            {
                return false;
            }

            tempCpf = pCPF.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return pCPF.EndsWith(digito);
        }
    }
}