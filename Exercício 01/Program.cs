using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Logica_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               1) Escreva um algoritmo para ler o número total de eleitores de um município, o número 
                de votos brancos, nulos e válidos. Calcular e escrever o percentual que cada um 
                representa em relação ao total de eleitores.
            */

            int eleitores, votosb, votosn, votosv;

            Console.WriteLine("Insira o número total de eleitores: ");
            eleitores = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o número de votos brancos: ");
            votosb = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o número de votos nulos: ");
            votosn = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o número de votos válidos: ");
            votosv = int.Parse(Console.ReadLine());

            int por_votosb = (votosb * 100) / eleitores, por_votosn = (votosn * 100) / eleitores, por_votosv = (votosv * 100)/eleitores ;

            Console.WriteLine("Percentual de votos: ");
            Console.WriteLine($"Total de eleitores: {eleitores}");
            Console.WriteLine($"Votos brancos: {por_votosb}%");
            Console.WriteLine($"Votos nulos: {por_votosn}%");
            Console.WriteLine($"Votos válido: {por_votosv}%");

            Console.ReadKey();
        }
    }
}
