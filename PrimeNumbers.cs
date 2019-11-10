using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    public class PrimeNumbers
    {
        // Worse Time Complexity O(sqrt(n))
        // Average Time Complexity O(sqrt(n) / log n)
        public static bool IsPrimeNumber(int number)
        {
            bool result = true;

            for (int i=2; i<number; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        // Time Complexity O(sqrt(n) * n)
        public static List<int> CalculateFromRange(int start, int end)
        {
            List<int> result = new List<int>();

            if (start <= 1)
                start = 2;

            for (int i=start; i<=end; i++)
            {
                if (PrimeNumbers.IsPrimeNumber(i))
                    result.Add(i);
            }

            return result;
        }
    }
}
