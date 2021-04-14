using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace SconzoBank
{
    public class Criptografia
    {
        static MD5 md5 = MD5.Create();
        public string CriarMD5(string senha)
        {
            if (senha == null)
            {
                //Console.WriteLine("sem senha");
                return null;
            }
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(senha));
            var sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public bool CompararMD5(string tentativa, string real)
        {
            if (CriarMD5(tentativa) == CriarMD5(real))
                {
                Console.WriteLine("As senha sao iguais!");
                return true;
                }
            Console.WriteLine("As senha sao diferentes!");

            return false;
        }
    }
}
