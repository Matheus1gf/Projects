using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using Projeto01.Controls;
using Projeto01.Interfaces;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Valores
            //Instancias
            Autor autor1 = new Autor();
            autor1.Livros = new List<Livro>();
            
            Livro livro1 = new Livro();
            livro1.Autor = new Autor();
            //Setando valores de autor
            autor1.IdAutor = 1;
            autor1.Nome = "Tolkien";
            //Setando valores de livro
            livro1.IdLivro = 1;
            livro1.Titulo = "Senhor dos Anéis";
            livro1.Resumo = "Dispulta para ver quem enfia o dedo no anel do Frodo";
            livro1.Autor = autor1;
            //Instanciando e setando valores de livro2
            Livro livro2 = new Livro(2, "O Hobbit", "Um anão porreta que participa de uma guerra");
            livro2.Autor = autor1;
            //Relacionando autor a livros
            autor1.Livros.Add(livro1);
            autor1.Livros.Add(livro2);

            Console.WriteLine("\nDADOS DO AUTOR:\n");
            Console.WriteLine("\tId..........: "+autor1.IdAutor);
            Console.WriteLine("\tNome........: "+autor1.Nome);
            Console.WriteLine("\nDADOS DO LIVRO:\n");
            foreach (Livro i in autor1.Livros)
            {
                Console.WriteLine("\tID.............: "+ i.IdLivro);
                Console.WriteLine("\tTítulo.........: "+ i.Titulo);
                Console.WriteLine("\tResumo.........: "+ i.Resumo);
                Console.WriteLine("\tAutor..........: "+ i.Autor.Nome);
                Console.WriteLine("------------------------------------------------------------------");
            }
            
            #endregion

            try
            {
                AutorControle autorControle = new AutorControle();
                autorControle.ExportarParaCsv(autor1);
                Console.WriteLine("\nDados de autores gravados com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao exportar autor: "+e.Message);
            }

            try
            {
                LivroControle livroControle = new LivroControle();
                livroControle.ExportarParaTxt(livro1);
                livroControle.ExportarParaTxt(livro2);
                Console.WriteLine("\nDados de livros gravados com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao exportar autor: " + e.Message);
            }

            Console.ReadKey();
        }
    }
}
