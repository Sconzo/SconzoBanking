using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SconzoBank.Modelos;

namespace SconzoBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var conta = new Conta(2, 011, 1100);
            }
            catch (ArgumentException e)
            {

                Console.WriteLine(e.Message);
            }
           
            
            
            

            Console.Read();
        }
    }
}
