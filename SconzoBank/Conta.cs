using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SconzoBank
{
    class Conta
    {
        public int NumeroConta { get; set; }
        public int NumeroAgencia { get; set; }
        public double Saldo { get; set; }

        public Conta(int numero_conta,int numero_agencia,double deposito_inicial)
        {
            NumeroAgencia = numero_agencia;
            NumeroConta = numero_conta;
            Saldo = deposito_inicial;
        }
    }
}
