using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SconzoBank.Modelos.Contas
{
    class AberturaContaException : OperacaoFinanceiraException
    {
        public AberturaContaException()
        {
        }

        public AberturaContaException(string message) : base(message)
        {
        }

        public AberturaContaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public AberturaContaException(double deposito_inicial,double deposito_minimo)
            :this($"Houve uma tentativa de abertura de conta com o valor de R${deposito_inicial}.\n" +
                 $"Para abrir uma conta no SconzoBanking é preciso depositar um " +
                 $"valor inicial de R${deposito_minimo}.\n ")
        {
        }
    }
}
