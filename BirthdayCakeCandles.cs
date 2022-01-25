using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank
{
    class BirthdayCakeCandles
    {
        public static int Candles(List<int> candles) {

            candles.Sort();
            int lastItem = candles.Count - 1;
            int numberOfCandles = 1;
            int maxNumber = candles[lastItem];

            for (int i = lastItem-1; i >=0; i--)
            {
                if (candles[i] == maxNumber)
                { 
                  numberOfCandles++;
                  continue;
                }
                break; 
            }

            return numberOfCandles;
        }
    }
}
