using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LG4.WinForm {
    internal static class Program {
 
        [STAThread]
        static void Main() {

            DependencyResolver.Resolver();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Screen.Infrastructure.HomeScreen());

        }
    }
}
