﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Logica_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 11) Ler 3 valores (considere que não serão informados valores iguais) e escrevê-los em 
                ordem crescente.
             */

            float val1, val2, val3;

            Console.Write("Insira o primeiro valor: ");
            val1 = float.Parse(Console.ReadLine());
            Console.Write("Insira o segundo valor: ");
            val2 = float.Parse(Console.ReadLine());
            Console.Write("Insira o terceiro valor: ");
            val3 = float.Parse(Console.ReadLine());


            //SE VALOR 1 E VALOR 2 SEREM OS MAIORES

            if (val1 > val2 && val1 > val3)
            {

                if (val2 > val3)
                {

                    Console.WriteLine($"Os números em ordem crescente ficam: {val3} -> {val2} -> {val1}");
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

                    Console.WriteLine($"Os números em ordem crescente ficam: {val2} -> {val3} -> {val1}");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    return;


                }

            }

            //SE VALOR 2 E VALOR 1 SEREM OS MAIORES

            if (val2 > val1 && val2 > val3)
            {

                if (val1 > val3)
                {

                    Console.WriteLine($"Os números em ordem crescente ficam: {val3} -> {val1} -> {val2}");
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

                    Console.WriteLine($"Os números em ordem crescente ficam: {val1} -> {val3} -> {val2}");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    return;

                }

            }

            //SE VALOR 3 E VALOR 1 SEREM OS MAIORES

            if (val3 > val1 && val3 > val2)
            {

                if (val1 > val2)
                {

                    Console.WriteLine($"Os números em ordem crescente ficam: {val2} -> {val1} -> {val3}");
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

                    Console.WriteLine($"Os números em ordem crescente ficam: {val1} -> {val2} -> {val3}");
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
                Console.Clear();
                Main(args);
                return;
            }
        }
    }
}
