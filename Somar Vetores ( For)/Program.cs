using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Somar_Vetores___For_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeroEntrada = new int[5];
            int soma = 0;

            for (int i = 0; i < numeroEntrada.Length; i++)
            {
                Console.WriteLine("Digite os números a serem somados: ");
                numeroEntrada[i] = int.Parse(Console.ReadLine());

                Console.Clear();
            }

            for (int i = 0; i < numeroEntrada.Length; i++)
            {
                soma += numeroEntrada[i];
                Console.Clear();

                Console.WriteLine("A soma dos números é: " + soma);
            }
            for (int i = 0; i < numeroEntrada.Length; i++)
            {
                Console.WriteLine("Os números somados são: " + numeroEntrada[i]);
            }
            Console.ReadKey();
        }
    }
}
