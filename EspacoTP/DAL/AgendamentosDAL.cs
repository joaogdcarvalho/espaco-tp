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
    class AgendamentosDAL
    {
        #region Query

        private const string SELECT = "uspAgendamentosBuscar";
        private const string INSERT = "uspAgendamentosIncluir";
        private const string UPDATE = "uspAgendamentosAlterar";
                
        // criar uma classe 'PopComb' apenas para popular as combos de todas as janelas
        private const string POPULAR_COMBO_HORARIO = "uspPopComboHorario";
        private const string POPULAR_COMBO_INSTRUTOR = "uspPopComboInstrutor";
        private const string POPULAR_COMBO_DIA = "uspPopComboDia";
        private const string POPULAR_COMBO_TIPO_TELEFONE = "uspPopComboTipoTelefone";

        private const string CONTAR_AGENDAMENTOS = "uspContarAgendamentos";
        private const string CONTAR_ALUNOS_TURMA = "uspContarAlunosTurma";

        private const string VALIDAR_TURMA = "uspValidarTurma";
        private const string VALIDAR_CRONOGRAMA_DIA = "uspValidarCronogramaDia";

        #endregion

        #region Methods

        public static int ContarAgendamentos(out string pstrMensagem, out bool pbooRetorno)
        {
            int intResult = 0;
            MySqlConnection conn = ConexaoBD.CriarConexao(out pstrMensagem, out pbooRetorno);
            if (pbooRetorno)
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(CONTAR_AGENDAMENTOS, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            intResult = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: AgendamentosDAL.ContarAgendamentos'. \n\n{0}.", ex.Message);
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

        public static int ContarAlunosTurma(out string pstrMensagem, out bool pbooRetorno, DateTime pDtDataAGendamento, int pNumIdHorarioAgendamento)
        {
            int intResult = 0;
            MySqlConnection conn = ConexaoBD.CriarConexao(out pstrMensagem, out pbooRetorno);
            if (pbooRetorno)
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(CONTAR_ALUNOS_TURMA, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            cmd.Parameters.Clear();

                            cmd.Parameters.Add(new MySqlParameter("pDtDataAgendamento", pDtDataAGendamento));
                            cmd.Parameters.Add(new MySqlParameter("pNumIdHorarioAgendamento", pNumIdHorarioAgendamento));

                            intResult = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: AgendamentosDAL.ContarAlunosTurma'. \n\n{0}.", ex.Message);
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

        public static DataTable PopularComboHorario(out string pstrMensagem, out bool pbooRetorno)
        {
            DataTable dtTable = new DataTable();
            MySqlConnection conn = ConexaoBD.CriarConexao(out pstrMensagem, out pbooRetorno);
            if (pbooRetorno)
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(POPULAR_COMBO_HORARIO, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            MySqlDataAdapter dtAdapter = new MySqlDataAdapter(cmd);
                            dtAdapter.Fill(dtTable);
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: AgendamentosDAL.PopularComboHorario'. \n\n{0}.", ex.Message);
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

        public static DataTable PopularComboTipoTelefone(out string pstrMensagem, out bool pbooRetorno)
        {
            DataTable dtTable = new DataTable();
            MySqlConnection conn = ConexaoBD.CriarConexao(out pstrMensagem, out pbooRetorno);
            if (pbooRetorno)
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(POPULAR_COMBO_TIPO_TELEFONE, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            MySqlDataAdapter dtAdapter = new MySqlDataAdapter(cmd);
                            dtAdapter.Fill(dtTable);
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: AgendamentosDAL.PopularComboTipoTelefone'. \n\n{0}.", ex.Message);
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

        public static DataTable PopularComboInstrutor(out string pstrMensagem, out bool pbooRetorno)
        {
            DataTable dtTable = new DataTable();
            MySqlConnection conn = ConexaoBD.CriarConexao(out pstrMensagem, out pbooRetorno);
            if (pbooRetorno)
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(POPULAR_COMBO_INSTRUTOR, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            MySqlDataAdapter dtAdapter = new MySqlDataAdapter(cmd);
                            dtAdapter.Fill(dtTable);
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: AgendamentosDAL.PopularComboInstrutor'. \n\n{0}.", ex.Message);
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

        public static DataTable PopularComboDia(out string pstrMensagem, out bool pbooRetorno)
        {
            DataTable dtTable = new DataTable();
            MySqlConnection conn = ConexaoBD.CriarConexao(out pstrMensagem, out pbooRetorno);
            if (pbooRetorno)
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(POPULAR_COMBO_DIA, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            MySqlDataAdapter dtAdapter = new MySqlDataAdapter(cmd);
                            dtAdapter.Fill(dtTable);
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: AgendamentosDAL.PopularComboDia'. \n\n{0}.", ex.Message);
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

        public static DataTable Select(out string pstrMensagem, out bool pbooRetorno, string pDataAgendamento, int pNumIdHorarioAgendamento)
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
                            
                            cmd.Parameters.Add(new MySqlParameter("pDtDataAgendamento", pDataAgendamento));
                            cmd.Parameters.Add(new MySqlParameter("pNumIdHorarioAgendamento", pNumIdHorarioAgendamento));

                            MySqlDataAdapter dtAdapter = new MySqlDataAdapter(cmd);                            
                            dtAdapter.Fill(dtTable);
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: AgendamentosDAL.Select'. \n\n{0}.", ex.Message);
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

        public static Int32 Insert(out string pstrMensagem, out bool pbooRetorno, AgendamentosTO pAgendamento)
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

                            cmd.Parameters.Add(new MySqlParameter("pNumIdInstrutor", pAgendamento.IdInstrutor));
                            cmd.Parameters.Add(new MySqlParameter("pNumIdAluno", pAgendamento.IdAluno));
                            cmd.Parameters.Add(new MySqlParameter("pNumDataAgendamento", pAgendamento.DataAgendamento));
                            cmd.Parameters.Add(new MySqlParameter("pNumIdHorarioAgendamento", pAgendamento.IdHorarioAgendamento));
                            cmd.Parameters.Add(new MySqlParameter("pBooAtivo", pAgendamento.Ativo));
                            
                            intResult = cmd.ExecuteNonQuery();
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: AgendamentosDAL.Insert'. \n\n{0}.", ex.Message);
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

        public static Int32 Update(out string pstrMensagem, out bool pbooRetorno, AgendamentosTO pAgendamento)
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

                            cmd.Parameters.Add(new MySqlParameter("pNumIdAgendamento", pAgendamento.IdAgendamento));
                            cmd.Parameters.Add(new MySqlParameter("pNumIdInstrutor", pAgendamento.IdInstrutor));
                            cmd.Parameters.Add(new MySqlParameter("pNumIdAluno", pAgendamento.IdAluno));
                            cmd.Parameters.Add(new MySqlParameter("pNumDataAgendamento", pAgendamento.DataAgendamento));
                            cmd.Parameters.Add(new MySqlParameter("pNumIdHorarioAgendamento", pAgendamento.IdHorarioAgendamento));
                            cmd.Parameters.Add(new MySqlParameter("pBooAtivo", pAgendamento.Ativo));

                            intResult = cmd.ExecuteNonQuery();
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: AlunosDAL.Update'. \n\n{0}.", ex.Message);
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

        public static bool ValidarTurma(out string pstrMensagem, out bool pbooRetorno, int pnumIdAluno, DateTime pdtDataAgendamento, int pnumIdHorarioAgendamento)
        {
            bool booResult = false;
            MySqlConnection conn = ConexaoBD.CriarConexao(out pstrMensagem, out pbooRetorno);
            if (pbooRetorno)
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(VALIDAR_TURMA, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add(new MySqlParameter("pNumIdAluno", pnumIdAluno));
                            cmd.Parameters.Add(new MySqlParameter("pNumDataAgendamento", pdtDataAgendamento));
                            cmd.Parameters.Add(new MySqlParameter("pNumIdHorarioAgendamento", pnumIdHorarioAgendamento));

                            booResult = Convert.ToBoolean(cmd.ExecuteScalar());
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: AgendamentosDAL.ValidarTurma'. \n\n{0}.", ex.Message);
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

        public static bool ValidarAlunoInclusoCronogramaDia(out string pstrMensagem, out bool pbooRetorno, int pnumIdAluno, DateTime pdtDataAgendamento, int pnumIdHorarioAgendamento)
        {
            bool booResult = false;
            MySqlConnection conn = ConexaoBD.CriarConexao(out pstrMensagem, out pbooRetorno);
            if (pbooRetorno)
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(VALIDAR_CRONOGRAMA_DIA, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add(new MySqlParameter("pNumIdAluno", pnumIdAluno));
                            cmd.Parameters.Add(new MySqlParameter("pNumDataAgendamento", pdtDataAgendamento));
                            cmd.Parameters.Add(new MySqlParameter("pNumIdHorarioAgendamento", pnumIdHorarioAgendamento));

                            booResult = Convert.ToBoolean(cmd.ExecuteScalar());
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: AgendamentosDAL.ValidarAlunoInclusoCronogramaDia'. \n\n{0}.", ex.Message);
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