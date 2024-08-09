using Holerite.br.pro.Connection;
using Holerite.br.pro.MODEL;
using Holerite.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace Holerite.br.pro.DAO
{
    public class ItemBudgetDAO
    {
        private MySqlConnection _connection;

        public ItemBudgetDAO()
        {
            _connection = new ConnectionFactory().getConnection();
        }

        #region Insert
        /// <summary>
        /// Cadastrar os itens do orçamento no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(ItemBudget obj)
        {
            try
            {
                string sql = @"INSERT INTO item_budget (budget_cod,severce_cod, amount, price, subtotal)
                VALUES(@cod_bud, @cod_severce, @amount, @price, @subtotal)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod_bud", obj.CodBudget);
                cmd.Parameters.AddWithValue("@cod_severce", obj.CodSeverce);
                cmd.Parameters.AddWithValue("@amount", obj.Amount);
                cmd.Parameters.AddWithValue("@price", obj.Price);
                cmd.Parameters.AddWithValue("@subtotal", obj.Subtotal);

                _connection.Open();
                cmd.ExecuteNonQuery();
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

        #region Delete
        /// <summary>
        /// Deleta os item do orçamento pai
        /// </summary>
        /// <param name="cod"></param>
        public void Delete(int cod)
        {
            try
            {
                string sql = "DELETE FROM item_budget WHERE budget_cod=@budget_cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@budget_cod", cod);

                _connection?.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
            }
            finally { _connection?.Close(); };
        }
        #endregion

        #region Consult
        /// <summary>
        /// Consulta 
        /// </summary>
        /// <param name="cod"></param>
        /// <returns></returns>
        public DataTable Consult(int cod)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT 
                s.cod AS 'Código',
                s.short_description AS 'Descrição Resumida',
                i.price AS 'Preço',
                i.amount AS 'Quantidade',
                i.subtotal AS 'Subtotal'
                FROM item_budget AS i
                JOIN servece AS s ON (s.cod = i.severce_cod) WHERE i.budget_cod = @cod";

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
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
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