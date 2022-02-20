using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace LG4.WinForm.Screen.Infrastructure {
    public partial class HomeScreen : MaterialForm {
        public HomeScreen() {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager.Instance.AddFormToManage(this);
        }

        private void Loading(object sender, EventArgs e) {

            LoginScreen loginScreen = new LoginScreen();

            if (loginScreen.ShowDialog() != DialogResult.OK)
                Application.Exit();

        }
    }
}
