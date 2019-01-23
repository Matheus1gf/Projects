using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula05.Entities;
using Aula05.Repositories;

namespace Aula05
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            ProdutoRepository repository = new ProdutoRepository();
            try
            {
                Console.WriteLine("Nome do produto....:");
                produto.Nome = Console.ReadLine();

                Console.WriteLine("Preço do produto....:");
                produto.Preco = decimal.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }
            finally
            {
                repository.FecharConexao();
            }

        }
    }
}
