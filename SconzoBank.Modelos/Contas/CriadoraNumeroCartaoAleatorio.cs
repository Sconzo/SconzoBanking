using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SconzoBank.Modelos.Contas
{
    public class GeradorAleatorio 
    {
        static string final = "";
        
        public  string CriarNumeroCartao()
        {
            Random random = new Random();
            string temp;

            for (int i = 0; i < 4; i++)
            {
                int parcial = random.Next(10000);
                if (parcial < 10)
                    temp = $"000{parcial}-";
                
                else if (parcial < 100)
                    temp = $"00{parcial}-";
                
                else if (parcial < 1000)
                    temp = $"0{parcial}-";
                
                else 
                    temp = $"{parcial}-";

                final = final.Insert(final.Length, temp);
            }
            return final.Substring(0, final.Length-1);           
        }

        public string CriarCSV()
        {
            Random random = new Random();
            int parcial = random.Next(1,1000);
            string csv;
            if (parcial < 10)
                csv = $"00{parcial}";
            
            else if (parcial < 100) 
                csv = $"0{parcial}";
            
            else 
                csv = $"{parcial}";

            return csv;
        }
    }
}
