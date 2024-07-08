﻿using Holerite.br.pro.Connection;
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
    public class BudgetDAO
    {
        private MySqlConnection _connection;

        public BudgetDAO()
        {
            _connection = new ConnectionFactory().getConnection();
        }

        #region Insert
        /// <summary>
        /// Cadastrar os dados do Orçamento no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        public void Insert(Budget obj)
        {
            try
            {
                string sql = @"INSERT INTO budget (cod_emp, cod_client, payment, subtotal, total, observation)
                VALUES(@cod_emp, @cod_client, @payment, @subtotal, @total, @observation)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod_emp", obj.CodEmp);
                cmd.Parameters.AddWithValue("@cod_client", obj.CodClient);
                cmd.Parameters.AddWithValue("@payment", obj.Payment);
                cmd.Parameters.AddWithValue("@subtotal", obj.Subtotal);
                cmd.Parameters.AddWithValue("@total", obj.Total);
                cmd.Parameters.AddWithValue("@observation", obj.Observation);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("O orçamento foi cadastrado com sucesso!", "sucesso");
            }
            catch (Exception ex)
            {
                Dialog.Message("Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Update
        /// <summary>
        /// Atualiza os dados do orçamento no banco de daodos
        /// </summary>
        /// <param name="obj"></param>
        public void Update(Budget obj)
        {
            try
            {
                string sql = "UPADTE budget SET cod_emp=@cod_emp, cod_client=@cod_client, payment=@payment, subtotal=@subtotal, total=@total, observation=@obsertvarion WHERE cod=@cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod_emp",obj.CodEmp);
                cmd.Parameters.AddWithValue("@cod_client", obj.CodClient);
                cmd.Parameters.AddWithValue("@payment",obj.Payment);
                cmd.Parameters.AddWithValue("@subtotal",obj.Subtotal);
                cmd.Parameters.AddWithValue("@total",obj.Total);
                cmd.Parameters.AddWithValue("@observation",obj.Observation);
                cmd.Parameters.AddWithValue("@cod",obj.Cod);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("O orçamento foi cadastado com sucesso!", "sucesso");
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
        /// Deleta o orçamento do banco de dados
        /// </summary>
        /// <param name="cod"></param>
        public void Delete(int cod)
        {
            try
            {
                string sql = "DELETE FROM budget WHERE cod=@cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("cod", cod);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialog.Message("O orçamento foi deletado com sucesso!", "sucesso");
            }
            catch (Exception ex)
            {
                Dialog.Message("Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atemção");
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Consult
        /// <summary>
        /// Consulta todos os dados do orçamento do banco de dados
        /// </summary>
        /// <returns></returns>
        public DataTable Consult()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM budget";

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

        #region EndBudget
        /// <summary>
        /// Retorna o ultimo orçamento do banco de dados
        /// </summary>
        /// <returns></returns>
        public int EndBudget()
        {
            int cod = 0;
            try
            {
                string sql = "SELECT MAX(cod) FROM budget";
                MySqlCommand cmd = new MySqlCommand(sql, _connection);

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
        }
        #endregion
    }
}
