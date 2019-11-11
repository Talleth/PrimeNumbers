using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    public class PrimeNumbersSieve
    {
        public static List<int> CalculateFromRange(int start, int end)
        {
            List<int> result = new List<int>();

            // Nothing less than 2 is prime
            if (start <= 1)
                start = 2;

            // Initialize list to sieve
            for (int i = start; i <= end; i++)
                result.Add(i);

            // Loop through every int again and start sieving
            for (int i=start; i<=end; i++)
            {
                if (result.Contains(i))
                {
                    for (int j = i; j <= end; j += i)
                    {
                        result.Remove(j + i);
                    }
                }
            }

            return result;
        }
    }
}
