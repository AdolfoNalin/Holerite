using Holerite.br.pro.Connection;
using Holerite.br.pro.MODEL;
using Holerite.br.pro.VIEW.Consult;
using Holerite.Helpers;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
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
                cmd.Parameters.AddWithValue("@wage", obj.Daily);
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
                cmd.Parameters.AddWithValue("@wage", obj.Daily);
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
                string sql = @"SELECT 
	            e.cod AS 'Código',
	            e.emp_name AS 'Nome',
                e.user_name AS 'Nome do Usuário',
                e.user_password AS 'Senha',
                e.permissions AS 'Permissoões',
                e.daily AS 'Daily',
	            e.cpf AS 'CPF',
	            e.email AS 'Email',
	            e.telephone_number AS 'Número de Telefone',
	            e.phone_number AS 'Número de Celular',
	            e.cep AS 'CEP',
	            e.state AS 'Estado',
	            e.city AS 'Cidade',
	            e.neighborhood AS 'Bairro',
	            e.street AS 'Rua',
	            e.home_number AS 'Número da casa',
	            e.complement AS 'Complemento',
                e.emp_function AS 'Funções'
	            FROM user_employee AS e";

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
            name = "%" + name + "%";
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT 
	            e.cod AS 'Código',
	            e.emp_name AS 'Nome',
                e.user_name AS 'Nome do Usuário',
                e.user_password AS 'Senha',
                e.permissions AS 'Permissoões',
                e.daily AS 'Daily',
	            e.cpf AS 'CPF',
	            e.email AS 'Email',
	            e.telephone_number AS 'Número de Telefone',
	            e.phone_number AS 'Número de Celular',
	            e.cep AS 'CEP',
	            e.state AS 'Estado',
	            e.city AS 'Cidade',
	            e.neighborhood AS 'Bairro',
	            e.street AS 'Rua',
	            e.home_number AS 'Número da casa',
	            e.complement AS 'Complemento',
                e.emp_function AS 'Funções'
	            FROM user_employee AS e WHERE e.emp_name LIKE @name";

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

        #region SearchName
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
                string sql = @"SELECT 
	            e.cod AS 'Código',
	            e.emp_name AS 'Nome',
                e.user_name AS 'Nome do Usuário',
                e.user_password AS 'Senha',
                e.permissions AS 'Permissoões',
                e.daily AS 'Daily',
	            e.cpf AS 'CPF',
	            e.email AS 'Email',
	            e.telephone_number AS 'Número de Telefone',
	            e.phone_number AS 'Número de Celular',
	            e.cep AS 'CEP',
	            e.state AS 'Estado',
	            e.city AS 'Cidade',
	            e.neighborhood AS 'Bairro',
	            e.street AS 'Rua',
	            e.home_number AS 'Número da casa',
	            e.complement AS 'Complemento',
                e.emp_function AS 'Funções'
	            FROM user_employee AS e WHERE e.emp_name=@name";

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

        #region SearchCod
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
                string sql = "SELECT name FROM user_employee WHERE cod=@cod";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);
                cmd.Parameters.AddWithValue("@cod", cod);

                _connection.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    name = dr.GetString("emp_name");
                }
                return name;
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "Atenção");
                return null;
            }
            finally
            { _connection.Close(); }
        }
        #endregion

        #region SearchCPFName
        /// <summary>
        /// Busca um Funcioário pelo cpf e pelo nome
        /// </summary>
        /// <param name="cpf"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public int Search(string cpf, string name)
        {
            int cod = 0;
            try
            {
                string sql = "SELECT cod FROM user_employee WHERE cpf=@cpf AND emp_name=@name";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cpf", cpf);
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
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
                return 0;
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region GetSearchName
        public Employee GetSearch(string cpf)
        {
            Employee emp = new Employee();  
            try
            {
                string sql = "SELECT * FROM user_employee WHERE cpf=@cpf";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);
                cmd.Parameters.AddWithValue("@cpf", cpf );

                _connection.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    emp.Name = dr.GetString("emp_name");
                    emp.Function = dr.GetString("emp_function");
                    emp.CEP = dr.GetString("cep");
                    emp.State = dr.GetString("state");
                    emp.City = dr.GetString("city");
                    emp.Neighborhood = dr.GetString("neighborhood");
                    emp.Street = dr.GetString("street");
                    emp.HomeNumber = dr.GetInt32("home_number");
                }
                else
                {
                    Dialog.Message("Funcionário não encontrado", "atenção");
                }

                return emp;
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} como o caminho para {ex.StackTrace}", "Atenção");
                return null;
            }
            finally 
            { 
                _connection.Close(); 
            }
        }
        #endregion

        #region Login
        /// <summary>
        /// Verification if username and password is true in the database
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        public bool Login(string userName, string passWord)
        {
            try
            {
                string sql = "SELECT * FROM user_employee WHERE user_name=@user_name AND user_password=@password";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@user_name", userName);
                cmd.Parameters.AddWithValue("password", passWord);

                _connection.Open();
                cmd?.ExecuteNonQuery();

                Dialog.Message($"Seja bem vindo {userName}!", "Sucesso");

                return true;
            }
            catch(Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion
    }
}
