using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Logica_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            4) Escreva um algoritmo para ler as dimensões de um retângulo (base e altura), calcular e 
            escrever a área do retângulo. A área do é a base X altura.
            */

            float basef, altura, area;

            Console.WriteLine("Digite a base do retângulo: ");
            basef = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do retângulo: ");
            altura = float.Parse(Console.ReadLine());

            area = basef * altura;

            Console.WriteLine($"A area do retângulo é igual a {area}");

            Console.ReadKey();
        }
    }
}
