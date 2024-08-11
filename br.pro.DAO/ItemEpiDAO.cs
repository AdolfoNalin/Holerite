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
    public class ItemEpiDAO
    {
        private MySqlConnection _connection;

        public ItemEpiDAO()
        {
            _connection = new ConnectionFactory().getConnection();
        }

        #region Insert
        public void Insert(ItemEpi obj)
        {
            try
            {
                string sql = @"INSERT item_epi SET (cod_epi, cod_product, price, amount, subtotal)
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

        
    }
}
