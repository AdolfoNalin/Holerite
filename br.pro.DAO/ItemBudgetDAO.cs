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
                string sql = @"INSERT INTO item_budget (budget_cod, severce_cod, amount, price, subtotal)
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

        #region Update
        public void Update(ItemBudget obj)
        {
            try
            {
                string sql = "UPDATE item_budget SET severce_cod=@cod_severce, amount=@amount, price=@price, subtotal=@subtotal WHERE budget_cod = @budget_cod";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);
                cmd.Parameters.AddWithValue("@cod_severce", obj.CodSeverce);
                cmd.Parameters.AddWithValue("@amount", obj.Amount);
                cmd.Parameters.AddWithValue("@price", obj.Price);
                cmd.Parameters.AddWithValue("@subtotal", obj.Subtotal);
                cmd.Parameters.AddWithValue("@budget_cod", obj.CodSeverce);

                _connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o camiho {ex.StackTrace}", "atenção");
            }
            finally
            {
                _connection?.Close();
            }
        }
        #endregion

        #region Delete
        public void Delete(int cod)
        {
            try
            {
                string sql = "DELETE FROM item_budget WHERE cod_budget=@cod_budget";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod_budget", cod);

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
        public DataTable Consult()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT 
                s.cod AS 'Código',
                s.short_description AS 'Descrição Resumida',
                s.spot_price AS 'Preço á Vista',
                s.term_price AS 'Preço á Prazo',
                i.amount AS 'Quantidade',
                i.subtotal AS 'Subtotal'
                FROM item_budget AS i
                JOIN servece AS s ON (s.cod = i.severce_cod)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);

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
