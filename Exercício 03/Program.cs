using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Logica_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 3) Uma revendedora de carros usados paga a seus funcionários vendedores um salário 
                 fixo por mês, no valor de R$2000,00, mais uma comissão também fixa para cada carro 
                 vendido de R$300,00 e mais 5% do valor das vendas por ele efetuadas. Escrever um 
                 algoritmo que leia o número de carros por ele vendidos, o valor total de suas vendas. 
                 Calcule e escreva o salário final do vendedor.

             */

            float salario_fixo = 2000.00f;
            float curacao = 300.00f;
            float carros_v;
            float total_v;
            float curacao_por;
            float salario_final;
            float curacao_total;

            Console.WriteLine("Insira o valor de carros vendidos: ");
            carros_v = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor total de vendas: ");
            total_v = float.Parse(Console.ReadLine());
            
            curacao_total = curacao * carros_v;
            curacao_por = 0.05f * total_v;
            salario_final = salario_fixo + curacao_total + curacao_por;

            Console.WriteLine($"Salário final: R${salario_final}");

            Console.ReadKey();
        }
    }
}
