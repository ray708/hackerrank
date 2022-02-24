using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank
{
    internal class PlusMinus
    {
        public static void ReturnPlusMinus(List<int> arr) {

          List<int> listPositiveElements = arr.FindAll(x => x > 0);
          List<int> listNegativeElements = arr.FindAll(x => x < 0);
          List<int> listZeroElements = arr.FindAll(x => x == 0);

          decimal positive = Convert.ToDecimal(listPositiveElements.Count) / arr.Count;
          decimal negative = Convert.ToDecimal(listNegativeElements.Count) / arr.Count;
          decimal zero = Convert.ToDecimal(listZeroElements.Count) / arr.Count;

          Console.WriteLine(positive.ToString("0.000000"));
          Console.WriteLine(negative.ToString("0.000000"));    
          Console.WriteLine(zero.ToString("0.000000"));
        }
    }
}
