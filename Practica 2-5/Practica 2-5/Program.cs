using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determina si una cadena de texto es un pálindromo.");
            Console.Write("Ingrese una cadena de texto: ");
            string input = Console.ReadLine();

            input = input.Replace(" ", "");
            input = input.ToLower();

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reverse = new string(charArray);

            if (input == reverse)
            {
                Console.WriteLine("La cadena de texto es un pálindromo.");
            }
            else
            {
                Console.WriteLine("La cadena de texto no es un pálindromo.");
            }
            Console.ReadLine();
        }
    }
}
