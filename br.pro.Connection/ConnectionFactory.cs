using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holerite.br.pro.Connection
{
    public class ConnectionFactory
    {
        public MySqlConnection getConnection()
        {
            string connection = ConfigurationManager.ConnectionStrings["dbholerite"].ConnectionString;
            return new MySqlConnection(connection);
        }
    }
}
