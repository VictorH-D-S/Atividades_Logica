using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Logica_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7) As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se 
                 forem compradas pelo menos 12. Escreva um programa que leia o número de maçãs 
                 compradas, calcule e escreva o custo total da compra.
             * 
             */

            double maca_compradas, valor;
            Console.WriteLine("Insira a quantidade de maçãs a serem compradas: ");
            maca_compradas = double.Parse(Console.ReadLine());

            if (maca_compradas < 12)
            {
                valor = 1.30;

            }
            else
            {
                valor = 1.00;
            }

            Console.WriteLine($"O valor de sua compra de maçãs é: R${maca_compradas * valor}");
            Console.ReadKey();
        }
    }
}
