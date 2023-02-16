using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_2
{
    internal class numPrimo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimir números primos entre un numero inicial hasta uno final.");
            Console.WriteLine("Ingrese el número inicial:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número final:");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("Números primos entre " + start + " y " + end + ":");
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }

        static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;

        }

    }

}
