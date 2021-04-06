using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SconzoBank.Modelos
{
    public abstract class FuncionarioPadrao
    {
        protected double _salarioEstagiario = 1000;
        protected double _salarioTrainee = 2500;
        protected double _salarioJunior = 4500;
        protected double _salarioSenior = 8000;
        protected double _salarioSocio = 12000;
        protected double _salarioDiretor = 21000;
        protected double _salarioChefeDepartamento = 32000;

        public string Nome { get; set; }
        public string NumeroCracha { get; set; }
        public string Funcao { get; set; }
        public double Salario { get; set; }
        public static int TotalFuncionarios { get; private set; } // a variável static diz respeito a classe

        public FuncionarioPadrao(string nome, string numero_cracha)
        {
            Nome = nome;
            NumeroCracha = numero_cracha;
            TotalFuncionarios+=1;
        }

        public abstract void AumentarSalario();
        public abstract void Promover();
        public abstract double GetBonificacao();

        public void ImprimirInformacoesFuncionario()
        {
            if (this == null)
            {
                throw new ArgumentException("Funcionario inexistente");
            }
            Console.WriteLine
                ($"Informações do Funcionario:\n\n" +
                $"Nome: -----------------> {Nome}\n" +
                $"Num Cracha ------------> {NumeroCracha}\n" +
                $"Funcao: ---------------> {Funcao}\n" +
                $"Salario ---------------> {Salario}\n" +
                $"Bonificacao -----------> {GetBonificacao()}\n" +
                $"Total de Funcionarios -> {FuncionarioPadrao.TotalFuncionarios}\n");
        }

    }
}
