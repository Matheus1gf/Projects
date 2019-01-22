using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using Projeto01.Repositories;

namespace Projeto01.Presentation
{
    public class SetorPresentation
    {
        public SetorPresentation()
        {
            Presentation();
        }

        public void Presentation()
        {
            Console.WriteLine("\nSETORES:\n");

            Console.WriteLine("\nESCOLHA UMA OPÇÃO:\n");
            Console.WriteLine("\t1 - Cadastrar um setor");
            Console.WriteLine("\t2 - Editar um setor");
            Console.WriteLine("\t3 - Excluir um setor");
            Console.WriteLine("\t4 - Consultar setores");

            int opcao = int.Parse(Console.ReadLine());

            Setor setor = new Setor();
            SetorRepository sr = new SetorRepository();

            switch (opcao)
            {
                #region Caso1 - Cadastrar   
                case 1:
                    Console.WriteLine("\nCADASTRO DE SETOR:\n");

                    Console.WriteLine("Informe o nome do Setor...: ");
                    setor.Nome = Console.ReadLine();

                    try
                    {
                        sr.AbrirConexao();
                        sr.Inserir(setor);

                        Console.WriteLine("\nSetor cadastrado com sucesso!\n");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\nErro: " + e.Message);
                    }
                    finally
                    {
                        sr.FecharConexao();
                    }
                    break;
                #endregion

                #region Caso2 - Atualizar
                case 2:
                    Console.WriteLine("\nEDITAR SETOR:\n");

                    Console.WriteLine("Informe o id do Setor que deseja atualizar.....: ");
                    setor.IdSetor = int.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o novo nome do Setor...: ");
                    setor.Nome = Console.ReadLine();

                    try
                    {
                        sr.AbrirConexao();
                        sr.Atualizar(setor);

                        Console.WriteLine("\nSetor {0} atualizado com sucesso!\n", setor.IdSetor);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\nErro: " + e.Message);
                    }
                    finally
                    {
                        sr.FecharConexao();
                    }
                    break;
                #endregion

                #region Caso3 - Excluir
                case 3:
                    Console.WriteLine("\nEXCLUIR SETOR:\n");

                    Console.WriteLine("Informe o id do Setor que deseja excluir.....: ");
                    int idSetor = int.Parse(Console.ReadLine());

                    try
                    {
                        sr.AbrirConexao();
                        sr.Excluir(idSetor);

                        Console.WriteLine("\nSetor {0} excluído com sucesso!\n", idSetor);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\nErro: " + e.Message);
                    }
                    finally
                    {
                        sr.FecharConexao();
                    }
                    break;
                #endregion

                #region Caso4 - Consultar
                case 4:

                    try
                    {
                        sr.AbrirConexao();

                        List<Setor> lista = sr.Consultar();

                        Console.WriteLine("\nCONSULTA DE SETORES CADASTRADOS:\n");

                        foreach (Setor s in lista)
                        {
                            Console.WriteLine("Id Setor.....: " + s.IdSetor);
                            Console.WriteLine("Nome.........: " + s.Nome);
                            Console.WriteLine("************");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\nErro: " + e.Message);
                    }
                    finally
                    {
                        sr.FecharConexao();
                    }
                    break;

                #endregion

                default:
                    Console.WriteLine("Por favor, digite uma opção válida.");
                    break;
            }
        }
    }
}
