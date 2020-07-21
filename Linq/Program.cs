using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };
            var mas5 = numbers.Where(x => x > 5).ToList();
            var menos5 = numbers.Where(x => x < 5).ToList();

            Console.WriteLine("Mayores de 5 :");
            foreach (var nota in mas5)
            {
                Console.WriteLine(nota);
            }
            Console.WriteLine("Menores de 5 :");
            foreach (var nota in menos5)
            {
                Console.WriteLine(nota);
            }


        }
    }
}
