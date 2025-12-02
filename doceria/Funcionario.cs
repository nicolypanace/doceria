using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doceria
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Cargo { get; set; } // "Gestor" ou "Funcionario"
    }
}
