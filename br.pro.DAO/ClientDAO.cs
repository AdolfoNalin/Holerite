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

namespace Holerite.br.pro.DAO
{
    public class ClientDAO
    {
        private static MySqlConnection _connection;

        public ClientDAO()
        {
            _connection = new ConnectionFactory().getConnection();
        }

        #region Insert
        /// <summary>
        /// Cadastra o cliente no banco de dados
        /// </summary>
        /// <param name="obj">Objeto Cliente</param>
        public static void Insert(Client obj)
        {
            try
            {
                string sql = @"INSERT INTO client(name, cpf, email, telephone_number, phone_number, state, city, neighborhood, street, home_number, cep)
                VALUE(@name, @cpf, @email, @telephone_number, @phone_number, @state, @city, @neighborhood, @street, @home_number, @cep";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@name", obj.Name);
                cmd.Parameters.AddWithValue("@cpf", obj.CPF);
                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Parameters.AddWithValue("@telephone_number", obj.TelephoneNumber);
                cmd.Parameters.AddWithValue("@phone_number", obj.PhoneNumber);
                cmd.Parameters.AddWithValue("@state", obj.State);
                cmd.Parameters.AddWithValue("@city", obj.City);
                cmd.Parameters.AddWithValue("@neighborhood", obj.Neighborhood);
                cmd.Parameters.AddWithValue("@street", obj.Street);
                cmd.Parameters.AddWithValue("@home_number", obj.HomeNumber);
                cmd.Parameters.AddWithValue("@cep", obj.CEP);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("sucesso", $"O cliente {obj.Name} foi cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Dialog.Message("atençao", $"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}"); 
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Update
        /// <summary>
        /// Atualiza os dados do Cliente no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        public static void Update(Client obj)
        {
            try
            {
                string sql = @"UPDATE client SET name=@name, cpf=@cpf, email=@email, telephone_phone=@telephone_number, phone_number=@phone_number, 
                state=@state, city=@city, neighborhood=@neighborhood, street=@street, home_number=@home_number, cep=@cep";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@name", obj.Name);
                cmd.Parameters.AddWithValue("@cpf", obj.CPF);
                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Parameters.AddWithValue("@telephone_number", obj.TelephoneNumber);
                cmd.Parameters.AddWithValue("@phone_number", obj.PhoneNumber);
                cmd.Parameters.AddWithValue("@state", obj.State);
                cmd.Parameters.AddWithValue("@city", obj.City);
                cmd.Parameters.AddWithValue("@neighborhood", obj.Neighborhood);
                cmd.Parameters.AddWithValue("@street", obj.Street);
                cmd.Parameters.AddWithValue("@home_number", obj.HomeNumber);
                cmd.Parameters.AddWithValue("@cep", obj.CEP);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("sucesso", $"O cliente {obj.Name} foi editado com sucesso!");
            }
            catch (Exception ex)
            {
                Dialog.Message("atenção", $"Aconteceu um erro do tipo {ex.Message} com caminho para {ex.StackTrace}");
            }
            finally
            {
                _connection.Close(); 
            }   
        }
        #endregion

        #region Delete
        /// <summary>
        /// Deleta o cliente do banco de dados
        /// </summary>
        /// <param name="cod"></param>
        public static void Delete(int cod)
        {
            try
            {
                string sql = "DELETE client where cod=@cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod", cod);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("sucesso", "Cliente deletado com seucesso!");
            }
            catch (Exception ex)
            {
                Dialog.Message("atenção", $"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
            }
            finally
            { _connection.Close(); }    
        }
        #endregion

        #region Consult
        /// <summary>
        /// Conulta todos os clientes que estão no banco de dados
        /// </summary>
        /// <returns></returns>
        public static DataTable Consult()
        {
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM client";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialog.Message("atenção", $"Aconteceu um erro do tipo {ex.Message} com caminho para {ex.StackTrace}");
                return null;
            }
        }
        #endregion

        #region ConsultName
        /// <summary>
        /// Consulta o cliente pelo nome
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static DataTable ConsultName(string name)
        {
            DataTable dt = new  DataTable();
            try
            {
                string sql = "SELECT * FROM client  name LIKE @name";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@name", name);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialog.Message("atenção", $"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
                return null;
            }
        }
        #endregion

        #region Search
        /// <summary>
        /// Busca o cliente pelo nome
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static DataTable Search(string name)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM client where name=@name";
                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@name", name);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialog.Message("atenção", $"Acoteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
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
