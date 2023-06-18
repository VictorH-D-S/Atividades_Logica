using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Logica_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 10) Ler 3 valores (considere que não serão informados valores iguais) e escrever a soma 
                   dos 2 maiores.
             */

            float val1, val2, val3, soma;

            Console.Write("Insira o primeiro valor: ");
            val1 = float.Parse (Console.ReadLine());
            Console.Write("Insira o segundo valor: ");
            val2 = float.Parse (Console.ReadLine());
            Console.Write("Insira o terceiro valor: ");
            val3 = float.Parse (Console.ReadLine());


            //SE VALOR 1 E VALOR 2 SEREM OS MAIORES

            if (val1 > val2 && val1 > val3)
            {

                if (val2 > val3)
                {

                    soma = val1 + val2;
                    Console.WriteLine($"A soma dos números {val1} + {val2} é igual a -> {soma}");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    return;

                }

            }


            //SE VALOR 1 E VALOR 3 SEREM OS MAIORES

            if (val1 > val3 && val1 > val2)
            {

                if (val3 > val2)
                {

                    soma = val1 + val3;
                    Console.WriteLine($"A soma dos números {val1} + {val3} é igual a -> {soma} <-");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    return;


                }

            }

            //SE VALOR 2 E VALOR 1 SEREM OS MAIORES

            if (val2 > val1 && val2 > val3)
            {

                if(val1 > val3)
                {   

                    soma = val2 + val1;
                    Console.WriteLine($"A soma dos números {val2} + {val1} é igual a -> {soma}");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    return;

                }

            }

            //SE VALOR 2 E VALOR 3 SEREM OS MAIORES

            if (val2 > val1 && val2 > val3)
            {

                if (val3 > val1)
                {

                    soma = val2 + val3;
                    Console.WriteLine($"A soma dos números {val2} + {val3} é igual a -> {soma}");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    return;

                }

            }

            //SE VALOR 3 E VALOR 1 SEREM OS MAIORES

            if(val3 > val1 && val3 > val2)
            {

                if (val1 > val2)
                {

                    soma = val3 + val1;
                    Console.WriteLine($"A soma dos números {val3} + {val1} é igual a -> {soma}");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    return;

                }

            }

            //SE VALOR 3 E 2 SEREM OS MAIORES

            if (val3 > val1 && val3 > val2)
            {

                if (val2 > val1)
                {

                    soma = val3 + val2;
                    Console.WriteLine($"A soma dos números {val3} + {val2} é igual a -> {soma}");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    return;

                }

            }

            else 
            { 
                Console.WriteLine("Valores inválidos");
                Console.ReadKey();
                Console.Clear ();
                Main(args);
                return;
            }
        }
    }
}
