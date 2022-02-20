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
using LG4.Repository;
using LG4.Repository.Interface;
using LG4.Data.Model;
using LG4.Data.Access;
using LG4.WinForm.Controller;

namespace LG4.WinForm.Screen.Infrastructure {
    public partial class LoginScreen : MaterialForm {

        public LoginScreen() {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager.Instance.AddFormToManage(this);
        }


        private void CliqueLogar(object sender, EventArgs e) {

            if(UsuarioController.Login(txt_usuario.Text, txt_senha.Text)) 
                this.DialogResult = DialogResult.OK;

        }

        private void Loading(object sender, EventArgs e) {

            if(!Properties.Settings.Default.Usuario.Equals("")) { 
                txt_usuario.Text = Properties.Settings.Default.Usuario;
                this.Show();
                this.SelectNextControl(txt_senha, true, true, true, true);
            }

        }
    }
}
