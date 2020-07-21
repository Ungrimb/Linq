using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };
            var pares = numbers.Where(x => x % 2 == 0).ToList();

            foreach (var n in pares)
            {
                Console.WriteLine(n);
            }
        }
    }
}
