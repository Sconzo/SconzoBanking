using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SconzoBank.Modelos.Funcionarios
{
    public class Senior : FuncionarioPadrao
    {
        public Senior(string nome, string numero_cracha) 
            : base(nome, numero_cracha,"Senior",8000)
        {
        }

        public override void AumentarSalario()
        {
            Salario *=1.3;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}
