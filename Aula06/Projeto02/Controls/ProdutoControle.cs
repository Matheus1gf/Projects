using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Interfaces;
using Projeto02.Entities;
using System.IO;
using System.Xml;


namespace Projeto02.Controls
{
    class ProdutoControle : IControle<Produtos>
    {
        public void ExportarParaCsv(Produtos obj)
        {
            StreamWriter sw = new StreamWriter("c:\\temp\\produto.csv", true);

            string dados = $"{obj.IdProduto};{obj.Nome};{obj.Preco};";

            sw.WriteLine(dados);
        }

        public void ExportarParaTxt(Produtos obj)
        {
            StreamWriter sw = new StreamWriter("c:\\temp\\produtos.txt", true);

            sw.WriteLine("Código do Produto..........: " + obj.IdProduto);
            sw.WriteLine("Nome.......................: " + obj.Nome);
            sw.WriteLine("Preço......................: " + obj.Preco);
            sw.WriteLine("--------------------------------------");

            sw.Close();
        }

        public void ExportarParaXml(Produtos obj)
        {
            using (XmlWriter xml = XmlWriter.Create("c:\\temp\\produtos.xml"))
            {
                xml.WriteStartDocument();

                xml.WriteStartElement("produtos");
                xml.WriteElementString("idproduto", obj.IdProduto.ToString());
                xml.WriteElementString("nome", obj.Nome);
                xml.WriteElementString("preco", obj.Preco.ToString());
                xml.WriteEndElement();
            }
        }
    }
}
