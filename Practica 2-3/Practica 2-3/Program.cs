using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo del Maximo comun divisor y el minimo comun multiplo");
            Console.WriteLine("Ingrese dos numeros enteros:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int mcd = CalcularMCD(a, b);
            int mcm = CalcularMCM(a, b, mcd);

            Console.WriteLine("MCD: " + mcd);
            Console.WriteLine("MCM: " + mcm);
            Console.ReadLine();
        }

        static int CalcularMCD(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return CalcularMCD(b, a % b);
        }

        static int CalcularMCM(int a, int b, int mcd)
        {
            return (a * b) / mcd;
        }
    }
}
