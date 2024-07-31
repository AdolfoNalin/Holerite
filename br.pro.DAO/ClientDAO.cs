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
        private MySqlConnection _connection;

        public ClientDAO()
        {
            _connection = new ConnectionFactory().getConnection();
        }

        #region Insert
        /// <summary>
        /// Cadastra o cliente no banco de dados
        /// </summary>
        /// <param name="obj">Objeto Cliente</param>
        public void Insert(Client obj)
        {
            try
            {
                string sql = @"INSERT INTO dbholerite.client(name, cpf, email, telephone_number, phone_number, state, city, neighborhood, street, home_number, cep)
                VALUES(@name, @cpf, @email, @telephone_number, @phone_number, @state, @city, @neighborhood, @street, @home_number, @cep)";

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

                Dialog.Message("O cliente foi cadastrado com sucesso!", "sucesso");
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
        /// Atualiza os dados do Cliente no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        public void Update(Client obj)
        {
            try
            {
                string sql = @"UPDATE client SET name=@name, cpf=@cpf, email=@email, telephone_number=@telephone_number, phone_number=@phone_number, 
                state=@state, city=@city, neighborhood=@neighborhood, street=@street, home_number=@home_number, cep=@cep WHERE cod=@cod";

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
                cmd.Parameters.AddWithValue("@cod", obj.Cod);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("Cliente foi atualizado com sucesso", "Sucesso");
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com caminho para {ex.StackTrace}", "atenção");
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
        public void Delete(int cod)
        {
            try
            {
                string sql = "DELETE FROM client where cod=@cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod", cod);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("Cliente deletado com seucesso!", "sucesso");
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
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
        public DataTable Consult()
        {
            DataTable dt = new DataTable();

            try
            {
                string sql = @"SELECT 
                c.cod AS 'Código',
                c.name AS 'Nome',
                c.cpf AS 'CPF',
                c.email AS 'Email',
                c.telephone_number AS 'Número de Telefone',
                c.phone_number AS 'Número de Celular',
                c.cep AS 'CEP',
                c.state AS 'Estado',
                c.city AS 'Cidade',
                c.neighborhood AS 'Bairro',
                c.street AS 'Rua',
                c.home_number AS 'Número da casa',
                c.complement AS 'Complemento'
                FROM client AS c";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com caminho para {ex.StackTrace}", "atenção");
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
        public DataTable ConsultName(string name)
        {
            DataTable dt = new  DataTable();
            try
            {
                name = "%" + name + "%";    
                string sql = @"SELECT 
                c.cod AS 'Código',
                c.name AS 'Nome',
                c.cpf AS 'CPF',
                c.email AS 'Email',
                c.telephone_number AS 'Número de Telefone',
                c.phone_number AS 'Número de Celular',
                c.cep AS 'CEP',
                c.state AS 'Estado',
                c.city AS 'Cidade',
                c.neighborhood AS 'Bairro',
                c.street AS 'Rua',
                c.home_number AS 'Número da casa',
                c.complement AS 'Complemento'
                FROM client AS c where name LIKE @name";

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
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
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
        public DataTable Search(string name)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT 
                c.cod AS 'Código',
                c.name AS 'Nome',
                c.cpf AS 'CPF',
                c.email AS 'Email',
                c.telephone_number AS 'Número de Telefone',
                c.phone_number AS 'Número de Celular',
                c.cep AS 'CEP',
                c.state AS 'Estado',
                c.city AS 'Cidade',
                c.neighborhood AS 'Bairro',
                c.street AS 'Rua',
                c.home_number AS 'Número da casa',
                c.complement AS 'Complemento'
                FROM client AS c where name=@name";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@name", name);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialog.Message($"Acoteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
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
