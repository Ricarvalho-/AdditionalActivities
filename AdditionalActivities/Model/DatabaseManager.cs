using AdditionalActivities.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalActivities.Model
{
    class DatabaseManager
    {
        private static DatabaseManager instance;

        private static MySqlConnection connection;
        private static string connectionString = Resources.ResourceManager.GetString("databaseConnection");

        private DatabaseManager()
        {
            connection = new MySqlConnection(connectionString);
        }

        public static DatabaseManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseManager();
                }
                return instance;
            }
        }

        public MySqlConnection Connection
        {
            get
            {
                return connection;
            }
        }
    }
}
