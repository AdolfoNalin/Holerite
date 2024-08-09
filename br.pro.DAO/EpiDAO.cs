using Holerite.br.pro.Connection;
using Holerite.br.pro.MODEL;
using Holerite.Helpers;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holerite.br.pro.DAO
{
    public class EpiDAO
    {
        private MySqlConnection _connection;

        public EpiDAO()
        {
            _connection = new ConnectionFactory().getConnection();
        }

        #region Insert
        /// <summary>
        /// Cadastra a EPI no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(Epi obj)
        {
            try
            {
                string sql = @"INSERT INTO epi (cod_emp, cod_prod, amount, obs)
                VALUES(@cod_emp, @cod_prod, @amunt, @obs)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod_emp", obj.CodEmp);
                cmd.Parameters.AddWithValue("@cod_prod", obj.CodProd);
                cmd.Parameters.AddWithValue("@amount", obj.Amount);
                cmd.Parameters.AddWithValue("@obs", obj.Obs);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.MessageInsert("EPI");
            }
            catch (Exception ex)
            {
                Dialog.MessageError(ex);
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region Delete
        /// <summary>
        /// Deleta o EPI do banco de dados
        /// </summary>
        /// <param name="cod"></param>
        public void Delete(int cod)
        {
            try
            {
                string sql = "DELETE FROM epi WHERE cod=@cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod", cod);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.MessageInsert("EPI");
            }
            catch (Exception ex)
            {
                Dialog.MessageError(ex);
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Consult
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable Consult()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT 
                e.cod AS 'Código',
                e.date AS 'Data',
                u.emp_name AS 'Nome do Funcionário'
                FROM epi AS e
                JOIN product AS p ON (p.cod = e.cod_prod)
                JOIN user_employee AS u ON (u.cod = e.cod_emp)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialog.MessageError(ex);
                return null;
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region ConsultName
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataTable Consult(string name)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT 
                e.cod AS 'Código',
                e.date AS 'Data',
                u.emp_name AS 'Nome do Funcionário'
                FROM epi AS e
                JOIN product AS p ON (p.cod = e.cod_prod)
                JOIN user_employee AS u ON (u.cod = e.cod_emp) WHERE u.emp_name LIKE @name";

                MySqlCommand cmd = new MySqlCommand(sql,_connection); 
                cmd.Parameters.AddWithValue("@name", name);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialog.MessageError(ex);
                return null;
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region SearchName
        public DataTable Search(string name)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT 
                e.cod AS 'Código',
                e.date AS 'Data',
                u.emp_name AS 'Nome do Funcionário'
                FROM epi AS e
                JOIN product AS p ON (p.cod = e.cod_prod)
                JOIN user_employee AS u ON (u.cod = e.cod_emp) WHERE u.name_emp=@name";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@name", name);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialog.MessageError(ex);
                return null;
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion
    }
}