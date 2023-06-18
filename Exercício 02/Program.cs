using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Logica_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            2) Escreva um algoritmo para ler o salário mensal atual de um funcionário e o percentual 
            de reajuste. Calcular e escrever o valor do novo salário. 
            */

            float salario_atual, reajuste, valor_reajuste, salario_novo;

            Console.WriteLine("Insira o salário atual: ");
            salario_atual = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor do reajuste: ");
            reajuste = float.Parse(Console.ReadLine());

            valor_reajuste = salario_atual * reajuste/100;
            salario_novo = salario_atual + valor_reajuste;

            Console.WriteLine($"Valor do novo Salario: R${salario_novo}.");

            Console.ReadKey();
        }
    }
}
