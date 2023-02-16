using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resolver sumas o diferencias de cubos.");
            Console.WriteLine("Por favor, ingrese dos números para operar:");

            Console.Write("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Qué operación desea realizar?");
            Console.WriteLine("1. Suma de cubos");
            Console.WriteLine("2. Diferencia de cubos");
            Console.Write("Ingrese el número de la operación: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                int sum = (num1 * num1 * num1) + (num2 * num2 * num2);
                Console.WriteLine("El resultado de la suma de cubos es: " + sum);
            }
            else if (choice == 2)
            {
                int difference = (num1 * num1 * num1) - (num2 * num2 * num2);
                Console.WriteLine("El resultado de la diferencia de cubos es: " + difference);
            }
            else
            {
                Console.WriteLine("Opción inválida. Por favor, intente de nuevo.");
            }
            Console.ReadLine();
        }
    }
}
