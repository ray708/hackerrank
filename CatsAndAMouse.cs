using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank
{
    internal class CatsAndAMouse
    {
        public static string catAndMouse(int x, int y, int z) {

            int catA = Math.Abs(z-x);
            int catB = Math.Abs(z-y);
            if (catA < catB)  return string.Format("Cat A");
            if (catA > catB)  return string.Format("Cat B");
            if (catA == catB) return "Mouse C";
            return "";
        }
    }
}
