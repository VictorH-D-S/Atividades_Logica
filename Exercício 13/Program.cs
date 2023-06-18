using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Logica_13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Algoritimo para a tabuada do 8

            
            int tabuda_do_8;
            for (int i = 1; i < 11; i++)
            {
                tabuda_do_8 = 8 * i;
                Console.WriteLine($"8 x {i} = {tabuda_do_8}");

            }

            Console.ReadKey();
        }
    }
}
