using LG4.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LG4.Data.Model {
    public class Usuario {

        public int codigo { get; set; }
        public string nome { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public UsuarioSituacao situacao { get; set; }

        public Usuario() { }


    }
}
