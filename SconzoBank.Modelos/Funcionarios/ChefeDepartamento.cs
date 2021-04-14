using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SconzoBank.Modelos.Funcionarios
{
    public class ChefeDepartamento : CargoAcessoPermitido
    {
        public ChefeDepartamento(string nome, int numero_cracha) 
            : base(nome, numero_cracha,"Chefe de Departamento", 32000)
        {
            CriarContaSistema();
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
