using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SconzoBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var conta = new Conta(0, 011, 111);
            }
            catch (ArgumentException e)
            {

                Console.WriteLine(e.Message);
            }
           
            
            
            

            Console.Read();
        }
    }
}
