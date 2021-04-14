using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SconzoBank.Modelos;
using SconzoBank.Modelos.Contas;
using SconzoBank.Modelos.Funcionarios;

namespace SconzoBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var funcionarios_todos = CriarFuncionarios();
                AdicionarFuncionariosDB(funcionarios_todos.Item1, funcionarios_todos.Item2);

               
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            Console.Read();
        }



        static (List<FuncionarioPadrao>,List<CargoAcessoPermitido>) CriarFuncionarios()
        {
            List<FuncionarioPadrao> funcionarios = new List<FuncionarioPadrao>();
            List<CargoAcessoPermitido> superiores = new List<CargoAcessoPermitido>();

            try
            {
                
                var fun1 = new Estagiario("Rodrigo", 1);
                var fun2 = new Trainee("Sergio", 2);
                var fun3 = new Junior("Soely", 3);
                var fun4 = new Senior("Marina", 4);
                var fun5 = new Socio("José", 5);
                var fun6 = new Diretor("Rosa", 6);
                var fun7 = new ChefeDepartamento("Luke", 7);

                funcionarios.AddRange(new FuncionarioPadrao[] { fun1, fun2, fun3, fun4, fun5});
                superiores.AddRange(new CargoAcessoPermitido[] { fun6, fun7 });

                foreach (var funcioanrio in funcionarios) funcioanrio.ImprimirInformacoesFuncionario();
                    
                foreach (var superior in superiores) superior.ImprimirInformacoesFuncionario();
                
            }
            catch (ArgumentException e)
            {

                Console.WriteLine(e.Message);
            }

            return (funcionarios,superiores);

        }

        static void AdicionarFuncionariosDB(List<FuncionarioPadrao> funcionarios, List<CargoAcessoPermitido> superiores)
        {

            foreach (var funcionario in funcionarios) ConexaoMySQL.Conectando(funcionario);
            foreach (var superior in superiores) ConexaoMySQL.Conectando(superior);
            Console.WriteLine("Connection Closed. Press any key to exit...");
            Console.Read();
        }
    }
}
