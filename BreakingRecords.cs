using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank
{
    internal class BreakingRecords
    {
        public static List<int> Records(List<int> scores) {

            int max = scores[0];
            int min = scores[0];
            int breakMax = 0;
            int breakMin = 0;
            

            for (int i = 1; i < scores.Count; i++)
            {
                int record = scores[i];
                if (record > max) {
                    breakMax++;
                    max = record;
                }
                if (record < min) {

                    breakMin++;
                    min = record;
                }

            }

            return new List<int>() { breakMax, breakMin };
        }
    }
}
