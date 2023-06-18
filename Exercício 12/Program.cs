using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Logica_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            Console.Write("Digite o primeiro valor: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            y = double.Parse(Console.ReadLine());
            double z = (x + y) + 5;

            if (z <= 0)
            {
                Console.WriteLine("Resposta <- 'A'");
                Console.ReadKey();

            }

            else if (z <= 100)
            {
                Console.WriteLine("Resposta <- 'B'");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Resposta <- 'C'");
            }

            Console.WriteLine($"Resposta = {z}");
            Console.ReadKey();
        }
    }
}
