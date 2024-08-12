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

namespace Holerite.br.pro.DAO
{
    public class ItemEpiDAO
    {
        private MySqlConnection _connection;

        public ItemEpiDAO()
        {
            _connection = new ConnectionFactory().getConnection();
        }

        #region Insert
        /// <summary>
        /// Cadastra os itens da EPI no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(ItemEpi obj)
        {
            try
            {
                string sql = @"INSERT INTO item_epi (cod_epi, cod_product, price, amount, subtotal)
                VALUES(@cod_epi, @cod_product, @price, @amount, @subtotal)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod_epi", obj.CodEpi);
                cmd.Parameters.AddWithValue("@cod_product", obj.CodProd);
                cmd.Parameters.AddWithValue("@price", obj.Price);
                cmd.Parameters.AddWithValue("@amount", obj.Amount);
                cmd.Parameters.AddWithValue("@subtotal", obj.Subtotal);

                _connection.Open();
                cmd.ExecuteNonQuery();

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

        #region Delete
        /// <summary>
        /// Deleta os itens da EPI do banco de dados
        /// </summary>
        /// <param name="cod"></param>
        public void Delete(int cod)
        {
            try
            {
                string slq = "DELETE FROM item_epi WHERE cod=@cod";

                MySqlCommand cmd = new MySqlCommand(slq, _connection);
                cmd.Parameters.AddWithValue("@cod", cod);

                _connection.Open();
                cmd.ExecuteNonQuery();

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
        /// Consulta os itens EPIs do banco de dados
        /// </summary>
        /// <returns></returns>
        public DataTable Consult()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT 
                p.cod AS 'Código',
                p.short_description AS 'Descrição Resumida',
                i.price AS 'Preço',
                i.amount AS 'Quantidade',
                i.subtotal AS 'Subtotal'
                FROM item_epi AS i
                JOIN product AS p ON (p.cod = i.cod_product)";

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

        #region Search
        /// <summary>
        /// Pesquisa os itens da epi
        /// </summary>
        /// <param name="codEpi">Código da Epi</param>
        /// <returns></returns>
        public DataTable Search(int codEpi)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT 
                p.cod AS 'Código',
                p.short_description AS 'Descrição Resumida',
                i.price AS 'Preço',
                i.amount AS 'Quantidade',
                i.subtotal AS 'Subtotal'
                FROM item_epi AS i
                JOIN product AS p ON (p.cod = i.cod_product) WHERE i.cod_epi=@cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod", codEpi);

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
    }
}
