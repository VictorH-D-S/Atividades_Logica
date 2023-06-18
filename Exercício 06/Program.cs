using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Logica_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 6) Escreva um algoritmo para ler uma temperatura em graus Fahrenheit, calcular e 
                  escrever o valor correspondente em graus Celsius (baseado na fórmula abaixo): 
            */

            double farenheit, celsiusf;

            Console.WriteLine("Digite a temperatura em Fahrenheit: ");
            farenheit = float.Parse(Console.ReadLine());

            celsiusf = (farenheit - 32) / 1.8;

            Console.WriteLine($"A temperatura Fahrenheit {farenheit}º é equivalente a {celsiusf}º");

            Console.ReadKey();
        }
    }
}
