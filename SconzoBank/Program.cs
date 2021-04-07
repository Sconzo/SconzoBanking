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
                
                var fun1 = new Estagiario("Rodrigo","001");
                var fun2 = new Trainee("Sergio", "002");
                var fun3 = new Junior("Soely", "003");
                var fun4 = new Senior("Marina", "004");
                var fun5 = new Socio("José", "005");
                var fun6 = new Diretor("Rosa", "006");
                var fun7 = new ChefeDepartamento("Luke", "007");

                fun6.CriarContaSistemaProgram("123");
                fun6.AutenticarFuncionario("234");
                //fun7.CriarContaSistemaConsole();
                
                
                
                
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
