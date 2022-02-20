using LG4.Repository.Interface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Repository.MySQL {
    public class Command : ICommand {

        private MySqlCommand command;

        public Command(String strCommand, Connection connection) {
            command = new MySqlCommand(strCommand, connection.connection);
        }

        public int Execute() {
            
            return command.ExecuteNonQuery();

        }

        public T Read<T>() {
            
            MySqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
                throw new Exception("Nenhum objeto localizado.");

            T result = Mapping.ReaderToObject<T>(reader);

            return result;

        }

        public List<T> ReadAll<T>() {

            MySqlDataReader reader = command.ExecuteReader();

            List<T> result = new List<T>();

            while (reader.Read()) {
                result.Add(Mapping.ReaderToObject<T>(reader));
            }

            return result;

        }

        public void NewParameter(string name, object value) {
            
            command.Parameters.AddWithValue(name, value);

        }

    }
}
