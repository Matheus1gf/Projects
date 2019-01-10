using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entidades
{
    public class Produto
    {
        // atributos (campos)
        private int codigo;
        private string nome;
        private decimal preco;
        private int quantidade;

        // métodos (funções)
        public int Codigo
        {
            set { codigo = value; } // entrada
            get { return codigo; } // saída
        }

        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }

        public decimal Preco
        {
            set { preco = value; }
            get { return preco; }
        }

        public int Quantidade
        {
            set { quantidade = value; }
            get { return quantidade; }
        }
    }
}
