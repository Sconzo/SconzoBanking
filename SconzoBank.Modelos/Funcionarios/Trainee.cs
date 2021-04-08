using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SconzoBank.Modelos.Funcionarios
{
    
    public class Trainee : FuncionarioPadrao
    {
        public Trainee(string nome, int numero_cracha) 
            : base(nome, numero_cracha,"Trainee",2500)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.2;
        }

        //public override void Promover()
        //{
        //    
        //    Funcao = nameof(SconzoBank.Modelos.Funcionarios.Junior);
        //    Salario = _salarioJunior;
        //}

        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
