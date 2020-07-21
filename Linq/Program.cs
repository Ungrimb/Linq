using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol" };
            var namesWithO = names.Where(x => x.StartsWith("O"));
            Console.WriteLine("Empiezan por O :");
            foreach (var n in namesWithO)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\nNúmero de letras > 6 :");
            var namesWith6 = names.Where(x => x.ToString().Length > 6);
            foreach (var n in namesWith6)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\nOrden descendente :");
            var namesDescentOrder = names.OrderByDescending(x => x);
            foreach (var n in namesDescentOrder)
            {
                Console.WriteLine(n);
            }
        }
    }
}
