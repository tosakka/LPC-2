using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ordenamiento por burbuja");
            Console.Write("Ingrese el tamaño del arreglo: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(1, 100);
            }

            Console.WriteLine("Arreglo original: ");
            printArray(arr);

            Console.WriteLine("Arreglo ordenado de manera descendente: ");
            bubbleSortDescending(arr);
            printArray(arr);

            Console.WriteLine("Arreglo ordenado de manera ascendente: ");
            bubbleSortAscending(arr);
            printArray(arr);
            Console.ReadLine();
        }

        static void bubbleSortDescending(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void bubbleSortAscending(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
