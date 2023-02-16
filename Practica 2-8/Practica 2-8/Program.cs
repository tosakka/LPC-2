using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determinar si un año es bisiesto o no.");
            Console.Write("Ingrese un año: ");
            int year = int.Parse(Console.ReadLine());

            bool isLeapYear = false;
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        isLeapYear = true;
                    }
                }
                else
                {
                    isLeapYear = true;
                }
            }

            if (isLeapYear)
            {
                Console.WriteLine(year + " es un año bisiesto.");
            }
            else
            {
                Console.WriteLine(year + " no es un año bisiesto.");
            }

            Console.ReadLine();
        }
    }
}
