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
    class AutorControle : IAutorControle
    {
        public void ExportarParaCsv(Autor autor)
        {
            StreamWriter sw = new StreamWriter("c:\\temp\\autor.csv", true);

            string dados = $"{autor.IdAutor};{autor.Nome};";
            sw.WriteLine(dados);

            sw.Close();
        }
    }
}
