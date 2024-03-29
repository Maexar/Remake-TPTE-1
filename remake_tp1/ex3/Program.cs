using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Produto> produtos = new List<Produto>();

            int opcao;


               

                while (true)
                {
                    Console.WriteLine("==== Menu ====");
                    Console.WriteLine("1 - Cadastrar Produto");
                    Console.WriteLine("2 - Listar Produto");
                    Console.WriteLine("3 - Sair");
                    opcao = int.Parse(Console.ReadLine());
                     try
                     {
                        opcao = int.Parse(Console.ReadLine());
                        break;

                    }
                    catch (Exception)
                    {
                         Console.WriteLine("Opção INVÁLIDA! Tente Novamente.");
                    }

                    if (opcao == 1) {
                         Console.WriteLine("Digite o nome do produto:");
                         string nome = Console.ReadLine();

                         Console.WriteLine("Digite o preco do produto:");
                         double preco = double.Parse(Console.ReadLine());

                         Produto produtos = new Produto(nome, preco);
                         produtos.Add(produtos);

                    if (opcao == 2)
                    {
                        Console.WriteLine()
                    }
                         
                            }
                    
                }






             
        }
    }

    internal class Produto
    {
    }
}
