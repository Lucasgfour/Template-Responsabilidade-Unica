using LG4.Common.Rules;
using LG4.Data.Access;
using LG4.Data.Model;
using LG4.Data.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Service.Services {
    public static class UsuarioServices {

        public static void Insert(Usuario u) {

            UsuarioDao oDao = new UsuarioDao();

            Notifications notifications = UsuarioRules.ApplyInsert(u);

            notifications.Verify();

            oDao.Insert(u);

        }

        public static Usuario Login(string username, string password) {

            UsuarioDao oDao = new UsuarioDao();

            Usuario u = oDao.Login(username, password);

            if (u.situacao != Data.Enum.UsuarioSituacao.Liberado)
                throw new Exception("Usuário bloqueado/suspenso para login");

            return u;

        }


    }
}
