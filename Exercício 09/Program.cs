using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Logica_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            9) Ler dois valores (considere que não serão lidos valores iguais) e escrevê-los em ordem 
               crescente.
             */

            double val1, val2;

            Console.WriteLine("Insira Valor 1: ");
            val1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira Valor 2: ");
            val2 = double.Parse(Console.ReadLine());

            if (val1 == val2)
            {
                Console.WriteLine("Insira valores diferentes. ");
                Console.ReadLine();
                Console.Clear();
                Main(args);
                return;
            }
            if (val1 > val2)
            {
                Console.WriteLine($"Menor valor: {val2}\nMaior valor: {val1}");
            }
            else
            {
                Console.WriteLine($"Menor valor: {val1}\nMaior valor: {val2}");
            }

            Console.ReadKey();
        }
    }
}
