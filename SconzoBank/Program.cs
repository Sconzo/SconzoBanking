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
                var fun2 = new Estagiario("Sergio", "002");
                var fun3 = new Estagiario("Soely", "003");
                var fun4 = new Estagiario("Marina", "004");
                var fun5 = new Estagiario("José", "005");
                var fun6 = new Estagiario("Rosa", "006");

                fun6.ImprimirInformacoesFuncionario();
                fun6.AumentarSalario();
                fun6.ImprimirInformacoesFuncionario();
                fun6.Promover();
                fun6.ImprimirInformacoesFuncionario();
                fun6.Promover();
                fun6.ImprimirInformacoesFuncionario();
                
                //Console.WriteLine($"Conta criada com sucesso");
            }
            catch (ArgumentException e)
            {

                Console.WriteLine(e.Message);
            }
           
            
            
            

            Console.Read();
        }
    }
}
