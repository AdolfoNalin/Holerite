using Holerite.br.pro.Connection;
using Holerite.br.pro.MODEL;
using Holerite.br.pro.VIEW.Consult;
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
    public class EmployeeDAO
    {
        private MySqlConnection _connection;

        public EmployeeDAO()
        {
            _connection = new ConnectionFactory().getConnection();
        }

        #region Insert
        /// <summary>
        /// Cadastra o Funcionário no banco de dados
        /// </summary>
        /// <param name="obj">Funcionário</param>
        public void Insert(Employee obj)
        {
            try
            {
                string sql = @"INSERT INTO user_employee(emp_name, user_name, user_password, permissions, wage, cpf, email, telephone_number, phone_number, state, city, neighborhood, 
                street, home_number, cep, emp_function)
                VALUES(@emp_name, @user_name, @user_password, @permissions, @wage, @cpf, @email, @telephone_number, @phone_number, @state, @city, @neighborhood, 
                @street, @home_number, @cep, @emp_function)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@emp_name", obj.Name);
                cmd.Parameters.AddWithValue("@user_name", obj.UserName);
                cmd.Parameters.AddWithValue("@user_password", obj.Password);
                cmd.Parameters.AddWithValue("@permissions", obj.Permissions);
                cmd.Parameters.AddWithValue("@wage", obj.Wage);
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
                cmd.Parameters.AddWithValue("@emp_function", obj.Function);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("Funcionário foi cadastrado com sucesso", "sucesso");
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
        /// Atualiza os dados do employee
        /// </summary>
        /// <param name="obj"></param>
        public void Update(Employee obj)
        {
            try
            {
                string sql = @"UPDATE user_employee SET emp_name=@emp_name, user_name=@user_name, user_password=@user_password, permissions=@permissions, wage=@wage, cpf=@cpf, email=@email, 
                telephone_number=@telephone_number, phone_number=@phone_number, state=@state, city=@city, neighborhood=@neighborhood, street=@street, home_number=@home_number, cep=@cep, 
                emp_function=@emp_function WHERE cod=@cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@emp_name", obj.Name);
                cmd.Parameters.AddWithValue("@user_name", obj.UserName);
                cmd.Parameters.AddWithValue("@user_password", obj.Password);
                cmd.Parameters.AddWithValue("@permissions", obj.Permissions);
                cmd.Parameters.AddWithValue("@wage", obj.Wage);
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
                cmd.Parameters.AddWithValue("@emp_function", obj.Function);
                cmd.Parameters.AddWithValue("@cod", obj.Cod);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("Funcionário Atualizado com sucesso!", "sucesso");
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Delete
        /// <summary>
        /// Deleta o funcionário do banco de dados
        /// </summary>
        /// <param name="cod">Código do funcionário</param>
        public void Delete(int cod)
        {
            try
            {
                string sql = "DELETE FROM user_employee where cod=@cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("cod", cod);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("O funcionário foi deeltado com sucesso", "sucesso");
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

        #region Consult
        /// <summary>
        /// Consulta todos os funcionário cadastrados no banco de dados
        /// </summary>
        /// <returns>Todos os funcionários cadastrados</returns>
        public DataTable Consult()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM user_employee";

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

        #region ConsultName
        /// <summary>
        /// Consulta os funcionários filtrando pelo nome
        /// </summary>
        /// <param name="name">Nome funcionário</param>
        /// <returns></returns>
        public DataTable Consult(string name)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM user_employee name LIKE @name";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);
                cmd.Parameters.AddWithValue("@name", name);

                _connection.Open();
                cmd.ExecuteNonQuery(); 

                MySqlDataAdapter d = new MySqlDataAdapter(cmd);
                d.Fill(dt);

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
        /// Buscar o funcionário pelo nome
        /// </summary>
        /// <param name="name">Nome do funcionário</param>
        /// <returns></returns>
        public DataTable Search(string name)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM employee WHERE name=@name";

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
        /// Busca o Funcionário no banco de dados
        /// </summary>
        /// <param name="cod">Codigo do funcionário</param>
        /// <returns></returns>
        public string Search(int cod)
        {
            string name = "";
            try
            {
                string sql = "SELECT name FROM severce WHERE cod=@cod";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);
                cmd.Parameters.AddWithValue("@cod", cod);

                _connection.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    name = dr.GetString("name");
                }
                return name;
            }
            catch (Exception ex)
            {
                Dialog.Message("Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "Atenção");
                return null;
            }
            finally
            { _connection.Close(); }
        }
        #endregion
    }
}
