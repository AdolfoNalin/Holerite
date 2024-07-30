using Holerite.br.pro.Connection;
using Holerite.br.pro.MODEL;
using Holerite.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace Holerite.br.pro.DAO
{
    public class FunctionDAO
    {
        private MySqlConnection _connection;

        public FunctionDAO()
        {
            _connection = new ConnectionFactory().getConnection();
        }

        #region Insert
        /// <summary>
        /// Insert the function_emp
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(Function obj)
        {
            try
            {
                string sql = "INSERT INTO fun(function_emp) VALUE (@fun)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@fun", obj.Fun);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message($"Criação do cargo {obj.Fun} foi realizada com sucesso", "sucesso");
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "Atenção");
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Consult
        /// <summary>
        /// Consult the functions
        /// </summary>
        /// <returns></returns>
        public DataTable Consult()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM fun";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);

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

        #region Consult
        /// <summary>
        /// Consult the function for name
        /// </summary>
        /// <param name="fun"></param>
        /// <returns></returns>
        public DataTable Consult(string fun)
        {
            fun = "%" + fun + "%";
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM fun WHERE function_emp LIKE @fun";
                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@fun", fun);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caimho para {ex.StackTrace}", "Atenção");
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
