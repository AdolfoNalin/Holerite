using Holerite.br.pro.Connection;
using Holerite.br.pro.MODEL;
using Holerite.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
                string sql = @"INSET INTO item_budget (cod_budget, cod_servece, amount, price, subtotal)
                VALUES(@cod_bud, @cod_severce, @amount, @price, @subtotal)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod_bud", obj.CodBudget);
                cmd.Parameters.AddWithValue("@cod_severce", obj.CodBudget);
                cmd.Parameters.AddWithValue("@cod_amount", obj.CodBudget);
                cmd.Parameters.AddWithValue("@cod_price", obj.CodBudget);
                cmd.Parameters.AddWithValue("@cod_subtotal", obj.CodBudget);

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
                string sql = "UPDATE item_budget SET cod_severce=@cod_severce, amount=@amount, price=@price, subtotal=@subtotal WHERE cod = @cod";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);
                cmd.Parameters.AddWithValue("@cod_severce", obj.CodSeverce);
                cmd.Parameters.AddWithValue("@amount", obj.Amount);
                cmd.Parameters.AddWithValue("@price", obj.Price);
                cmd.Parameters.AddWithValue("@subtotal", obj.Subtotal);

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
    }
}
