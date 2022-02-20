using MySql.Data.MySqlClient;
using LG4.Common.Utils;
using LG4.Repository.Interface;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Reflection;

namespace LG4.Repository.MySQL {
    public static class Mapping {

        public static T ReaderToObject<T>(MySqlDataReader reader) {

            T obj = RepositoryUtils.NewInstance<T>();

            for (int i = 0; i < reader.FieldCount; i++) {
                if (!(typeof(T).GetProperty(reader.GetName(i)) == null) && !(reader.GetValue(i).GetType().FullName.Equals("System.DBNull"))) {
                    typeof(T).GetProperty(reader.GetName(i)).SetValue(obj, reader.GetValue(i));
                }
            }

            return obj;

        }

        public static List<TableColumn> DescribeTable(string tableName) {

            ICommand cmd = RepositoryResolver.NewCommand($"DESCRIBE {tableName}");

            List<TableColumn> result = cmd.ReadAll<TableColumn>();

            if (result.Count == 0)
                throw new Exception($"Tabela({tableName}) informada não existe ou não possui colunas.");

            return result;

        }

        public static ICommand CreateCommandInsert(Object obj) {
            return CreateCommandInsert(obj, obj.GetType().Name);
        }

        public static ICommand CreateCommandInsert(Object obj, String tableName) {

            List<TableColumn> Columns = DescribeTable(tableName);

            List<String> Fields = new List<String>();

            Columns.ForEach(field => {

                if (obj.GetType().GetProperty(field.Field) == null && !field.AllowNull() && !field.IsPrimaryAndAutoIncrement())
                    throw new Exception($"O campo {field.Field} da tabela {tableName} não aceita valores nulos ou possui default e não foi localiza o atributo no objeto informado ({obj.GetType().FullName}).");

                if(!field.IsPrimaryAndAutoIncrement())
                    Fields.Add(field.Field);


            });

            String commandString = $"INSERT INTO {tableName} ({String.Join(", ", Fields.ToArray())}) VALUES(@{String.Join(", @", Fields.ToArray())})";

            ICommand command = RepositoryResolver.NewCommand(commandString);

            Columns.ForEach(field => {

                if (Fields.Contains(field.Field)) {

                    PropertyInfo Column = obj.GetType().GetProperty(field.Field);

                    if (Column.GetValue(obj) == null && !field.AllowNull())
                        throw new Exception($"O campo {field.Field} da tabela {tableName} não aceita valor nulo.");

                    command.NewParameter($"@{field.Field}", Column.GetValue(obj));

                }

            });

            return command;

        }

        public static ICommand CreateCommandUpdate(Object obj, String tableName) {

            List<TableColumn> Columns = DescribeTable(tableName);

            List<String> Fields = new List<String>();

            List<String> Primary = new List<String>();

            Columns.ForEach(field => {

                if (obj.GetType().GetProperty(field.Field) == null && !field.AllowNull() && !field.IsPrimaryAndAutoIncrement())
                    throw new Exception($"O campo {field.Field} da tabela {tableName} não aceita valores nulos ou possui default e não foi localiza o atributo no objeto informado ({obj.GetType().FullName}).");

                if (!field.IsPrimaryAndAutoIncrement()) { 
                    Fields.Add(field.Field);
                } else {
                    Primary.Add(field.Field);
                }


            });

            String commandString = $"UPDATE {tableName} SET {String.Join(", ", Fields.Select(x => $"{x} = @{x}").ToArray())} WHERE {String.Join(" AND ", Primary.Select(x => $"{x} = @{x}"))}";

            ICommand command = RepositoryResolver.NewCommand(commandString);

            Columns.ForEach(field => {

                if (Fields.Contains(field.Field)) {

                    PropertyInfo Column = obj.GetType().GetProperty(field.Field);

                    if (Column.GetValue(obj) == null && !field.AllowNull())
                        throw new Exception($"O campo {field.Field} da tabela {tableName} não aceita valor nulo.");

                    command.NewParameter($"@{field.Field}", Column.GetValue(obj));

                }

            });

            Columns.ForEach(field => {

                if (Primary.Contains(field.Field)) {

                    PropertyInfo Column = obj.GetType().GetProperty(field.Field);

                    if (Column.GetValue(obj) == null && !field.AllowNull())
                        throw new Exception($"O campo {field.Field} da tabela {tableName} não aceita valor nulo.");

                    command.NewParameter($"@{field.Field}", Column.GetValue(obj));

                }

            });

            return command;

        }


    }
}
