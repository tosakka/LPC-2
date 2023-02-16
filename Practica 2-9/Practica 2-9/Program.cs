using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcula la cantidad de semanas entre dos fechas.");
            Console.Write("Ingrese la primera fecha (dd/mm/yyyy): ");
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            Console.Write("Ingrese la segunda fecha (dd/mm/yyyy): ");
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            TimeSpan difference = secondDate - firstDate;
            int weeks = (int)Math.Floor(difference.TotalDays / 7);

            Console.WriteLine("Hay " + weeks + " semanas entre " + firstDate.ToShortDateString() + " y " + secondDate.ToShortDateString());
            Console.ReadLine();
        }
    }
}
