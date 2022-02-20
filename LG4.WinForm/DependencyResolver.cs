using System.IO;
using System.Windows.Forms;

using LG4.Repository;
using LG4.Common;
using LG4.Common.Model;

using MaterialSkin;

namespace LG4.WinForm {
    public static class DependencyResolver {

        public static void Resolver() {

            DatabaseResolver();

            CommonParametersResolver();

            MaterialSkinResolver();

        }

        private static void DatabaseResolver() {

            string Server = "localhost";
            string User = "root";
            string Pass = "0816";
            int Port = 3306;
            string Database = "lg4";

            ConnectionString ConnStr = new ConnectionString(Server, User, Pass, Port, Database);

            RepositoryResolver.connectionString = ConnStr;
            RepositoryResolver.connectionType = Repository.Enum.ConnectionType.MySQL;

        }

        private static void CommonParametersResolver() {

            CommonParameters.SystemDirectory = Application.StartupPath;
            CommonParameters.ErrorDirectory = Application.StartupPath + "\\Erros\\";

            if(!Directory.Exists(CommonParameters.ErrorDirectory)) 
                Directory.CreateDirectory(CommonParameters.ErrorDirectory);

        }

        private static void MaterialSkinResolver() {

            MaterialSkinManager.Instance.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan700, Accent.Cyan700, TextShade.WHITE);

        }

    }
}
