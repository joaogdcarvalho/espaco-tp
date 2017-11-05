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
    class AlunosDAL
    {
        #region Query

        //private const string INSERT = "uspUsuariosIncluir";
        //private const string UPDATE = "uspUsuariosAlterar";
        //private const string DELETE = "uspUsuariosExcluir";
        //private const string SELECT = "uspUsuariosSelecionar";

        private const string SELECT = "uspAlunosBuscar";
        private const string DETALHAR_ALUNO = "uspAlunosDetalhar";

        private const string INSERT = "uspAlunosIncluir";
        private const string UPDATE = "uspAlunosAlterar";

        private const string CONTAR_ALUNOS = "uspContarAlunos";

        #endregion

        #region Methods

        public static AlunosTO DetalharAluno(out string pstrMensagem, out bool pbooRetorno, int pnumIdAluno)
        {
            AlunosTO al = new AlunosTO();
            MySqlConnection conn = ConexaoBD.CriarConexao(out pstrMensagem, out pbooRetorno);
            if (pbooRetorno)
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(DETALHAR_ALUNO, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.Add(new MySqlParameter("pNumIdAluno", pnumIdAluno));

                            using (MySqlDataReader rd = cmd.ExecuteReader())
                            {
                                if (rd.HasRows)
                                {
                                    while (rd.Read())
                                    {
                                        al.Nome = rd["nome"].ToString().Trim();
                                        al.Sobrenome = rd["sobrenome"].ToString().Trim();
                                        al.Cpf = rd["cpf"].ToString().Trim();
                                        al.NumeroTelefone = rd["numero_telefone"].ToString().Trim();
                                        al.Email = rd["email"].ToString().Trim();
                                        al.DataInicioContrato = Convert.ToDateTime(rd["data_inicio_contrato"]);
                                        al.DataTerminoContrato = Convert.ToDateTime(rd["data_termino_contrato"].ToString().Trim());
                                        al.Cep = rd["cep"].ToString().Trim();
                                        al.Logradouro = rd["logradouro"].ToString().Trim();
                                        al.NumeroResidencial = rd["numero_residencial"].ToString().Trim();
                                        al.Bairro = rd["bairro"].ToString().Trim();
                                        al.Municipio = rd["municipio"].ToString().Trim();
                                    }
                                    pbooRetorno = true;
                                }
                            }
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: AlunosDAL.DetalharAluno'. \n\n{0}.", ex.Message);
                            pbooRetorno = false;
                        }
                        finally
                        {
                            cmd.Connection.Close();
                        }
                    }
                }
            }
            return al;
        }

        public static DataTable Select(out string pstrMensagem, out bool pbooRetorno, AlunosTO pAluno)
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
                            
                            cmd.Parameters.Add(new MySqlParameter("pNumIdAluno", pAluno.IdAluno.ToString()));
                            cmd.Parameters.Add(new MySqlParameter("pStrNome", pAluno.Nome));
                            cmd.Parameters.Add(new MySqlParameter("pStrSobrenome", pAluno.Sobrenome));
                            cmd.Parameters.Add(new MySqlParameter("pStrCpf", pAluno.Cpf));

                            cmd.Parameters.Add(new MySqlParameter("pDtDataInicioContrato", pAluno.DataInicioContrato));
                            cmd.Parameters.Add(new MySqlParameter("pDtDataTerminoContrato", pAluno.DataTerminoContrato));
                            MySqlDataAdapter dtAdapter = new MySqlDataAdapter(cmd);
                            dtAdapter.Fill(dtTable);
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: AlunosDAL.Select'. \n\n{0}.", ex.Message);
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

        public static Int32 Insert(out string pstrMensagem, out bool pbooRetorno, AlunosTO pAluno)
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

                            cmd.Parameters.Add(new MySqlParameter("pStrNome", pAluno.Nome));
                            cmd.Parameters.Add(new MySqlParameter("pStrSobrenome", pAluno.Sobrenome));
                            cmd.Parameters.Add(new MySqlParameter("pStrCpf", pAluno.Cpf));
                            cmd.Parameters.Add(new MySqlParameter("pNumIdTipoTelefone", pAluno.IdTipoTelefone));
                            cmd.Parameters.Add(new MySqlParameter("pStrNumeroTelefone", pAluno.NumeroTelefone));
                            cmd.Parameters.Add(new MySqlParameter("pStrEmail", pAluno.Email));
                            cmd.Parameters.Add(new MySqlParameter("pDtDataInicioContrato", pAluno.DataInicioContrato));
                            cmd.Parameters.Add(new MySqlParameter("pDtDataTerminoContrato", pAluno.DataTerminoContrato));
                            cmd.Parameters.Add(new MySqlParameter("pNumCep", pAluno.Cep));
                            cmd.Parameters.Add(new MySqlParameter("pStrLogradouro", pAluno.Logradouro));
                            cmd.Parameters.Add(new MySqlParameter("pNumNumero", pAluno.NumeroResidencial));
                            cmd.Parameters.Add(new MySqlParameter("pStrBairro", pAluno.Bairro));
                            cmd.Parameters.Add(new MySqlParameter("pStrEstado", pAluno.Estado));
                            cmd.Parameters.Add(new MySqlParameter("pStrMunicipio", pAluno.Municipio));
                            cmd.Parameters.Add(new MySqlParameter("pMoeValorAula", pAluno.ValorAula));

                            intResult = cmd.ExecuteNonQuery();
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: AlunosDAL.Insert'. \n\n{0}.", ex.Message);
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

        public static Int32 Update(out string pstrMensagem, out bool pbooRetorno, AlunosTO pAluno)
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

                            cmd.Parameters.Add(new MySqlParameter("pNumIdAluno", pAluno.IdAluno));
                            cmd.Parameters.Add(new MySqlParameter("pStrNome", pAluno.Nome));
                            cmd.Parameters.Add(new MySqlParameter("pStrSobrenome", pAluno.Sobrenome));
                            cmd.Parameters.Add(new MySqlParameter("pStrCpf", pAluno.Cpf));
                            cmd.Parameters.Add(new MySqlParameter("pNumIdTipoTelefone", pAluno.IdTipoTelefone));
                            cmd.Parameters.Add(new MySqlParameter("pStrNumeroTelefone", pAluno.NumeroTelefone));
                            cmd.Parameters.Add(new MySqlParameter("pStrEmail", pAluno.Email));
                            cmd.Parameters.Add(new MySqlParameter("pDtDataInicioContrato", pAluno.DataInicioContrato));
                            cmd.Parameters.Add(new MySqlParameter("pDtDataTerminoContrato", pAluno.DataTerminoContrato));
                            cmd.Parameters.Add(new MySqlParameter("pNumCep", pAluno.Cep));
                            cmd.Parameters.Add(new MySqlParameter("pStrLogradouro", pAluno.Logradouro));
                            cmd.Parameters.Add(new MySqlParameter("pNumNumero", pAluno.NumeroResidencial));
                            cmd.Parameters.Add(new MySqlParameter("pStrBairro", pAluno.Bairro));
                            cmd.Parameters.Add(new MySqlParameter("pStrEstado", pAluno.Estado));
                            cmd.Parameters.Add(new MySqlParameter("pStrMunicipio", pAluno.Municipio));
                            cmd.Parameters.Add(new MySqlParameter("pMoeValorAula", pAluno.ValorAula));

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

        public static int ContarAlunos(out string pstrMensagem, out bool pbooRetorno)
        {
            int intResult = 0;
            MySqlConnection conn = ConexaoBD.CriarConexao(out pstrMensagem, out pbooRetorno);
            if (pbooRetorno)
            {
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand(CONTAR_ALUNOS, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            cmd.Parameters.Clear();
                            intResult = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                        catch (MySqlException ex)
                        {
                            pstrMensagem = string.Format("Erro: 'Método: AlunosDAL.ContarAlunos'. \n\n{0}.", ex.Message);
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