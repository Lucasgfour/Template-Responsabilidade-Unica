using LG4.Common.Utils;
using LG4.Data.Model;
using LG4.Service.Services;
using System;
using System.Windows.Forms;

namespace LG4.WinForm.Controller {
    public static class UsuarioController {

        public static Usuario Session { get; set; }

        public static bool Login(string username, string password) {

            try {

                Session = UsuarioServices.Login(username, password);

                Properties.Settings.Default.Usuario = username;
                Properties.Settings.Default.Save();

                return true;

            } catch {

                MessageBox.Show("Usuário/Senha inválido ou Bloqueado/Suspenso para login.");
                return false;

            }


        }

        public static bool Insert(Usuario usuario) {

            try {

                UsuarioServices.Insert(usuario);
                return true;

            } catch(Exception erroInsert) {

                ErrorUtils.SaveErrorMessage(erroInsert);
                MessageBox.Show(erroInsert.Message);
                return false;

            }

        }

    }
}
