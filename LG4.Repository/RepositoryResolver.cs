using LG4.Common.Model;
using LG4.Repository.Enum;
using LG4.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Repository {
    public static class RepositoryResolver {

        public static ConnectionType connectionType;
        public static ConnectionString connectionString;

        public static ICommand NewCommand(String command) {

            if(connectionType == ConnectionType.MySQL) {
                MySQL.Connection connection = new MySQL.Connection(connectionString);
                return new MySQL.Command(command, connection);
            }

            throw new Exception("Nenhum tipo de conexão foi localizado.");

        }

        public static ICommand NewCommandInsert(Object obj, String tableName) {

            if(connectionType == ConnectionType.MySQL) 
                return MySQL.Mapping.CreateCommandInsert(obj, tableName);

            throw new Exception("Nenhum tipo de conexão foi localizado.");
        }

        public static ICommand NewCommandUpdate(Object obj, String tableName) {

            if (connectionType == ConnectionType.MySQL)
                return MySQL.Mapping.CreateCommandUpdate(obj, tableName);

            throw new Exception("Nenhum tipo de conexão foi localizado.");
        }
    }
}
