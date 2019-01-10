using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades;
using Projeto01.Controles;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, Mundo!");

            // instanciando um objeto
            Produto produto = new Produto();

            // setters
            Console.WriteLine("Informe o código do produto........: ");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome do produto..........: ");
            produto.Nome = Console.ReadLine();

            Console.WriteLine("Informe o preço do produto.........: ");
            produto.Preco = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade do produto....: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            ProdutoControle produtoControle = new ProdutoControle();
            produtoControle.GravarArquivo(produto);

            Console.WriteLine("\nProduto gravado com sucesso!");
            
            Console.ReadKey();
        }
    }
}
