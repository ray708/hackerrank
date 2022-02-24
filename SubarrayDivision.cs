using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hackerrank
{
    internal class SubarrayDivision
    {

        public static int NumberOfSegments(List<int> s, int d, int m) 
        {
            int segments = 0;
            var range1 = 0;
            var range2 = 0;
      
           
            for (int i = 0; i < s.Count; i++)
            {

                range1 = m;
                range2 = ((s.Count)-i);
                if ( range1 > range2) { return segments; }

                else
                {
                    var subList = s.GetRange(i, m);
                    if (subList.Sum() == d) { segments++; }
                }
                    
            }

            return segments;
        }
    }
}
