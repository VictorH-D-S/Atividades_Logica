using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Logica_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*5) Escreva um algoritmo para ler um valor (do teclado) e escrever (na tela) o seu 
                antecessor
            */

            int valor;

            Console.WriteLine("Digite um valor do teclado: ");
            valor = int.Parse(Console.ReadLine());

            Console.WriteLine($"O antecessor de seu número inserido é: {valor - 1}");

            Console.ReadKey();
        }
    }
}
