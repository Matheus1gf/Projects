using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projeto01.Entities;

namespace Projeto01.Repositories
{
    public class FuncionarioRepository : Conexao
    {
        public void Inserir(Funcionario funcionario)
        {
           string query = "insert into Funcionario(Nome, Salario, DataAdmissao, IdSetor)" 
                + " values(@Nome, @Salario, @DataAdmissao, @IdSetor)";

            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@Nome", funcionario.Nome);
            Command.Parameters.AddWithValue("@Salario", funcionario.Salario);
            Command.Parameters.AddWithValue("@DataAdmissao", funcionario.DataAdmissao);
            Command.Parameters.AddWithValue("@IdSetor", funcionario.Setor.IdSetor);
            Command.ExecuteNonQuery();
        }

        public void Atualizar(Funcionario funcionario)
        {
            string query = "update Funcionario set Nome = @Nome, " +
                "Salario = @Salario, DataAdmissao = @DataAdmissao, " +
                "IdSetor = @IdSetor where IdFuncionario = @IdFuncionario";

            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@Nome", funcionario.Nome);
            Command.Parameters.AddWithValue("@Salario", funcionario.Salario);
            Command.Parameters.AddWithValue("@DataAdmissao", funcionario.DataAdmissao);
            Command.Parameters.AddWithValue("@IdSetor", funcionario.Setor.IdSetor);
            Command.Parameters.AddWithValue("@IdFuncionario", funcionario.IdFuncionario);
            Command.ExecuteNonQuery();
        }

        public void Excluir(int idFuncionario)
        {
            string query = "delete from Funcionario where IdFuncionario = @IdFuncionario";

            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@IdFuncionario", idFuncionario);
            Command.ExecuteNonQuery();
        }

        public List<Funcionario> Consultar()
        {
            string query = "select " +
                           "f.IdFuncionario, " +
                           "f.Nome as NomeFuncionario, " +
                           "f.Salario, " +
                           "f.DataAdmissao, " +
                           "s.IdSetor, " +
                           "s.Nome as NomeSetor " +
                           "from Funcionario f inner " +
                           "join Setor s " +
                           "on s.IdSetor = f.IdSetor";

            Command = new SqlCommand(query, Connection);
            DataReader = Command.ExecuteReader();

            List<Funcionario> lista = new List<Funcionario>();

            while(DataReader.Read())
            {
                Funcionario funcionario = new Funcionario();
                funcionario.Setor = new Setor();

                funcionario.IdFuncionario = Convert.ToInt32(DataReader["IdFuncionario"]);
                funcionario.Nome = Convert.ToString(DataReader["NomeFuncionario"]);
                funcionario.Salario = Convert.ToDecimal(DataReader["Salario"]);
                funcionario.DataAdmissao = Convert.ToDateTime(DataReader["DataAdmissao"]);
                funcionario.Setor.IdSetor = Convert.ToInt32(DataReader["IdSetor"]);
                funcionario.Setor.Nome = Convert.ToString(DataReader["NomeSetor"]);

                lista.Add(funcionario);
            }

            return lista;
        }
    }
}
