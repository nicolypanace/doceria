using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doceria
{
    public static class Repositorio
    {
        public static List<Funcionario> Funcionarios = new List<Funcionario>();

        public static void AdicionarFuncionario(Funcionario f)
        {
            Funcionarios.Add(f);
        }

        public static Funcionario Login(string usuario, string senha)
        {
            return Funcionarios
                .FirstOrDefault(f => f.Usuario == usuario && f.Senha == senha);
        }
    }
}
