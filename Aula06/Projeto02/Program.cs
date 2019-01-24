using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities;
using Projeto02.Controls;

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(1, "Felipe", "felipe@gmail.com");
            ClienteControle controle = new ClienteControle();

            try
            {
                controle.ExportarParaTxt(cliente);
                controle.ExportarParaCsv(cliente);
                controle.ExportarParaXml(cliente);

                Console.WriteLine("\nCliente gravado");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

            Console.WriteLine("Digite o produto");
            Console.WriteLine("Codigo............:");
            Console.WriteLine("Nome..............:");
            Console.WriteLine("Preco.............:");


            try
            {
                controle.ExportarParaTxt(produto);
                controle.ExportarParaCsv(cliente);
                controle.ExportarParaXml(cliente);

                Console.WriteLine("\nCliente gravado");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

        }
    }
}
