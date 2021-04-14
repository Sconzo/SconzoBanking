using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SconzoBank.Modelos.Funcionarios
{
    public class Diretor : CargoAcessoPermitido
    {
        public Diretor(string nome, int numero_cracha) 
            : base(nome, numero_cracha,"Diretor",21000)
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
