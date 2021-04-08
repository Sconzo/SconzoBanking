using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SconzoBank.Modelos;
using SconzoBank.Modelos.Funcionarios;

namespace SconzoBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                var fun1 = new Estagiario("Rodrigo",1);
                var fun2 = new Trainee("Sergio", 2);
                var fun3 = new Junior("Soely", 3);
                var fun4 = new Senior("Marina", 4);
                var fun5 = new Socio("José", 5);
                var fun6 = new Diretor("Rosa", 6);
                var fun7 = new ChefeDepartamento("Luke", 7);

                //fun3.ImprimirInformacoesFuncionario();

                //fun7.CriarContaSistema();
                //fun6.AutenticarFuncionario("Mortadela");

                
                //ConexaoMySQL.Conectando(fun1);
                ConexaoMySQL.Conectando(fun1);
                
                
                
                
               // Console.WriteLine($"Senha {fun6.Nome}: {fun6.Senha}\n" +
               //     $"Senha {fun7.Nome}: {fun7.Senha}");
            }
            catch (ArgumentException e)
            {

                Console.WriteLine(e.Message);
            }
           
            
            
            

            Console.Read();
        }
    }
}
