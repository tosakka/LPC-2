using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Torre de Hanoi");
            Console.Write("Ingrese el número de discos: ");
            int n = int.Parse(Console.ReadLine());
            hanoi(n, 'A', 'C', 'B');
            Console.ReadLine();
        }

        static void hanoi(int n, char origen, char destino, char intermedio)
        {
            if (n == 1)
            {
                Console.WriteLine("Mover disco 1 desde " + origen + " hasta " + destino);
            }
            else
            {
                hanoi(n - 1, origen, intermedio, destino);
                Console.WriteLine("Mover disco " + n + " desde " + origen + " hasta " + destino);
                hanoi(n - 1, intermedio, destino, origen);
            }
        }
    }
}
