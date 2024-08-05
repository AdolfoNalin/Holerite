using Holerite.br.pro.Connection;
using Holerite.br.pro.MODEL;
using Holerite.Helpers;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holerite.br.pro.DAO
{
    public class SeverceDAO
    {
        private MySqlConnection _connection;

        public SeverceDAO()
        {
            _connection = new ConnectionFactory().getConnection();
        }

        #region Insert
        /// <summary>
        /// Cadastra os dados do serviço no banco de dados
        /// </summary>
        /// <param name="obj">Objeto serveço</param>
        public void Insert(Severce obj)
        {
            try
            {
                string sql = @"INSERT INTO servece (cod_employee, short_description, full_description, spot_price, term_price, obs, um)
                VALUES (@cod_emp, @short_descrition, @full_descrition, @spot_price, @term_price, @obs, um)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod_emp", obj.CodEmp);
                cmd.Parameters.AddWithValue("@short_descrition", obj.ShortDescription);
                cmd.Parameters.AddWithValue("@full_descrition", obj.FullDescription);
                cmd.Parameters.AddWithValue("@spot_price", obj.SpotPrice);
                cmd.Parameters.AddWithValue("@term_price", obj.TermPrice);
                cmd.Parameters.AddWithValue("@obs", obj.Observation);
                cmd.Parameters.AddWithValue("@um", obj.UM);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("O serviço foi cadastrado com sucesso", "Atenção");
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

        #region Upadate
        /// <summary>
        /// Atualiza os dados do serviço no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        public void Update(Severce obj)
        {
            try
            {
                string sql = @"UPDATE servece SET cod_employee=@cod_emp, short_description=@short_description, full_description=@full_description, spot_price=@spot_price, 
                term_price=@term_price, obs=@obs, um=@um WHERE cod = @cod;";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod_emp", obj.CodEmp);
                cmd.Parameters.AddWithValue("@short_description", obj.ShortDescription);
                cmd.Parameters.AddWithValue("@full_description", obj.FullDescription);
                cmd.Parameters.AddWithValue("@spot_price", obj.SpotPrice);
                cmd.Parameters.AddWithValue("@term_price", obj.TermPrice);
                cmd.Parameters.AddWithValue("@obs", obj.Observation);
                cmd.Parameters.AddWithValue("@um", obj.UM);
                cmd.Parameters.AddWithValue("@cod", obj.Cod);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("O serviço foi cadastrado com sucesso", "sucesso");
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
            }
            finally
            { _connection.Close(); }
        }
        #endregion

        #region Delete
        /// <summary>
        /// Deleta os dados do serviço do banco de dados
        /// </summary>
        /// <param name="cod"></param>
        public void Delete(int cod)
        {
            try
            {
                string sql = "DELETE FROM severce WHERE cod=@cod";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);
                cmd.Parameters.AddWithValue("#cod", cod);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("O serviço foi deletado com sucesso", "sucesso");
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region Consult
        /// <summary>
        /// Consulta todos dos serviço no banco de dados
        /// </summary>
        /// <returns></returns>
        public DataTable Consult()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT 
                s.cod AS 'Código',
                u.emp_name AS 'Nome Funcionário',
                s.short_description AS 'Descrição resumida',
                s.full_description AS 'Descrição Completa',
                s.um AS 'Unidade de Medida',
                s.spot_price AS 'Preço á vista',
                s.term_price AS 'Preço á Prazo',
                s.obs AS 'Observação'
                FROM servece AS s
                JOIN user_employee AS u ON (u.cod = s.cod_employee);";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o camiho para {ex.StackTrace}", "Atenção");
                return null;
            }
        }
        #endregion

        #region Consult ShortDescription
        /// <summary>
        /// Filtra o serviço pela descrição resumida
        /// </summary>
        /// <param name="sd"></param>
        /// <returns></returns>
        public DataTable Consult(string sd)
        {
            sd = "%" + sd + "%";
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM servece WHERE short_description LIKE @short_description";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@short_description", sd);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialog.Message($"Acontceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "Atenção");
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
        /// Busca o serviço button click
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataTable Search(string name)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM severce WHERE short_description=@short_description";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);
                cmd.Parameters.AddWithValue("short_description", name);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
                throw;
            }
            finally
            { _connection.Close(); }
        }
        #endregion

        #region Search Id
        public Severce Search(int cod)
        {
            Severce obj = new Severce();
            try
            {
                string sql = @"SELECT 
                s.cod AS 'Código',
                s.short_description AS 'Descrição resumida',
                s.um AS 'Unidade de Medida',
                s.spot_price AS 'Preço á vista',
                s.term_price AS 'Preço á Prazo'
                FROM servece AS s
                WHERE cod=@cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod", cod);

                _connection.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    obj.Cod = dr.GetInt32("Código");
                    obj.ShortDescription = dr.GetString("Descrição resumida");
                    obj.UM = dr.GetString("Unidade de Medida");
                    obj.SpotPrice = dr.GetFloat("Preço á vista");
                    obj.TermPrice = dr.GetFloat("Preço á Prazo");
                }

                return obj;
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "Atenção");
                return null;
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Search short_description
        /// <summary>
        /// Busca o serviço no banco de dados pela descrição resumida
        /// </summary>
        /// <param name="sd"></param>
        /// <returns></returns>
        public Severce GetSeverce(string sd)
        {
            Severce obj = new Severce();
            try
            {
                string sql = @"SELECT 
                s.cod AS 'Código',
                s.short_description AS 'Descrição resumida',
                s.um AS 'Unidade de Medida',
                s.spot_price AS 'Preço á vista',
                s.term_price AS 'Preço á Prazo'
                FROM servece AS s
                WHERE short_description=@sd";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@sd", sd);

                _connection.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    obj.Cod = dr.GetInt32("Código");
                    obj.ShortDescription = dr.GetString("Descrição resumida");
                    obj.UM = dr.GetString("Unidade de Medida");
                    obj.SpotPrice = dr.GetFloat("Preço á vista");
                    obj.TermPrice = dr.GetFloat("Preço á Prazo");
                }

                return obj;
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro od tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
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
