using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;

namespace Projeto01.Interfaces
{
    public interface ILivroControle
    {
        //Método abstrato
        void ExportarParaTxt(Livro livro);

    }
}
