using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SconzoBank.Modelos.Funcionarios
{
    internal class GerenciadorSenha
    {
        private bool AutenticarSenha(string senha)
        {
            string upper = senha.ToUpper();
            string lower = senha.ToLower();

            return !(upper == senha || lower == senha);
        }
        public void DefinirSenhaConsole(CargoAcessoPermitido cargoAcessoPermitido)
        {
            Console.WriteLine("Sua senha deve conter caracteres em maiúsculo e em minúsculo");
            while (true)
            {
                Console.WriteLine("Digite sua senha: ");
                string primeira_tentativa = Console.ReadLine();
                Console.WriteLine("Digite sua senha novamente: ");
                string segunda_tentativa = Console.ReadLine();
                if (primeira_tentativa != segunda_tentativa)
                {
                    Console.WriteLine("As senhas digitadas não coincidem, tente novamente");
                }
                else
                {
                    if (AutenticarSenha(primeira_tentativa))
                    {
                        cargoAcessoPermitido.Senha = primeira_tentativa;
                        Console.WriteLine("Senha definida com sucesso");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("A senha não é forte o sufuciente");
                    }
                }
            }

        }
        public void DefinirSenhaProgram(CargoAcessoPermitido cargoAcessoPermitido ,string senha)
        {
            cargoAcessoPermitido.Senha = senha;
        }
    }
}
