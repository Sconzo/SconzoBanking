using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SconzoBank.Modelos.Funcionarios
{
    public abstract class CargoAcessoPermitido :  FuncionarioPadrao, IPermissaoAcesso
    {

        private GerenciadorSenha gerenciadorSenha = new GerenciadorSenha();
        private AutenticadorAuxiliar autenticadorAuxiliar = new AutenticadorAuxiliar();

        public string Senha { get; internal set; }
        protected CargoAcessoPermitido(string nome, string numero_cracha,string funcao,double salario)
            : base(nome, numero_cracha,funcao,salario)
        {
        }

        public void CriarContaSistemaConsole()
        {
            gerenciadorSenha.DefinirSenhaConsole(this);
        }
        public void CriarContaSistemaProgram(string senha)
        {
            gerenciadorSenha.DefinirSenhaProgram(this,senha);
        }
        
        public bool AutenticarFuncionario(string senha)
        {
            return autenticadorAuxiliar.SenhasCoincidem(Senha,senha);           
        }



        

    }
}
