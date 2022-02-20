using LG4.Common.Rules;
using LG4.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Data.Rules {
    public static class UsuarioRules {

        public static Notifications ApplyInsert(Usuario u) {

            RuleTypes rules = new RuleTypes();

            rules.NullOrEmpty(u.usuario, "Nome de usuário não informado.");
            rules.LessOrEqualThan(u.usuario.Length, 5, "Nome de usuário deve ser maior que 5 letras.");

            rules.NullOrEmpty(u.nome, "Nome não informado.");

            rules.NullOrEmpty(u.senha, "Senha não informada.");
            rules.LessOrEqualThan(u.senha.Length, 5, "Senha deve ser maior que 5 caracteres.");

            return rules;

        }

    }
}
