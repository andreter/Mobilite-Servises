using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// importar classe de conexao
using MySql.Data.MySqlClient;

namespace Mobilitec_Servises
{
    class Connection
    {
        private static string connString = "server=localhost;port=3306;database=dbmobiliteservice;uid=user_service;pwd=123456";

        private static MySqlConnection conn = null;

        public static MySqlConnection obterConexao()
        {
            conn = new MySqlConnection(connString);

            conn.Open();

            return conn;
        }
        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}
