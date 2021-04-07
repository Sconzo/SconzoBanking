using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SconzoBank.Modelos.Funcionarios
{
    internal class AutenticadorAuxiliar
    {


        public bool SenhasCoincidem(string string1, string string2)
        {
            return string1 == string2;
        }
    }
}
