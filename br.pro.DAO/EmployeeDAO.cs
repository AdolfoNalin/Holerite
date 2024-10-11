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
                string sql = @"INSERT INTO user_employee(name, user_name, password, permissions, daily, cpf, email, telephone_number, phone_number, state, city, neighborhood, 
                street, home_number, cep, emp_function, complement, fun)
                VALUES(@name, @user_name, @password, @permissions, @daily, @cpf, @email, @telephone_number, @phone_number, @state, @city, @neighborhood, 
                @street, @home_number, @cep, @emp_function, @complement, @fun)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@name", obj.Name);
                cmd.Parameters.AddWithValue("@user_name", obj.UserName);
                cmd.Parameters.AddWithValue("@password", obj.Password);
                cmd.Parameters.AddWithValue("@permissions", obj.Permissions);
                cmd.Parameters.AddWithValue("@daily", obj.Daily);
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
                cmd.Parameters.AddWithValue("@complement", obj.Complement);
                cmd.Parameters.AddWithValue("@fun", obj.Function);

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
                string sql = @"UPDATE user_employee SET 
                name=@name, user_name=@user_name, password=@password, permissions=@permissions, daily=@daily, cpf=@cpf, email=@email, telephone_number=@telephone_number, 
                phone_number=@phone_number, state=@state, city=@city, neighborhood=@neighborhood, street=@street, home_number=@home_number, cep=@cep, emp_function=@emp_function, 
                complement=@complement, fun=@fun WHERE cod=@cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@name", obj.Name);
                cmd.Parameters.AddWithValue("@user_name", obj.UserName);
                cmd.Parameters.AddWithValue("@password", obj.Password);
                cmd.Parameters.AddWithValue("@permissions", obj.Permissions);
                cmd.Parameters.AddWithValue("@daily", obj.Daily);
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
                cmd.Parameters.AddWithValue("@complement", obj.Complement);
                cmd.Parameters.AddWithValue("@fun", obj.Function);
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
                c.Fantasy_name AS 'Nome empresa',
	            e.name AS 'Nome',
                e.user_name AS 'Nome do Usuário',
                e.password AS 'Senha',
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
	            FROM user_employee AS e
                JOIN company AS c on (c.cod = e.cod_company)";

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
	            e.name AS 'Nome',
                e.user_name AS 'Nome do Usuário',
                e.password AS 'Senha',
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
	            FROM user_employee AS e WHERE e.name LIKE @name";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
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
	            e.name AS 'Nome',
                e.user_name AS 'Nome do Usuário',
                e.password AS 'Senha',
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
	            FROM user_employee AS e WHERE e.name=@name";

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
        public Employee Search(int cod)
        {
            Employee emp = new Employee();
            try
            {
                string sql = @"SELECT 
	            e.cod AS 'Código',
	            e.name AS 'Nome',
                e.user_name AS 'Nome do Usuário',
                e.password AS 'Senha',
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
	            FROM user_employee AS e WHERE e.cod=@cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod", cod);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    emp.Cod = dr.GetInt32("Código");
                    emp.Name = dr.GetString("Nome");
                    emp.CPF = dr.GetString("CPF");
                    emp.CEP = dr.GetString("CEP");
                    emp.State = dr.GetString("Estado");
                    emp.City = dr.GetString("Cidade");
                    emp.Neighborhood = dr.GetString("Bairro");
                    emp.Street = dr.GetString("Rua");
                    emp.HomeNumber = dr.GetInt32("Número da Casa");
                }
                return emp;
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
                string sql = "SELECT cod FROM user_employee WHERE cpf=@cpf AND name=@name";

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

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cpf", cpf);

                _connection.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    emp.Name = dr.GetString("name");
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

        #region GetSearch   
        public string GetSearch(int cod)
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
                    name = dr.GetString("name");
                }
                return name;
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

        #region Login
        /// <summary>
        /// Verification if username and password is true in the database
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        public Employee Login(string userName, string passWord)
        {
            Employee emp = new Employee();
            try
            {
                string sql = "SELECT * FROM user_employee WHERE user_name=@user_name AND password=@password";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@user_name", userName);
                cmd.Parameters.AddWithValue("@password", passWord);

                _connection.Open();

                MySqlDataReader da = cmd.ExecuteReader();

                if (da.Read())
                {
                    Dialog.Message($"Seja bem vindo {userName}!", "Sucesso");
                    emp.CodCompany = da.GetInt32("cod_company");
                    emp.Login = true;
                    return emp;
                }
                else
                {
                    throw new ArgumentException("Usuário ou senha incorretos", "Erro");
                }
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

        #region GetSearchEmp 
        public Employee GetSearchEmp(string name)
        {
            Employee emp = new Employee();
            try
            {
                string sql = @"SELECT * FROM user_employee WHERE name=@name OR user_name=@name";
                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@name", name);

                _connection.Open();

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    emp.Cod = dr.GetInt32("cod");
                    emp.Name = dr.GetString("name");
                    emp.Permissions = dr.GetString("permissions");
                    emp.Function = dr.GetString("emp_function");
                    emp.CEP = dr.GetString("cep");
                    emp.State = dr.GetString("state");
                    emp.City = dr.GetString("city");
                    emp.Neighborhood = dr.GetString("neighborhood");
                    emp.Street = dr.GetString("street");
                    emp.HomeNumber = dr.GetInt32("home_number");
                }
                return emp;
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
