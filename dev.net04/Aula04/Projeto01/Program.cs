using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using Projeto01.Repositories;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("\nCADASTRO DE SETOR:\n");

            Setor setor = new Setor();

            Console.WriteLine("Informe o nome do setor...:");
            setor.Nome = Console.ReadLine();


            Console.WriteLine("Gravado com sucesso");

            try
            {

                SetorRepository sr = new SetorRepository();
                sr.AbrirConexao();
                sr.Inserir(setor);
                sr.FecharConexao();

            }
            catch(Exception e)
            {
                Console.WriteLine("Deu ruim Playboy, vê teu código que tu fez merda aqui: " + e.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Muito obrigado pela preferência");
            }
            */

            /////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\nCADASTRO DE FUNCIONARIO:\n");

            Funcionario funcionario = new Funcionario();
            Setor setor = new Setor();
            funcionario.Setor = new Setor();

            Console.WriteLine("Informe o nome do Funcionario...:");
            funcionario.Nome = Console.ReadLine();
            Console.WriteLine("Informe o salário do Funcionario...:");
            funcionario.Salario = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe a data de admissão do Funcionario...:");
            funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Id Setor do Funcionario...:");
            funcionario.IdFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Gravado com sucesso");

            try
            {
                FuncionarioRepository fr = new FuncionarioRepository();
                fr.AbrirConexao();
                fr.Inserir(funcionario);
                fr.FecharConexao();

            }
            catch (Exception e)
            {
                Console.WriteLine("Deu ruim Playboy, vê teu código que tu fez merda aqui: " + e.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Muito obrigado pela preferência");
            }

            Console.ReadKey();
        }
    }
}
