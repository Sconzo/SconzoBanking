using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SconzoBank
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string NumeroCracha { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, string numero_cracha)
        {
            Nome = nome;
            NumeroCracha = numero_cracha;
        }
    }
}
