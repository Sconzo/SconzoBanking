using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SconzoBank.Modelos.Funcionarios
{
    public class Estagiario : FuncionarioPadrao
    {
        
        public Estagiario(string nome, string numero_cracha) 
            : base(nome, numero_cracha) 
        {
            Salario = _salarioEstagiario;
            Funcao = nameof(Estagiario);
        }
       
        public override void AumentarSalario()
        {
            Salario *= 1.2;
        }

        public override void Promover()
        {
            this = new Trainee(Nome, NumeroCracha);
            Funcao = nameof(SconzoBank.Modelos.Funcionarios.Trainee);
            Salario = _salarioTrainee;
        }

        public override double GetBonificacao()
        {
            return 0.2 * Salario;
        }
    }
}
