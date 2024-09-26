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
    public class ItemPointDAO
    {
        private MySqlConnection _connection;

        public ItemPointDAO()
        {
            _connection = new ConnectionFactory().getConnection();
        }

        #region Insert
        /// <summary>
        /// Cadastras os itens do ponto no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(ItemPoint obj)
        {
            try
            {
                string sql = @"INSERT INTO item_point (date, entry_time, lunch_departure, lunch_entrance, exit_time, extra_output, extra_entry, cod_point)
                VALUES (@date, @entry_time, @lunch_departure, @lunch_entrance, @exit_time, @extra_output, @extra_entry, @cod_point)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@date", obj.Date);
                cmd.Parameters.AddWithValue("@entry_time", obj.EntryTime);
                cmd.Parameters.AddWithValue("@lunch_departure", obj.LunchDeparture);
                cmd.Parameters.AddWithValue("@lunch_entrance", obj.LunchEntrance);
                cmd.Parameters.AddWithValue("@exit_time", obj.ExitTime);
                cmd.Parameters.AddWithValue("@extra_output", obj.ExtraOutput);
                cmd.Parameters.AddWithValue("@extra_entry", obj.ExtraEntry);
                cmd.Parameters.AddWithValue("@cod_point", obj.CodPoint);

                _connection.Open();
                cmd.ExecuteNonQuery();
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

        #region Update
        /// <summary>
        /// Atualiza os itens do ponto no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        public void Update(ItemPoint obj)
        {
            try
            {
                string sql = @"UPDATE item_point SET date_point=@date_point, entry_time=@entry_time, lunch_departure=@lunch_departure, lunch_entrance=@lunch_entrance, exit_time=@exit_time, 
                extra_output=@extra_output, extra_entry=@extra_entry WHERE cod_point=@cod_point";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@date_point", obj.Date);
                cmd.Parameters.AddWithValue("@entry_time", obj.EntryTime);
                cmd.Parameters.AddWithValue("@lunch_departure", obj.LunchDeparture);
                cmd.Parameters.AddWithValue("@lunch_entrance", obj.LunchEntrance);
                cmd.Parameters.AddWithValue("@exit_time", obj.ExitTime);
                cmd.Parameters.AddWithValue("@extra_output", obj.ExtraOutput);
                cmd.Parameters.AddWithValue("@extra_entry", obj.ExtraEntry);
                cmd.Parameters.AddWithValue("@cod_point", obj.CodPoint);
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
        public void Delete(int cod)
        {
            try
            {
                string sql = "DELETE FROM item_point WHERE cod_point=@cod_point";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);
                cmd.Parameters.AddWithValue("@cod_point", cod);

                _connection.Close();
                cmd.ExecuteNonQuery(); 
            }
            catch (Exception ex) 
            {
                Dialog.Message("Aconteceu um erro do tipo {ex.Messa} com o caminho para {ex.StackTrace}", "atenção");
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion
    }
}
