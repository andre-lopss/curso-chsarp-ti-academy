using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Position {i}: {i}");
            }
            Console.WriteLine("===========================");

            int acumulador = 0;
            int numero = 1;
            Console.WriteLine($"Digite os valores e quando desejar somar eles digite o número '0'.");
            while (numero != 0)
            {
                numero = Convert.ToInt32(Console.ReadLine());
                acumulador = acumulador + numero;
            }

            Console.WriteLine($"A soma dos números é: {acumulador}");

            Console.ReadLine();
        }
    }
}
