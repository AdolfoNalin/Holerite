using Holerite.br.pro.Connection;
using Holerite.br.pro.MODEL;
using Holerite.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
    }
}