using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SconzoBank.Modelos.Funcionarios
{
    /// <summary>
    /// Classe abstrata que implementa a interface que permite aos funcionarios terem 
    /// acesso ao sistem interno do banco
    /// </summary>
    public abstract class CargoAcessoPermitido :  FuncionarioPadrao, IPermissaoAcesso
    {
        
        private GerenciadorSenha gerenciadorSenha = new GerenciadorSenha();

        public string Senha { get; internal set; }
        protected CargoAcessoPermitido(string nome, string numero_cracha,string funcao,double salario)
            : base(nome, numero_cracha,funcao,salario)
        {
        }

        public void CriarContaSistema()
        {
            gerenciadorSenha.DefinirSenha(this);
        }
        public void CriarContaSistema(string senha)
        {
            gerenciadorSenha.DefinirSenha(this,senha);
        }
        
        public bool AutenticarFuncionario()
        {
            Console.WriteLine("Digite a sua senha");
            var senha = Console.ReadLine();
            if (Senha == senha)
            {
                Console.WriteLine("Funcionario Autenticado");
                return true;
            }
            else
            {
                Console.WriteLine("Fucnionario não pode ser autenticado");
                return false;
            }
        }

        public bool AutenticarFuncionario(string senha)
        {
            if (Senha == senha)
            {
                Console.WriteLine("Funcionario Autenticado");
                return true;
            }
            else
            {
                Console.WriteLine("Fucnionario não pode ser autenticado");
                return false;
            }
        }



        

    }
}
