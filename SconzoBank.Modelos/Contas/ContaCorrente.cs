using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SconzoBank.Modelos.Contas
{
    public class ContaCorrente : Conta
    {
        //Nessa conta o dinheiro fica à sua disposição para ser sacado a qualquer momento.
        //Essa conta não gera rendimentos para o depositante.
        
        public CartaoCredito cartao_credito = new CartaoCredito();
        GeradorAleatorio geradorAleatorio = new GeradorAleatorio();
        public ContaCorrente(int numero_conta, int numero_agencia, 
            double deposito_inicial,string nome)
            :base(numero_conta,numero_agencia,deposito_inicial)
        {
            cartao_credito.NumeroCartao = geradorAleatorio.CriarNumeroCartao();
            cartao_credito.CSV = geradorAleatorio.CriarCSV();
            cartao_credito.Validade =$"{DateTime.Now.Month}/{DateTime.Now.Year + 4}";
            cartao_credito.TitularCartao = nome;
            cartao_credito.LimiteCartao = 0;
            cartao_credito.Bloqueado = true;
        }


        //public void PagarConta(double valor)
        //{
        //    this.Saldo = this.Saldo - valor - valor * 0.01;
        //}

    }
}
