using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Aula05.Entities;

namespace Aula05.Repositories
{
    public class ProdutoRepository : Conexao
    {
        public void Inserir(Produto produto)
        {
            Command = new SqlCommand("SpInserirProduto", Connection);
            Command.CommandType = CommandType.StoredProcedure;

            Command.Parameters.AddWithValue("@Nome", produto.Nome);
            Command.Parameters.AddWithValue("@Preco", produto.Preco);
            Command.ExecuteNonQuery();
        }
        public void Atualizar(Produto produto)
        {

        }
        public void Excluir(int IdProduto)
        {

        }
    }
}
