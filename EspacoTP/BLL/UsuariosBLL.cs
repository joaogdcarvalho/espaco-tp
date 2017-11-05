using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EspacoTP.MODEL;
using EspacoTP.DAL;
using EspacoTP.UTIL;
using System.Data;

namespace EspacoTP.BLL
{
    class UsuariosBLL
    {
        public static DataTable Buscar(out string pstrMensagem, out bool pbooRetorno)
        {
            DataTable dtTabela = UsuariosDAL.Buscar(out pstrMensagem, out pbooRetorno);

            return dtTabela;
        }

        public static bool TratarEfetivacao(out string pstrMensagem, out bool pbooRetorno, bool pbooInclusao, UsuariosTO pUsuario)
        {
            bool booEfetivacao = false;
            int intQuantidadeReg = 0;

            if (pbooInclusao)
            {
                intQuantidadeReg = UsuariosDAL.Incluir(out pstrMensagem, out pbooRetorno, pUsuario);
            }
            else
            {
                intQuantidadeReg = UsuariosDAL.Alterar(out pstrMensagem, out pbooRetorno, pUsuario);
            }

            if (intQuantidadeReg > 0)
            {
                booEfetivacao = true;
            }

            return booEfetivacao;
        }

        public static bool ValidarLogin(out string pstrMensagem, out bool pbooRetorno, UsuariosTO pUsuario)
        {
            bool booPermitirLogin = UsuariosDAL.ValidarLogin(out pstrMensagem, out pbooRetorno, pUsuario);

            return booPermitirLogin;
        }

        public static bool ValidarUsuarioExistente(out string pstrMensagem, out bool pbooRetorno, string pUsuario)
        {
            bool booUsuarioExistente = UsuariosDAL.ValidarUsuarioExistente(out pstrMensagem, out pbooRetorno, pUsuario);

            // caso já exista o nome digitado, usuário terá que definir um diferente
            return !booUsuarioExistente;
        }

        public static bool ValidarUsuarioAdministrador(out string pstrMensagem, out bool pbooRetorno, UsuariosTO pUsuario)
        {
            bool booUsuarioAdministrador = UsuariosDAL.ValidarUsuarioAdministrador(out pstrMensagem, out pbooRetorno, pUsuario);

            return booUsuarioAdministrador;
        }

        public static int ContarUsuarios(out string pstrMensagem, out bool pbooRetorno)
        {
            int intResult = UsuariosDAL.ContarUsuarios(out pstrMensagem, out pbooRetorno);

            return intResult;
        }
    }
}