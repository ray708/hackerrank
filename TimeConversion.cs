using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank
{
    class TimeConversion
    {
        public static string Conversion(string time) {

            int hour = int.Parse (time.Substring(0,2));
            string minute = time.Substring(3,2);
            string second = time.Substring(6,2);
            char letter = time[8];

            if (letter == 'A' && hour == 12)  hour = 0;
            
            if (letter == 'P' && hour !=12) hour += 12;

            if (hour < 10) return string.Format("0{0}:{1}:{2}", hour, minute, second);
            else return string.Format("{0}:{1}:{2}", hour, minute, second);

        }
    }
}
