﻿using Holerite.br.pro.Connection;
using Holerite.br.pro.MODEL;
using Holerite.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holerite.br.pro.DAO
{
    public class PointDAO
    {
        private MySqlConnection _connection;

        public PointDAO()
        {
            _connection = new ConnectionFactory().getConnection();
        }

        #region Insert
        /// <summary>
        /// Cadastra o ponto no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(Point obj)
        {
            try
            {
                string sql = "INSERT INTO point (cod_company, cod_emp, month) VALUES(@cod_company, @cod_emp, @month)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod_company", obj.CodCompany);
                cmd.Parameters.AddWithValue("@cod_emp", obj.CodEmp);
                cmd.Parameters.AddWithValue("@month", obj.Month);

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

        #region Update
        /// <summary>
        /// Atualiza os dados do ponto
        /// </summary>
        /// <param name="obj"></param>
        public void Update(Point obj)
        {
            try
            {
                string sql = "UPDATE point SET cod_company=@cod_company, cod_emp=@cod_emp  WHERE cod=@cod";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);
                cmd.Parameters.AddWithValue("@cod_company", obj.CodCompany);
                cmd.Parameters.AddWithValue("@cod_emp", obj.CodEmp);
                cmd.Parameters.AddWithValue("@cod", obj.Cod);

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

        #region Delete
        /// <summary>
        /// Delete a o ponto do banco de dados
        /// </summary>
        /// <param name="cod"></param>
        public void Delete(int cod)
        {
            try
            {
                string sql = "DELETE FROM point WHERE cod=@cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod", cod);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("Ponto foi deletado com sucesso", "sucesso");
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
        /// Consulta todos os ponto 
        /// </summary>
        /// <returns></returns>
        public DataTable Consult()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT  
                p.cod AS 'Código', 
                u.name AS 'Colaborador', 
                p.month AS 'Mês'
                FROM point AS p
                JOIN user_employee AS u on (p.cod_emp = u.cod)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
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

        #region ConsultName
        /// <summary>
        /// Consulta os pontos pelo nome do funcionário
        /// </summary>
        /// <param name="emp_name"></param>
        /// <returns></returns>
        public DataTable Consult(string emp_name)
        {
            emp_name = "%" + emp_name + "%";
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT  
                p.cod AS 'Código', 
                u.emp_name AS 'Colaborador', 
                p.date AS 'Mês'  
                FROM point AS p        
                JOIN user_employee AS u on (p.cod_emp = u.cod) WHERE u.emp_name LIKE @emp_name";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@emp_name", emp_name);
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
            {
                _connection.Close();
            }
        }
        #endregion

        #region Search
        /// <summary>
        /// Busca pointo pelo nome do funcionário
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataTable Search(string name)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT  
                p.cod AS 'Código', 
                u.emp_name AS 'Colaborador', 
                p.date AS 'Mês'  
                FROM point AS p        
                JOIN user_employee AS u on (p.cod_emp = u.cod) WHERE u.emp_name=@emp_name";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);

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
            {
                _connection.Close();
            }
        }
        #endregion

        #region SearchDate
        public DataTable Search(string startDate, string endDate)
        {
            startDate = DateTime.Parse(startDate).ToString("yyyy/MM/dd");
            endDate = DateTime.Parse(endDate).ToString("yyyy/MM/dd");

            DataTable dt = new DataTable();
            try
            {
                string sql = @"SELECT  
                p.cod AS 'Código', 
                u.name AS 'Colaborador', 
                p.month AS 'Mês'
                FROM point AS p
                JOIN user_employee AS u on (p.cod_emp = u.cod)
                WHERE p.month BETWEEN @startdate AND @enddate";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@startdate", startDate);
                cmd.Parameters.AddWithValue("@enddate", endDate);

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

        #region EndPoint
        /// <summary>
        /// Retorna o cod do ultimo ponto que foi cadastrado
        /// </summary>
        /// <returns></returns>
        public int EndPoint()
        {
            int cod = 0;
            try
            {
                string sql = "SELECT MAX(cod) AS 'Código' FROM point";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);

                _connection.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    cod = dr.GetInt32("Código");
                }

                return cod;
            }
            catch (Exception ex)
            {
                Dialog.Message($"Acoenteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
                return 0;
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion
    }
}
