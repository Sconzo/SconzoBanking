using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SconzoBank.Modelos.Funcionarios
{
    public class Junior : FuncionarioPadrao
    {
        public Junior(string nome, string numero_cracha) : base(nome, numero_cracha)
        {
            Salario = _salarioJunior;
            Funcao = nameof(Junior);
        }

        public override void AumentarSalario()
        {
            Salario *= 1.3;
        }

        public override void Promover()
        {
            Salario = _salarioSenior;
            Funcao = nameof(Senior);
        }

        public override double GetBonificacao()
        {
            return Salario * 0.3;
        }
    }
}
