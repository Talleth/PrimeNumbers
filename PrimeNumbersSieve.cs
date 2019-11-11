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

            // Initialize list to sieve
            for (int i = 2; i <= end; i++)
                result.Add(i);

            // Loop through every int again and start sieving
            for (int i=2; i<=end; i++)
            {
                if (result.Contains(i))
                {
                    for (int j = i; j <= end; j += i)
                    {
                        result.Remove(j + i);
                    }
                }
            }

            return result.Where(x => x >= start).ToList();
        }
    }
}
