using Holerite.br.pro.Connection;
using Holerite.br.pro.MODEL;
using Holerite.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
            _connection = new ConnectionFactory().getConnection() ?? throw new Exception("Bando de dados não encontrado");
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

        #region Search
        public DataTable Search(int codPoint)
        {
            DataTable dt = new DataTable();
            try
            {
                string slq = @"SELECT 
                date as 'Data',
                entry_time as 'Hora entrada',
                lunch_departure as 'Saida Almoço',
                lunch_entrance as 'Entrada Almoço',
                exit_time as 'Hora Saida',
                extra_entry as 'Entrada Extra',
                extra_output as 'Saida Extra'  
                FROM item_point WHERE cod_point = @cod_point";

                MySqlCommand cmd = new MySqlCommand(slq, _connection);
                cmd.Parameters.AddWithValue("@cod_point", codPoint);

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
