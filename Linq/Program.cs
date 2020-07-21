using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };
            var media = numbers.Average(x => x);
            var max = numbers.Max(x => x);
            var min = numbers.Min(x => x);

            Console.WriteLine("La media de los números es {0}\nCon un máximo de {1}\nY un mínimo de {2}",media,max,min);

     
        }
    }
}
