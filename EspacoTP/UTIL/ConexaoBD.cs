using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace EspacoTP.UTIL
{
    class ConexaoBD
    {
        #region ATRIBUTOS

        //  variável global da classe
        private static MySqlConnection strConexao = default(MySqlConnection);

        #endregion

        #region MÉTODOS

        public static MySqlConnection CriarConexao(out string pstrMsg, out bool pbooRetorno)
        {
            pstrMsg = default(string);
            pbooRetorno = default(bool);
            string strBanco = "Server = 127.0.0.1; Port=3306; Database=espaco_tp;Uid=root;Pwd=#OPE1632@fit"; //Enum.TipoConexaoBanco.ProducaoConexaoLocal.ToString();
            try
            {
                strConexao = new MySqlConnection(strBanco);
                if (strConexao.State == ConnectionState.Closed)
                {
                    strConexao.Open();
                    pbooRetorno = true;
                }
            }
            catch (MySqlException ex)
            {
                pstrMsg = ex.Message;
                pbooRetorno = false;
            }
            return strConexao;
        }
        
        #endregion
    }
}
