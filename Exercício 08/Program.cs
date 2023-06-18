using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Logica_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 8) Ler dois valores (considere que não serão lidos valores iguais) e escrever o maior deles.
             */

            double valor1, valor2;

            Console.WriteLine("Insira o valor 1: ");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor 2: ");
            valor2 = double.Parse(Console.ReadLine());

            if (valor1 == valor2)
            {
                Console.WriteLine("Valores invalidos. Digite valores diferentes.");
                Console.ReadLine();
                Console.Clear();
                Main(null);
                return;
            }
            else
            if (valor1 > valor2)
            {
                Console.WriteLine($"O valor maior é o Valor 1 ({valor1})");
            }
            else
            {
                Console.WriteLine($"O valor maior é o Valor 2 ({valor2})");
            }

            Console.ReadKey();
        }
    }
}
