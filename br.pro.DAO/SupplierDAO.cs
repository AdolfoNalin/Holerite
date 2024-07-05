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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Holerite.br.pro.DAO
{
    public class SupplierDAO
    {
        private MySqlConnection _connection;

        public SupplierDAO()
        {
            _connection = new ConnectionFactory().getConnection();
        }

        #region Insert
        /// <summary>
        ///  Cadastra o Fornecedor no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(Supplier obj)
        {
            try
            {
                string sql = @"INSERT INTO supplier (name, cnpj, email, telephone_number, phone_number, state, neighborhood, city, street, home_number, fantasy_name, complement, cep)
                VALUES (@name, @cnpj, @email, @telephone_number, @phone_number, @state, @neighborhood, @city, @street, @home_number, @fantasy_name, @complement, @cep)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@name", obj.Name);
                cmd.Parameters.AddWithValue("@cnpj", obj.CNPJ);
                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Parameters.AddWithValue("@telephone_number", obj.TelephoneNumber);
                cmd.Parameters.AddWithValue("@phone_number", obj.PhoneNumber);
                cmd.Parameters.AddWithValue("@state", obj.State);
                cmd.Parameters.AddWithValue("@city", obj.City);
                cmd.Parameters.AddWithValue("@neighborhood", obj.Neighborhood);
                cmd.Parameters.AddWithValue("@street", obj.Street);
                cmd.Parameters.AddWithValue("@home_number", obj.HomeNumber);
                cmd.Parameters.AddWithValue("@fantasy_name", obj.FantasyName);
                cmd.Parameters.AddWithValue("@complement", obj.Complement);
                cmd.Parameters.AddWithValue("@cep", obj.CEP);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("Fornecedor cadastrar com sucesso", "sucesso");
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um errdo do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Delete
        /// <summary>
        /// Deleta o fornecedor do banco de dados
        /// </summary>
        /// <param name="cod">código do fornecedor</param>
        public void Delete(int cod)
        {
            try
            {
                string sql = "DELETE FROM supplier WHERE cod=@cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod", cod);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("O fornecedor foi cadastrado com sucesso", "sucesso");
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um errdo do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Update
        /// <summary>
        /// Atualiza os dados do fornecedorno banco de dados
        /// </summary>
        /// <param name="obj">Objeto fornecedor</param>
        public void Upadate(Supplier obj)
        {
            try
            {
                string sql = @"UPDATE supplier SET name=@name, cnpj=@cnpj, email=@email, telephone_number=@telephone_number, phone_number=@phone_number, state=@state, neighborhood=@neighborhood, 
                city=@city, street=@street, home_number=@home_number, fantasy_name=@fantasy_name, complement=@complement, cep=@cep  
                WHERE cod=@cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@name", obj.Name);
                cmd.Parameters.AddWithValue("@cnpj", obj.CPF);
                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Parameters.AddWithValue("@telephone_number", obj.TelephoneNumber);
                cmd.Parameters.AddWithValue("@phone_number", obj.PhoneNumber);
                cmd.Parameters.AddWithValue("@state", obj.State);
                cmd.Parameters.AddWithValue("@city", obj.City);
                cmd.Parameters.AddWithValue("@neighborhood", obj.Neighborhood);
                cmd.Parameters.AddWithValue("@street", obj.Street);
                cmd.Parameters.AddWithValue("@home_number", obj.HomeNumber);
                cmd.Parameters.AddWithValue("@fantasy_name", obj.FantasyName);
                cmd.Parameters.AddWithValue("@complement", obj.Complement);
                cmd.Parameters.AddWithValue("@cep", obj.CEP);
                cmd.Parameters.AddWithValue("@cod", obj.Cod);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("Fornecedor foi Atualizado com sucesso", "sucesso");
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
                throw;
            }finally
            {
                _connection.Close(); 
            }
        }
        #endregion

        #region Consult
        /// <summary>
        /// Consulta todos os fornecedores do banco de dados
        /// </summary>
        /// <returns></returns>
        public DataTable Consult()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM supplier";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
                return null;
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region ConsultName
        /// <summary>
        /// Filtra o fornecedor pelo nome
        /// </summary>
        /// <param name="name">Nome do fornecedor</param>
        /// <returns></returns>
        public DataTable Consult(string name)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM supplier WHERE name LIKE @name";

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
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Search
        /// <summary>
        /// Busca o fornecedor pelo nome
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataTable Search(string name)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM supplier WHERE name=@name";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);
                cmd.Parameters.AddWithValue("@name", name );

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialog.Message("Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
                return null;
            }finally
            {
                _connection.Close();
            }
        }
        #endregion
    }
}
