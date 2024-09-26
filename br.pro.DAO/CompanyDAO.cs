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
    public class CompanyDAO
    {
        private MySqlConnection _connection;

        public CompanyDAO()
        {
            _connection = new ConnectionFactory().getConnection();
        }

        #region Insert
        /// <summary>
        /// Cadastra a empresa no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(Company obj)
        {
            try
            {
                string sql = @"INSERT INTO company (name, cnpj, email, telephone_number, phone_number, state, city, neighborhood, street, home_number, cep, fantasy_name)
                 VALUES (@name, @cnpj, @email, @telephone_number, @phone_number, @state, @city, @neighborhood, @street, @home_number, @cep, @fantasy_name)";

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
                cmd.Parameters.AddWithValue("@cep", obj.CEP);
                cmd.Parameters.AddWithValue("@fantasy_name", obj.FantasyName);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("A empresa foi cadastrada com sucesso", "sucesso");

            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}", "atenção");
            }
            finally
            {
              _connection.Close();
            }
        }
        #endregion

        #region Update
        /// <summary>
        /// Atualiza os dados da empresa no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        public void Update(Company obj)
        {
            try
            {
                string sql = @"UPDATE company SET name=@name, cnpj=@cnpj, email=@email, telephone_number=@telephone_number, phone_number=@phone_number, state=@state, city=@city, 
                    neighborhood=@neighborhood, street=@street, home_number=@home_number, cep=@cep, fantasy_name=@fantasy_name WHERE cod=@cod";

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
                cmd.Parameters.AddWithValue("@cep", obj.CEP);
                cmd.Parameters.AddWithValue("@fantasy_name", obj.FantasyName);
                cmd.Parameters.AddWithValue("@cod", obj.Cod);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("A empresa foi atualizada com sucesso", "sucesso");
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}", "atenção");
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Delete
        /// <summary>
        /// Deleta a company do banco de dados
        /// </summary>
        /// <param name="cod"></param>
        public void Delete(int cod)
        {
            try
            {
                string sql = "DELETE FROM company WHERE cod=@cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod", cod);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("A empresa foi deletada com sucesso", "sucesso");
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
                throw;
            }
            finally
            {
                _connection.Close(); 
            }
        }
        #endregion

        #region Consult
        /// <summary>
        /// Consulta as empresas no banco de dados
        /// </summary>
        /// <returns></returns>
        public DataTable Consult()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"Select 
                cod as 'Código',
                name as 'Nome Proprietário',
                fantasy_name as 'Nome Fantasia',
                cpf as 'CPF',
                cnpj as 'CNPJ',
                telephone_number as 'Telefone',
                phone_number as 'Celular',
                email as 'Email',
                cep as 'CEP',
                state as 'Estado',
                city as 'Cidade',
                neighborhood as 'Bairro',
                street as 'Rua',
                home_number as 'Número',
                complement as 'Complemento'
                from company";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialog.Message("Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "sucesso");
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
        /// Consuta a empresa pelo nome fantasia 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataTable Consult(string name)
        {
            try
            {
                name = "%" + name + "%";
                string sql = @"Select 
                cod as 'Código',
                name as 'Nome Proprietário',
                fantasy_name as 'Nome Fantasia',
                cpf as 'CPF',
                cnpj as 'CNPJ',
                telephone_number as 'Telefone',
                phone_number as 'Celular',
                email as 'Email',
                cep as 'CEP',
                state as 'Estado',
                city as 'Cidade',
                neighborhood as 'Bairro',
                street as 'Rua',
                home_number as 'Número',
                complement as 'Complemento'
                from company WHERE fantasy_name LIKE @fantasy_name";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@fantasy_name", name); 

                _connection.Open();
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
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
        /// Busca a empresa no banco dedaos
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataTable Search(string name)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"Select 
                cod as 'Código',
                name as 'Nome Proprietário',
                fantasy_name as 'Nome Fantasia',
                cpf as 'CPF',
                cnpj as 'CNPJ',
                telephone_number as 'Telefone',
                phone_number as 'Celular',
                email as 'Email',
                cep as 'CEP',
                state as 'Estado',
                city as 'Cidade',
                neighborhood as 'Bairro',
                street as 'Rua',
                home_number as 'Número',
                complement as 'Complemento'
                from company WHERE fantasy_name=@fantasy_name";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@fantasy_name", name);

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
            }
            finally
            { _connection.Close(); }
        }
        #endregion

        #region SearchCNPJ
        /// <summary>
        /// Consulta a empresa pelo nome e cnpj
        /// </summary>
        /// <param name="cnpj"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public int Search(string cnpj, string name)
        {
            int cod = 0;
            try
            {
                string sql = @"Select 
                cod as 'Código',
                name as 'Nome Proprietário',
                fantasy_name as 'Nome Fantasia',
                cpf as 'CPF',
                cnpj as 'CNPJ',
                telephone_number as 'Telefone',
                phone_number as 'Celular',
                email as 'Email',
                cep as 'CEP',
                state as 'Estado',
                city as 'Cidade',
                neighborhood as 'Bairro',
                street as 'Rua',
                home_number as 'Número',
                complement as 'Complemento'
                from company WHERE cnpj=@cnpj AND name=@name";
                MySqlCommand cmd = new MySqlCommand( sql, _connection);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);
                cmd.Parameters.AddWithValue("@name", name);

                _connection.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    cod = dr.GetInt32("cod");
                }

                return cod;
            }
            catch (Exception ex)
            {
                Dialog.Message("Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
                return 0; 
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region Search
        public Company Search(int cod)
        {
            Company company = new Company();
            try
            {
                string sql = @"Select 
                cod as 'Código',
                name as 'Nome Proprietário',
                fantasy_name as 'Nome Fantasia',
                cpf as 'CPF',
                cnpj as 'CNPJ',
                telephone_number as 'Telefone',
                phone_number as 'Celular',
                email as 'Email',
                cep as 'CEP',
                state as 'Estado',
                city as 'Cidade',
                neighborhood as 'Bairro',
                street as 'Rua',
                home_number as 'Número',
                complement as 'Complemento'
                from company WHERE cod = @cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod", cod);

                _connection.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                if(dr.Read())
                {
                    Company com = new Company()
                    {
                        Cod = dr.GetInt32("Código"),
                        Name = dr.GetString("Nome Proprietário"),
                        FantasyName = dr.GetString("Nome Fantasia"),
                        CPF = dr.GetString("CPF"),
                        CNPJ = dr.GetString("CNPJ"),
                        TelephoneNumber = dr.GetString("Telefone"),
                        PhoneNumber = dr.GetString("Celular"),
                        Email = dr.GetString("Email"),
                        CEP = dr.GetString("CEP"),
                        State = dr.GetString("Estado"),
                        City = dr.GetString("Cidade"),
                        Neighborhood = dr.GetString("Bairro"),
                        Street = dr.GetString("Rua"),
                        HomeNumber = dr.GetInt32("Número"),
                        Complement = dr.GetString("Complemento")
                    };

                    company = com;
                }
                else
                {
                    Dialog.Message("Conexão não encontrada", "atenção");
                }
                return company;
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
