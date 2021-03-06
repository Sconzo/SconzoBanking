using SconzoBank.Modelos.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SconzoBank.Modelos
{
    /// <summary>
    /// Esta eh a classe que define uma conta do BancoSconzo
    /// </summary>
    public abstract class Conta
    {
        static readonly double DEPOSITO_MINIMO = 500;
        public int NumeroConta { get; set; }
        public int NumeroAgencia { get; set; }
        public double Saldo { get; set; }
        public string Titular { get; set; }
        /// <summary>
        /// Cria um objeto do tipo conta
        /// </summary>
        /// <param name="numero_conta"> O valor de <see cref="nameof(numeroconta)"/> deve ser maior que 0 </param> 
        /// <param name="numero_agencia">O valor de <see cref="nameof(numero_agencia)"/> deve ser maior que 0 </param>
        /// <param name="deposito_inicial">O valor de <see cref="nameof(deposito_inicial)"/> deve ser maior que 500</param>
        public Conta (int numero_conta,int numero_agencia,double deposito_inicial,Cliente cliente)
        {

            if (numero_conta <= 0 || numero_agencia <= 0){
                throw new ArgumentException($"Os argumentos: {nameof(numero_conta)}" +
                    $" e {nameof(numero_agencia) } devem ser ambos maiores que zero");
            }

            if (deposito_inicial < DEPOSITO_MINIMO)
            {
                throw new AberturaContaException(deposito_inicial, DEPOSITO_MINIMO);
            }

            NumeroAgencia = numero_agencia;
            NumeroConta = numero_conta;
            Saldo = deposito_inicial;
            Titular = cliente.Nome;

            Console.WriteLine("Conta aberta com sucesso");
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
