using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SconzoBank.Modelos.Funcionarios
{
    public class Socio : FuncionarioPadrao
    {
        public Socio(string nome, int numero_cracha) 
            : base(nome, numero_cracha,"Socio", 12000){}

        public override void AumentarSalario()
        {
            Salario *= 1.5;
        }

        public override double GetBonificacao()
        {
            return Salario;
        }
    }
}
