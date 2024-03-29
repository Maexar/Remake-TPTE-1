using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int disciplina;
            Console.WriteLine("Informe o número de disciplinas: ");

            while(true){ 
                 try
                    {
                  disciplina = int.Parse(Console.ReadLine());
                    break;
                    } catch (Exception) {

                    Console.WriteLine("Informe um NÚMERO INTEIRO para disciplinas");

                     }
            }
            int[] nota= new int[disciplina];
            int media;

            for(int i = 0; i < disciplina; i++) 
            {

                
                Console.WriteLine($"Informe a nota da disciplina {i+1}");
                nota[i] = int.Parse(Console.ReadLine());

                
            }

            int soma = nota.Sum();

            media= soma/disciplina;

            Console.WriteLine($"Sua média foi de {media}");

           
            Console.ReadLine();
        }
    }
}
