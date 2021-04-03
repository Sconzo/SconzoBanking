using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SconzoBank
{
    public class Conta
    {
        public int NumeroConta { get; set; }
        public int NumeroAgencia { get; set; }
        public double Saldo { get; set; }

        public Conta (int numero_conta,int numero_agencia,double deposito_inicial)
        {
            NumeroAgencia = numero_agencia;
            NumeroConta = numero_conta;
            Saldo = deposito_inicial;
        }

        public void AdicionarFundos(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor;
        }

        public void Transferir(Conta Conta_Destino, double valor)
        {
            this.Sacar(valor);

            Conta_Destino.AdicionarFundos(valor);
        }

        
    }
}
