using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la tombola.");

            Random random = new Random();

            int[] numbers = new int[3];
            for (int i = 0; i < 3; i++)
            {
                numbers[i] = random.Next(1, 100);
            }

            Console.WriteLine("Sus números son: " + numbers[0] + ", " + numbers[1] + ", " + numbers[2]);
            Console.ReadLine();
        }
    }
}
