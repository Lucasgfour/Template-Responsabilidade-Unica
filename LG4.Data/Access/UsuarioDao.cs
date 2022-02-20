using LG4.Data.Interface;
using LG4.Data.Model;
using LG4.Repository;
using LG4.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Data.Access {
    public class UsuarioDao : IDataAccess<Usuario> {

        public Usuario Consult(int cod) {

            ICommand command = RepositoryResolver.NewCommand("SELECT codigo, nome, usuario, situacao FROM usuario WHERE codigo = @codigo");
            command.NewParameter("@codigo", cod);

            return command.Read<Usuario>();

        }

        public Usuario List(string search) {

            throw new Exception("Não é permitido listar os usuários !");

        }

        public void Insert(Usuario obj) {

            ICommand command = RepositoryResolver.NewCommand("INSERT INTO usuario(nome, usuario, senha, situacao) VALUES(@nome, @usuario, MD5(@senha), @situacao)");

            command.NewParameter("@nome", obj.nome);
            command.NewParameter("@usuario", obj.usuario);
            command.NewParameter("@senha", obj.senha);
            command.NewParameter("@situacao", obj.situacao);

            command.Execute();

        }

        public void Update(Usuario obj) {

            throw new Exception("Função bloqueada para o objeto Usuario !");

        }

        public Usuario Login(String username, String password) {

            ICommand command = RepositoryResolver.NewCommand("SELECT codigo, nome, usuario, situacao FROM usuario WHERE usuario = @usuario AND senha = MD5(@senha)");

            command.NewParameter("@usuario", username);
            command.NewParameter("@senha", password);

            return command.Read<Usuario>();

        }

        public bool ChangePassword(Usuario obj, String oldPassword, String newPassword) {

            ICommand command = RepositoryResolver.NewCommand("UPDATE usuario SET senha = MD5(@newPassword) WHERE codigo = @codigo AND senha = MD5(@oldPassword)");

            command.NewParameter("@newPassword", newPassword);
            command.NewParameter("@codigo", obj.codigo);
            command.NewParameter("@oldPassword", oldPassword);

            return (command.Execute() > 0);

        }

        public bool ChangeNome(Usuario obj) {

            ICommand command = RepositoryResolver.NewCommand("UPDATE usuario SET nome = @nome WHERE codigo = @codigo");

            command.NewParameter("@nome", obj.nome);
            command.NewParameter("@codigo", obj.codigo);

            return (command.Execute() > 0);

        }

        public bool ChangeSituacao(Usuario obj) {

            ICommand command = RepositoryResolver.NewCommand("UPDATE usuario SET situacao = @situacao WHERE codigo = @codigo");

            command.NewParameter("@situacao", obj.situacao);
            command.NewParameter("@codigo", obj.codigo);

            return (command.Execute() > 0);

        }


    }
}
