using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SconzoBank.Modelos.Funcionarios
{
    /// <summary>
    /// Classe que confere se a senha criada esta dentro dos conformes
    /// </summary>
    internal class GerenciadorSenha
    {

        /// <summary>
        /// Garante que a senha possui caracteres em maiúsculo e em minúsculo.
        /// Também impede que a senha seja composta apenas por números
        /// </summary>
        /// <param name="senha"></param>
        /// <returns></returns>
        private bool AutenticarSenha(string senha)
        {
            string upper = senha.ToUpper();
            string lower = senha.ToLower();

            return !(upper == senha || lower == senha);
        }
        /// <summary>
        /// Define a senha digitada pelo usuário
        /// </summary>
        /// <param name="cargoAcessoPermitido"></param>
        public void DefinirSenha(CargoAcessoPermitido cargoAcessoPermitido)
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

        /// <summary>
        /// Define a senha definida pelo programador
        /// </summary>
        /// <param name="cargoAcessoPermitido"></param>
        /// <param name="senha"></param>
        public void DefinirSenha(CargoAcessoPermitido cargoAcessoPermitido ,string senha)
        {
            cargoAcessoPermitido.Senha = senha;
        }
    }
}
