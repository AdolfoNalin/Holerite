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
    public class ProductDAO
    {
        private MySqlConnection _connection;

        public ProductDAO()
        {
            _connection = new ConnectionFactory().getConnection();
        }

        #region Insert
        /// <summary>
        /// Cadastra o produto no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(Product obj) 
        {
            try
            {
                string sql = @"INSERT INTO product (cod_supplier, cod_emp, short_description, full_description, term_price, spot_price, amount, 
                ca, obs) VALUES (@cod_supplier, @cod_emp, @short_description, @full_description, @term_price, @spot_price, @amount, 
                @ca, @obs)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod_supplier", obj.CodSupplier);
                cmd.Parameters.AddWithValue("@cod_emp", obj.CodEmp);
                cmd.Parameters.AddWithValue("@short_description", obj.ShortDescription);
                cmd.Parameters.AddWithValue("@full_description", obj.FullDescription);
                cmd.Parameters.AddWithValue("@term_price", obj.TermPrice);
                cmd.Parameters.AddWithValue("@spot_price", obj.SpotPrice);
                cmd.Parameters.AddWithValue("@amount", obj.Amount);
                cmd.Parameters.AddWithValue("@ca", obj.CA);
                cmd.Parameters.AddWithValue("@obs", obj.Obs);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("O produto foi cadastrado com sucesso!", "sucesso");
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "Atenção");
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Update
        /// <summary>
        /// Atualiza os dados do produto no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        public void Update(Product obj)
        {
            try
            {
                string sql = @"UPDATE product SET cod_supplier=@cod_supplier, cod_emp=@cod_emp, short_description=@short_description, full_description=@full_description, term_price=@term_price, 
                sport_price=@spot_price, amount=@amount, ca=@ca, obs=@obs WHERE cod=@cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod_supplier", obj.CodSupplier);
                cmd.Parameters.AddWithValue("@cod_emp", obj.CodEmp);
                cmd.Parameters.AddWithValue("@short_description", obj.ShortDescription);
                cmd.Parameters.AddWithValue("@full_description", obj.FullDescription);
                cmd.Parameters.AddWithValue("@term_price", obj.TermPrice);
                cmd.Parameters.AddWithValue("@spotPrice", obj.SpotPrice);
                cmd.Parameters.AddWithValue("@amount", obj.Amount);
                cmd.Parameters.AddWithValue("@ca", obj.CA);
                cmd.Parameters.AddWithValue("@obs", obj.Obs);
                cmd.Parameters.AddWithValue("@cod", obj.Cod);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("O produto foi atualizado com sucesso!", "sucesso");
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "Atenção");
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region Delete
        /// <summary>
        /// Deleta o produto do banco de dados
        /// </summary>
        /// <param name="cod"></param>
        public void Delete(int cod)
        {
            try
            {
                string sql = "DELETE FROM  product WHERE cod=@cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod", cod);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("O produto foi deletado com sucesso", "sucesso");
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "Atenção");
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Consult
        /// <summary>
        /// Consulta todos os produtos do banco de dados
        /// </summary>
        /// <returns></returns>
        public DataTable Consult()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT 
                p.cod AS 'Código', 
                p.short_description AS 'Descrição Resumida', 
                p.full_description AS 'Descrição Completa', 
                s.fantasy_name AS 'Nome Fantasia',
                u.emp_name AS 'Funcionário',
                p.amount AS 'Quantidade',
                p.spot_price AS 'Preço á Vista',
                p.term_price AS 'Preço á Prazo',
                p.ca AS 'CA',
                p.obs AS 'Observação'
                FROM product AS p
                JOIN user_employee AS u on (p.cod_emp = u.cod)
                JOIN supplier AS s on (p.cod_supplier = s.cod)";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);

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
        /// Consulta os produtos do banco de dados e filtra pelo nome
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        public DataTable Consult(string description)
        {
            DataTable dt = new DataTable();
            description = "%" + description + "%";
            try
            {
                string sql = "SELECT * FROM product WHERE short_description LIKE @description";
                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@description", description);

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
            finally { _connection.Close(); }
        }
        #endregion

        #region Search
        /// <summary>
        /// Busca o produto pela descrição 
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        public DataTable Search(string description)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM product WHERE short_description=@description";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@description", description);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace} ", "atenção");
                return null;
            }
            finally { _connection.Close(); 
            }
        }
        #endregion
    }
}
