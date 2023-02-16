using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Invierte el sentido de las letras en una palabra.");
            Console.Write("Ingrese una palabra: ");
            string input = Console.ReadLine();

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);

            Console.WriteLine("La palabra invertida es: " + reversed);
            Console.ReadLine();
        }
    }
}
