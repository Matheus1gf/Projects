using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Interfaces
{
    public interface IControle<T>
    {
        void ExportarParaTxt(T obj);
        void ExportarParaCsv(T obj);
        void ExportarParaXml(T obj);
    }
}
