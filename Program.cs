using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    public class Program
    {
        public static void Main(string[] arguments)
        {
            // Example 1 - Basic:
            // From 1 - 20
            // Result: 2, 3, 5, 7, 11, 13, 17, 19
            Console.WriteLine("1 - 20");
            Console.WriteLine(string.Join(",", PrimeNumbersBasic.CalculateFromRange(1, 20)));
            Console.WriteLine();

            // Example 2 - Basic:
            // From 10 - 50
            // Result: 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47
            Console.WriteLine("10 - 50");
            Console.WriteLine(string.Join(",", PrimeNumbersBasic.CalculateFromRange(10, 50)));
            Console.WriteLine();

            // Example 3 - Basic:
            // From 1000 - 1050
            // Result: 1,009, 1,013, 1,019, 1,021, 1,031, 1,033, 1,039, 1,049
            Console.WriteLine("1000 - 1050");
            Console.WriteLine(string.Join(",", PrimeNumbersBasic.CalculateFromRange(1000, 1050)));
            Console.WriteLine();

            // Example 1 - Sieve:
            // From 1 - 120
            // Result: 2, 3, 5, 7, 11, 13, 17, 19, 23, 29,31, 37, 41, 43, 47, 53, 59, 61, 67, 71,73, 79, 83, 89, 97, 101, 103, 107, 109, 113
            Console.WriteLine("1 - 120");
            Console.WriteLine(string.Join(",", PrimeNumbersSieve.CalculateFromRange(1, 120)));
            Console.WriteLine();

            // Example 2 - Sieve:
            // From 10 - 50
            // Result: 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47
            Console.WriteLine("10 - 50");
            Console.WriteLine(string.Join(",", PrimeNumbersSieve.CalculateFromRange(10, 50)));
            Console.WriteLine();
        }
    }
}
