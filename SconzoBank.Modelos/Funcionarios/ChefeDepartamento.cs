using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SconzoBank.Modelos.Funcionarios
{
    public class ChefeDepartamento : CargoAcessoPermitido
    {
        public ChefeDepartamento(string nome, string numero_cracha) 
            : base(nome, numero_cracha,"Chefe de Departamento", 32000)
        {
        }

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
