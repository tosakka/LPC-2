using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_1
{
    internal class fMixta
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convertir fracción mixta a fracción común, así: x x/x");
            Console.WriteLine("Ingrese la fracción mixta (entero y fracción separados por un espacio):");
            string input = Console.ReadLine();

            // Separar la fracción mixta en entero y fracción
            string[] parts = input.Split(' ');
            int whole = int.Parse(parts[0]);
            int numerator = int.Parse(parts[1].Split('/')[0]);
            int denominator = int.Parse(parts[1].Split('/')[1]);

            // Convertir la fracción mixta a fracción común
            numerator = whole * denominator + numerator;
            Console.WriteLine("Fracción común: " + numerator + "/" + denominator);
            Console.ReadLine();
        }
    }
}
