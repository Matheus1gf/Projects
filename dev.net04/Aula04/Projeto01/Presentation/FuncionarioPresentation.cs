using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using Projeto01.Repositories;

namespace Projeto01.Presentation
{
    public class FuncionarioPresentation
    {
        public FuncionarioPresentation()
        {
            Presentation();
        }

        public void Presentation()
        {
            Console.WriteLine("\nFUNCIONÁRIOS:\n");

            Console.WriteLine("\nESCOLHA UMA OPÇÃO:\n");
            Console.WriteLine("\t1 - Cadastrar um Funcionário");
            Console.WriteLine("\t2 - Editar um Funcionário");
            Console.WriteLine("\t3 - Excluir um Funcionário");
            Console.WriteLine("\t4 - Consultar Funcionário");

            int opcao = int.Parse(Console.ReadLine());

            Funcionario funcionario = new Funcionario();
            funcionario.Setor = new Setor();
            FuncionarioRepository fr = new FuncionarioRepository();

            switch (opcao)
            {
                #region Caso1 - Cadastrar   
                case 1:
                    Console.WriteLine("\nCADASTRO DE FUNCIONÁRIO:\n");

                    Console.WriteLine("Informe o nome do Funcionário...: ");
                    funcionario.Nome = Console.ReadLine();

                    Console.WriteLine("Informe o salário do Funcionário...: ");
                    funcionario.Salario = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Informe a data de admissão do Funcionário...: ");
                    funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o número do setor do Funcionário...: ");
                    funcionario.Setor.IdSetor = int.Parse(Console.ReadLine());

                    try
                    {
                        fr.AbrirConexao();
                        fr.Inserir(funcionario);

                        Console.WriteLine("\nFuncionario cadastrado com sucesso!\n");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\nErro: " + e.Message);
                    }
                    finally
                    {
                        fr.FecharConexao();
                    }
                    break;
                #endregion

                #region Caso2 - Atualizar
                case 2:
                    Console.WriteLine("\nEDITAR FUNCIONÁRIO:\n");

                    Console.WriteLine("Informe o id do Funcionário que deseja atualizar.....: ");
                    funcionario.IdFuncionario = int.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o novo nome do Funcionário...: ");
                    funcionario.Nome = Console.ReadLine();

                    Console.WriteLine("Informe o novo salário do Funcionário...: ");
                    funcionario.Salario = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o nova Data de Admissão do Funcionário...: ");
                    funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o id do novo setor do Funcionário...: ");
                    funcionario.Setor.IdSetor = int.Parse(Console.ReadLine());

                    try
                    {
                        fr.AbrirConexao();
                        fr.Atualizar(funcionario);

                        Console.WriteLine("\nFuncionário {0} atualizado com sucesso!\n", funcionario.IdFuncionario);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\nErro: " + e.Message);
                    }
                    finally
                    {
                        fr.FecharConexao();
                    }
                    break;
                #endregion

                #region Caso3 - Excluir
                case 3:
                    Console.WriteLine("\nEXCLUIR FUNCIONÁRIO:\n");

                    Console.WriteLine("Informe o id do Funcionário que deseja excluir.....: ");
                    int idFuncionario = int.Parse(Console.ReadLine());

                    try
                    {
                        fr.AbrirConexao();
                        fr.Excluir(idFuncionario);

                        Console.WriteLine("\nFuncionário {0} excluído com sucesso!\n", idFuncionario);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\nErro: " + e.Message);
                    }
                    finally
                    {
                        fr.FecharConexao();
                    }
                    break;
                #endregion

                #region Caso4 - Consultar
                case 4:

                    try
                    {
                        fr.AbrirConexao();

                        List<Funcionario> lista = fr.Consultar();

                        Console.WriteLine("\nCONSULTA DE FUNCIONÁRIOS CADASTRADOS:\n");

                        foreach (Funcionario f in lista)
                        {
                            Console.WriteLine("Id Funcionário.....: " + f.IdFuncionario);
                            Console.WriteLine("Nome...............: " + f.Nome);
                            Console.WriteLine("Salário............: " + f.Salario);
                            Console.WriteLine("Data de Admissão...: " + f.DataAdmissao);
                            Console.WriteLine("Setor..............: " + f.Setor.Nome);
                            Console.WriteLine("************");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\nErro: " + e.Message);
                    }
                    finally
                    {
                        fr.FecharConexao();
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
