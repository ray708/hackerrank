using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class AppleAndOrange
    {

        public static void Calculate(int s, int t, int a, int b, List<int> apples, List<int> oranges) { 
        

            int appleCount = 0;
            int orangeCount = 0;

            foreach (var item in apples)
            {
                int item1 = a + item;
                if (item1 <= t  && item1 >= s) appleCount++; 
            }

            foreach (var item in oranges)
            {
                var item2 = b + item;
                if (item2 <= t && item2 >= s) orangeCount++;
            }
             

            Console.WriteLine(appleCount);
            Console.Write(orangeCount);


        }
    }
}
