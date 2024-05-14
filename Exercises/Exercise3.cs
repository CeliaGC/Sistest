using System;
using System.Collections.Generic;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistest.Exercises
{
    public class Exercise3
    {
        public void ExecuteSQL()
        {
            string connectionString = "Server=127.0.0.1;Database=spt_db;User=root;Port=3306;SslMode=none;";

            string query = @"
            SELECT distributor_id
            FROM orders
            GROUP BY distributor_id
            HAVING COUNT(DISTINCT item_ordered) = (SELECT COUNT(*) FROM items)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Distributor ID: " + reader["distributor_id"]);
                }
            }
        }
    }
}
