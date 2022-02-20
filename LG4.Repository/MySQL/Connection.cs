using LG4.Common.Model;
using MySql.Data.MySqlClient;

namespace LG4.Repository.MySQL {
    public class Connection {

        public MySqlConnection connection { get; set; }

        public Connection(ConnectionString connectionString) {

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = connectionString.server;
            builder.UserID = connectionString.username;
            builder.Password = connectionString.password;
            builder.Port = (uint)connectionString.port;
            builder.Database = connectionString.database;

            connection = new MySqlConnection(builder.ConnectionString);

            connection.Open();

        }

    }
}
