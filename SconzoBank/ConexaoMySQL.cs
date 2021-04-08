using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SconzoBank.Modelos;
using SconzoBank.Modelos.Funcionarios;

namespace SconzoBank
{
    public class ConexaoMySQL
    {


        public static void Conectando(CargoAcessoPermitido funcionario)
        {
            Conectando(funcionario, funcionario.Senha);
        }
        public static void Conectando(FuncionarioPadrao funcionario)
        {
            Conectando(funcionario, null);
        }
        private static void  Conectando(FuncionarioPadrao funcionario, string senha)
        {
            //your MySQL connection string  funcionarios_SconzoBanking
            string connStr = "server=localhost;user=root;database=sconzo_banking_funcionarios;port=3306;password=Tilapi@123";

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                //Conferindo se o Funcionario com este numero de crachá já foi inserido na tabela
                string read_sql = $"SELECT numero_cracha FROM informacao_funcionarios";
                MySqlCommand read_cmd = new MySqlCommand(read_sql, conn);
                MySqlDataReader rdr = read_cmd.ExecuteReader();
                int i = 0;
                while (rdr.Read())
                {
                    if((int)rdr[i] == funcionario.NumeroCracha)
                    {
                        throw new Exception("Esse funcionario já foi introduzido no banco de dados");
                    }
                    
                    
                }
                rdr.Close();
                //SQL Query to execute
                //insert Query
                // we are inserting actor_id, first_name, last_name, last_updated columns data
                string write_sql = $"INSERT INTO informacao_funcionarios VALUES ('{funcionario.Nome}',{funcionario.NumeroCracha},'{funcionario.Funcao}',{funcionario.Salario},'{senha}')";
                MySqlCommand write_cmd = new MySqlCommand(write_sql, conn);
                write_cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }

            conn.Close();
            Console.WriteLine("Connection Closed. Press any key to exit...");
            Console.Read();
        }
    }
}
