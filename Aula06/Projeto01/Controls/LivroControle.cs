using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using Projeto01.Interfaces;
using System.IO;


namespace Projeto01.Controls
{
    class LivroControle : ILivroControle
    {
        public void ExportarParaTxt(Livro livro)
        {
            StreamWriter sw = new StreamWriter("c:\\temp\\livro.txt", true);
                
                sw.WriteLine("Id do livro.......: " + livro.IdLivro);
                sw.WriteLine("Título............: " + livro.Titulo);
                sw.WriteLine("Resumo............: " + livro.Resumo);
                sw.WriteLine("Autor.............: " + livro.Autor.Nome);
                
            sw.Close();
        }
    }
}
