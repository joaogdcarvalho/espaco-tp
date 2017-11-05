using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EspacoTP.MODEL;
using MySql.Data.MySqlClient;
using EspacoTP.UTIL;
using System.Data;

namespace EspacoTP.DAL
{
    class UsuariosDAL
    {
        #region Query
                
        private const string SELECT = "uspUsuariosBuscar";
        private const string INSERT = "uspUsuariosIncluir";
        private const string UPDATE = "uspUsuariosAlterar";

        private const string VALIDAR_LOGIN = "uspValidarLogin";
        private const string VALIDAR_USUARIO_EXISTENTE = "uspValidarUsuarioExistente";
        private const string VALIDAR_USUARIO_ADMINISTRADOR = "uspValidarUsuarioAdministrador";        
        private const string CONTAR_USUARIOS = "uspContarUsuarios";

        #endregion

        #region Methods

        public static DataTable Buscar(out string pstrMensagem, out bool pbooRetorno)
        {
            DataTable dtTable = new DataTable();
            MySqlConnection conn = ConexaoBD.CriarConexao(out pstrMensagem, out pbooRetorno);
            if (pbooRetorno)
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(SELECT, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            MySqlDataAdapter dtAdapter = new MySqlDataAdapter(cmd);
                            dtAdapter.Fill(dtTable);
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: UsuariosDAL.Buscar'. \n\n{0}.", ex.Message);
                            pbooRetorno = false;
                        }
                        finally
                        {
                            cmd.Connection.Close();
                        }
                    }
                }
            }
            else
            {
                conn.Close();
            }
            return dtTable;
        }

        public static int Incluir(out string pstrMensagem, out bool pbooRetorno, UsuariosTO pUsuario)
        {
            Int32 intResult = 0;
            MySqlConnection conn = ConexaoBD.CriarConexao(out pstrMensagem, out pbooRetorno);
            if (pbooRetorno)
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(INSERT, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            cmd.Parameters.Clear();

                            cmd.Parameters.Add(new MySqlParameter("pStrNome", Convert.ToString(pUsuario.Nome).Trim()));
                            cmd.Parameters.Add(new MySqlParameter("pStrUsuario", Convert.ToString(pUsuario.Usuario).Trim()));
                            cmd.Parameters.Add(new MySqlParameter("pStrSenha", Convert.ToString(pUsuario.Senha).Trim()));
                            cmd.Parameters.Add(new MySqlParameter("pNumTipoUsuario", Convert.ToInt32(pUsuario.IdTipoUsuario)));
                            cmd.Parameters.Add(new MySqlParameter("pBooAtivo", Convert.ToBoolean(pUsuario.Ativo)));

                            intResult = cmd.ExecuteNonQuery();
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: UsuariosDAL.Incluir'. \n\n{0}.", ex.Message);
                            pbooRetorno = false;
                        }
                        finally
                        {
                            cmd.Connection.Close();
                        }
                    }
                }
            }
            else
            {
                conn.Close();
            }
            return intResult;
        }

        public static int Alterar(out string pstrMensagem, out bool pbooRetorno, UsuariosTO pUsuario)
        {
            Int32 intResult = 0;
            MySqlConnection conn = ConexaoBD.CriarConexao(out pstrMensagem, out pbooRetorno);
            if (pbooRetorno)
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(UPDATE, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            cmd.Parameters.Clear();

                            cmd.Parameters.Add(new MySqlParameter("pNumIdUsuario", Convert.ToInt32(pUsuario.IdUsuario)));
                            cmd.Parameters.Add(new MySqlParameter("pStrNome", Convert.ToString(pUsuario.Nome).Trim()));
                            cmd.Parameters.Add(new MySqlParameter("pStrUsuario", Convert.ToString(pUsuario.Usuario).Trim()));
                            cmd.Parameters.Add(new MySqlParameter("pStrSenha", Convert.ToString(pUsuario.Senha).Trim()));
                            cmd.Parameters.Add(new MySqlParameter("pNumTipoUsuario", Convert.ToInt32(pUsuario.IdTipoUsuario)));
                            cmd.Parameters.Add(new MySqlParameter("pBooAtivo", Convert.ToBoolean(pUsuario.Ativo)));

                            intResult = cmd.ExecuteNonQuery();
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: UsuariosDAL.Alterar'. \n\n{0}.", ex.Message);
                            pbooRetorno = false;
                        }
                        finally
                        {
                            cmd.Connection.Close();
                        }
                    }
                }
            }
            else
            {
                conn.Close();
            }
            return intResult;
        }

        public static bool ValidarLogin(out string pstrMensagem, out bool pbooRetorno, UsuariosTO pUsuario)
        {
            bool booResult = false;
            MySqlConnection conn = ConexaoBD.CriarConexao(out pstrMensagem, out pbooRetorno);
            if (pbooRetorno)
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(VALIDAR_LOGIN, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add(new MySqlParameter("pStrUsuario", Convert.ToString(pUsuario.Usuario).Trim()));
                            cmd.Parameters.Add(new MySqlParameter("pStrSenha", Convert.ToString(pUsuario.Senha).Trim()));

                            booResult = Convert.ToBoolean(cmd.ExecuteScalar());
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: UsuariosDAL.ValidarLogin'. \n\n{0}.", ex.Message);
                            pbooRetorno = false;
                        }
                        finally
                        {
                            cmd.Connection.Close();
                        }
                    }
                }
            }
            else
            {
                conn.Close();
            }
            return booResult;
        }

        public static bool ValidarUsuarioExistente(out string pstrMensagem, out bool pbooRetorno, string pNomeUsuario)
        {
            bool booResult = false;
            MySqlConnection conn = ConexaoBD.CriarConexao(out pstrMensagem, out pbooRetorno);
            if (pbooRetorno)
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(VALIDAR_USUARIO_EXISTENTE, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add(new MySqlParameter("pStrUsuario", Convert.ToString(pNomeUsuario).Trim()));

                            booResult = Convert.ToBoolean(cmd.ExecuteScalar());
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: UsuariosDAL.ValidarUsuarioExistente'. \n\n{0}.", ex.Message);
                            pbooRetorno = false;
                        }
                        finally
                        {
                            cmd.Connection.Close();
                        }
                    }
                }
            }
            else
            {
                conn.Close();
            }
            return booResult;
        }

        public static bool ValidarUsuarioAdministrador(out string pstrMensagem, out bool pbooRetorno, UsuariosTO pUsuario)
        {
            bool booResult = false;
            MySqlConnection conn = ConexaoBD.CriarConexao(out pstrMensagem, out pbooRetorno);
            if (pbooRetorno)
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(VALIDAR_USUARIO_ADMINISTRADOR, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add(new MySqlParameter("pStrUsuario", Convert.ToString(pUsuario.Usuario).Trim()));
                            cmd.Parameters.Add(new MySqlParameter("pStrSenha", Convert.ToString(pUsuario.Senha).Trim()));

                            booResult = Convert.ToBoolean(cmd.ExecuteScalar());
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: UsuariosDAL.ValidarUsuarioAdministrador'. \n\n{0}.", ex.Message);
                            pbooRetorno = false;
                        }
                        finally
                        {
                            cmd.Connection.Close();
                        }
                    }
                }
            }
            else
            {
                conn.Close();
            }
            return booResult;
        }
               
        public static int ContarUsuarios(out string pstrMensagem, out bool pbooRetorno)
        {
            int intResult = 0;
            MySqlConnection conn = ConexaoBD.CriarConexao(out pstrMensagem, out pbooRetorno);
            if (pbooRetorno)
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(CONTAR_USUARIOS, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            intResult = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: UsuariosDAL.ContarUsuarios'. \n\n{0}.", ex.Message);
                            pbooRetorno = false;
                        }
                        finally
                        {
                            cmd.Connection.Close();
                        }
                    }
                }
            }
            else
            {
                conn.Close();
            }
            return intResult;
        }

        #endregion
    }
}