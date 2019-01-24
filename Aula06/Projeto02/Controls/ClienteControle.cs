using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities;
using Projeto02.Interfaces;
using System.IO;
using System.Xml;

namespace Projeto02.Controls
{
    class ClienteControle : IControle<Cliente>
    {
        public void ExportarParaCsv(Cliente obj)
        {
            StreamWriter sw = new StreamWriter("c:\\temp\\cliente.csv", true);

            string dados = $"{obj.IdCliente};{obj.Nome};{obj.Email};";

            sw.WriteLine(dados);
        }

        public void ExportarParaTxt(Cliente obj)
        {
            StreamWriter sw = new StreamWriter("c:\\temp\\cliente.txt", true);

            sw.WriteLine("Código do cliente..........: " + obj.IdCliente);
            sw.WriteLine("Nome.......................: " + obj.Nome);
            sw.WriteLine("Email......................: " + obj.Email);
            sw.WriteLine("--------------------------------------");

            sw.Close();
        }

        public void ExportarParaXml(Cliente obj)
        {
            using (XmlWriter xml = XmlWriter.Create("c:\\temp\\cliente.xml"))
            {
            xml.WriteStartDocument();

            xml.WriteStartElement("Cliente");
            xml.WriteElementString("idcliente", obj.IdCliente.ToString());
            xml.WriteElementString("nome", obj.Nome);
            xml.WriteElementString("email", obj.Email.ToString());
            xml.WriteEndElement();
            }
            
        }
    }
}
