using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            char opcao;


            do
            {

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Informe um NÚMERO INTEIRO para contagem regressiva: ");
                        numero = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Valor INVÁLIDO, tente novamente");
                    }
                }
                int aux = numero;

                Console.WriteLine("Contando...");

                for (int i = 0; i <= aux; i++)
                {
                    Console.WriteLine($"{numero}");
                    numero--;

                }

                Console.WriteLine("Fim da Contagem Regressiva");

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Deseja fazer uma nova contagem? S/N");
                        opcao = char.Parse(Console.ReadLine().ToLower());
                        break;
                    }catch (Exception) { 
                        Console.WriteLine("Resposta INVÁLIDA, tente novamente");
                    }
                }
                
            } while (opcao == 's');

           

        }
    }
}
