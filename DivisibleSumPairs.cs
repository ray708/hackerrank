using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank
{
    internal class DivisibleSumPairs
    {
        public static int divisibleSumpairs(int n, int k, List<int> ar) 
        {
            var count = 0;

            for (int i = 0; i < ar.Count; i++)
            {
                for (int j = i+1; j < ar.Count; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0) count++;
                }

            }

            
            return count;
        }
    }
}
