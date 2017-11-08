using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EspacoTP.MODEL;
using MySql.Data.MySqlClient;
using EspacoTP.UTIL;
using System.Data;
using estudio_tp.Model;

namespace EspacoTP.DAL
{
    class PeriodosDAL
    {
        #region Query

        private const string SELECT = "uspPeriodosBuscar";
        private const string INSERT = "uspPeriodosIncluir";
        private const string UPDATE = "uspPeriodosAlterar";

        private const string CONTAR_PERIODOS = "uspContarPeriodos";
        private const string VALIDAR_PERIODO_REPETIDO = "uspValidarPeriodoRepetido";
        private const string VALIDAR_DIA_REPETIDO = "uspValidarDiaRepetido";

        #endregion

        #region Methods

        public static DataTable Buscar(out string pstrMensagem, out bool pbooRetorno, int pnumIdAluno)
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
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add(new MySqlParameter("pNumIdAluno", pnumIdAluno));

                            MySqlDataAdapter dtAdapter = new MySqlDataAdapter(cmd);                            
                            dtAdapter.Fill(dtTable);
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: PeriodosDAL.Buscar'. \n\n{0}.", ex.Message);
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

        public static int Incluir(out string pstrMensagem, out bool pbooRetorno, PeriodosTO pPeriodo)
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

                            cmd.Parameters.Add(new MySqlParameter("pNumIdAluno", pPeriodo.IdAluno));
                            cmd.Parameters.Add(new MySqlParameter("pNumIdDiaAgendamento", pPeriodo.IdDiaAgendamento));
                            cmd.Parameters.Add(new MySqlParameter("pNumIdHorarioAgendamento", pPeriodo.IdHoraAgendamento));
                            cmd.Parameters.Add(new MySqlParameter("pBooAtivo", pPeriodo.Ativo));

                            intResult = cmd.ExecuteNonQuery();
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: PeriodosDAL.Incluir'. \n\n{0}.", ex.Message);
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

        public static int Alterar(out string pstrMensagem, out bool pbooRetorno, PeriodosTO pPeriodo)
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

                            cmd.Parameters.Add(new MySqlParameter("pNumIdAluno", pPeriodo.IdAluno));
                            cmd.Parameters.Add(new MySqlParameter("pNumIdDiaAgendamento", pPeriodo.IdDiaAgendamento));
                            cmd.Parameters.Add(new MySqlParameter("pNumIdHorarioAgendamento", pPeriodo.IdHoraAgendamento));
                            cmd.Parameters.Add(new MySqlParameter("pBooAtivo", pPeriodo.Ativo));
                            cmd.Parameters.Add(new MySqlParameter("pNumIdPeriodo", pPeriodo.IdPeriodo));

                            intResult = cmd.ExecuteNonQuery();
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: PeriodosDAL.Alterar'. \n\n{0}.", ex.Message);
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

        public static int ContarPeriodos(out string pstrMensagem, out bool pbooRetorno)
        {
            int intResult = 0;
            MySqlConnection conn = ConexaoBD.CriarConexao(out pstrMensagem, out pbooRetorno);
            if (pbooRetorno)
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(CONTAR_PERIODOS, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            intResult = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: PeriodosDAL.ContarPeriodos'. \n\n{0}.", ex.Message);
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

        public static bool ValidarPeriodoRepetido(out string pstrMensagem, out bool pbooRetorno, int pnumIdAluno, int pnumIdDataAgendamento, int pnumIdHorarioAgendamento)
        {
            bool booResult = false;
            MySqlConnection conn = ConexaoBD.CriarConexao(out pstrMensagem, out pbooRetorno);
            if (pbooRetorno)
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(VALIDAR_PERIODO_REPETIDO, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add(new MySqlParameter("pNumIdAluno", pnumIdAluno));
                            cmd.Parameters.Add(new MySqlParameter("pNumIdDataAgendamento", pnumIdDataAgendamento));
                            cmd.Parameters.Add(new MySqlParameter("pNumIdHorarioAgendamento", pnumIdHorarioAgendamento));

                            booResult = Convert.ToBoolean(cmd.ExecuteScalar());
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: PeriodosDAL.ValidarPeriodoRepetido'. \n\n{0}.", ex.Message);
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

        public static bool ValidarDiaRepetido(out string pstrMensagem, out bool pbooRetorno, int pnumIdAluno, int pnumIdDataAgendamento, int pnumIdHorarioAgendamento)
        {
            bool booResult = false;
            MySqlConnection conn = ConexaoBD.CriarConexao(out pstrMensagem, out pbooRetorno);
            if (pbooRetorno)
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(VALIDAR_DIA_REPETIDO, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add(new MySqlParameter("pNumIdAluno", pnumIdAluno));
                            cmd.Parameters.Add(new MySqlParameter("pNumIdDataAgendamento", pnumIdDataAgendamento));
                            cmd.Parameters.Add(new MySqlParameter("pNumIdHorarioAgendamento", pnumIdHorarioAgendamento));

                            booResult = Convert.ToBoolean(cmd.ExecuteScalar());
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: PeriodosDAL.ValidarDiaRepetido'. \n\n{0}.", ex.Message);
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

        #endregion
    }
}