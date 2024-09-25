using Holerite.br.pro.Connection;
using Holerite.br.pro.MODEL;
using Holerite.Helpers;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Engines;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holerite.br.pro.DAO
{
    public class BudgetDAO
    {
        private MySqlConnection _connection;

        public BudgetDAO()
        {
            _connection = new ConnectionFactory().getConnection();
        }

        #region Insert
        /// <summary>
        /// Cadastrar os dados do Orçamento no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(Budget obj)
        {
            try
            {
                string sql = @"INSERT INTO budget (emp_cod, client_cod, payment, subtotal, total, obs, date)
                VALUES(@cod_emp, @cod_client, @payment, @subtotal, @total, @obs, @date)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod_emp", obj.CodEmp);
                cmd.Parameters.AddWithValue("@cod_client", obj.CodClient);
                cmd.Parameters.AddWithValue("@payment", obj.Payment);
                cmd.Parameters.AddWithValue("@subtotal", obj.Subtotal);
                cmd.Parameters.AddWithValue("@total", obj.Total);
                cmd.Parameters.AddWithValue("@obs", obj.Observation);
                cmd.Parameters.AddWithValue("@date", obj.Date);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("O orçamento foi cadastrado com sucesso!", "sucesso");
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Delete
        /// <summary>
        /// Deleta o orçamento do banco de dados
        /// </summary>
        /// <param name="cod"></param>
        public void Delete(int cod)
        {
            try
            {
                string sql = "DELETE FROM budget WHERE cod=@cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("cod", cod);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("O orçamento foi deletado com sucesso!", "sucesso");
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atemção");
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Consult
        /// <summary>
        /// Consulta todos os dados do orçamento do banco de dados
        /// </summary>
        /// <returns></returns>
        public DataTable Consult()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT 
                b.cod AS 'Código',
                b.date AS 'Data',
                b.payment AS 'Forma de pagamento',
                u.name AS 'Nome Funcionário',
                c.name AS 'Nome Cliente',
                b.subtotal AS 'Subtotal',
                b.obs AS 'Observação'
                FROM budget AS b
                JOIN user_employee AS u ON (u.cod = b.cod_emp)
                JOIN client AS c ON (c.cod = b.cod_client)";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
                return null;
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region ConsultId
        /// <summary>
        /// Consulta o orçamento pelo cod
        /// </summary>
        /// <param name="cod">Cod do orçamento</param>
        /// <returns></returns>
        public DataTable Consult(int cod)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT 
                b.cod AS 'Código',
                b.date AS 'Data',
                b.payment AS 'Forma de pagamento',
                u.emp_name AS 'Nome Funcionário',
                c.name AS 'Nome Cliente',
                b.subtotal AS 'Subtotal',
                b.obs AS 'Observação'
                FROM budget AS b
                JOIN user_employee AS u ON (u.cod = b.emp_cod)
                JOIN client AS c ON (c.cod = b.client_cod) WHERE b.cod=@cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod", cod);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}", "atenção");
                return null;
            }
            finally
            { 
                _connection.Close(); 
            }
        }
        #endregion

        #region ConsultStartDateAndEndData
        /// <summary>
        /// Consulta os orçamentos pelo intervado de datas
        /// </summary>
        /// <param name="startDate">Data inicio</param>
        /// <param name="endDate">Data Fim</param>
        /// <returns></returns>
        public DataTable Consult(DateTime startDate, DateTime endDate)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT 
                b.cod AS 'Código',
                b.date AS 'Data',
                b.payment AS 'Forma de pagamento',
                u.emp_name AS 'Nome Funcionário',
                c.name AS 'Nome Cliente',
                b.subtotal AS 'Subtotal',
                b.obs AS 'Observação'
                FROM budget AS b
                JOIN user_employee AS u ON (u.cod = b.emp_cod)
                JOIN client AS c ON (c.cod = b.client_cod)) WHERE b.date between @startdate AND @enddate";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@startdate", startDate);
                cmd.Parameters.AddWithValue("@enddate", endDate);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter dr = new MySqlDataAdapter(cmd);
                dr.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
                return null;
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region ConsultNameClient
        /// <summary>
        /// Consulta todos os dados do orçamento do banco de dados
        /// </summary>
        /// <returns></returns>
        public DataTable Consult(string name)
        {
            name = "%" + name + "%";
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT 
                b.cod AS 'Código',
                b.date AS 'Data',
                b.payment AS 'Forma de pagamento',
                u.emp_name AS 'Nome Funcionário',
                c.name AS 'Nome Cliente',
                b.subtotal AS 'Subtotal',
                b.obs AS 'Observação'
                FROM budget AS b
                JOIN user_employee AS u ON (u.cod = b.emp_cod)
                JOIN client AS c ON (c.cod = b.client_cod) WHERE c.name LIKE @name";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@name", name);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
                return null;
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Search
        public DataTable Search(string name)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT 
                b.cod AS 'Código',
                b.date AS 'Data',
                b.payment AS 'Forma de pagamento',
                u.emp_name AS 'Nome Funcionário',
                c.name AS 'Nome Cliente',
                b.subtotal AS 'Subtotal',
                b.obs AS 'Observação'
                FROM budget AS b
                JOIN user_employee AS u ON (u.cod = b.emp_cod)
                JOIN client AS c ON (c.cod = b.client_cod) WHERE c.name=@name";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@nome", name);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
                return null ;
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region EndBudget
        /// <summary>
        /// Retorna o ultimo orçamento do banco de dados
        /// </summary>
        /// <returns></returns>
        public int EndBudget()
        {
            int cod = 0;
            try
            {
                string sql = "SELECT MAX(cod) cod FROM budget";
                MySqlCommand cmd = new MySqlCommand(sql, _connection);

                _connection.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    cod = dr.GetInt32("cod");
                }
                else
                {
                    Dialog.Message("Elemento não encontrado!", "atenção");
                }
                return cod;
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
                return 0;
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion
    }
}
