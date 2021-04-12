using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SconzoBank.Modelos.Contas
{
    public class CartaoCredito
    {
        public string NumeroCartao { get; set; }
        public string TitularCartao { get; set; }
        public string CSV { get; set; }
        public string Validade { get; set; }
        public double LimiteCartao { get; set; }
        public bool Bloqueado { get; set; }


        public void ImprimirInformacoesCartaoCredito()
        {
            string status;
            if (Bloqueado) status = "Bloqueado";
            else status = "Liberado";
            Console.WriteLine
                ($"Informações do Cartão\n" +
                $"--------------------------------\n" +
                $"Número ----> {NumeroCartao}\n" +
                $"Titular ----> {TitularCartao}\n" +
                $"CSV --------> {CSV}\n" +
                $"Válido até -> {Validade}\n" +
                $"Limite -----> {LimiteCartao}\n" +
                $"Status -----> {status}\n" +
                $"-------------------------------");
        }
    }
}
