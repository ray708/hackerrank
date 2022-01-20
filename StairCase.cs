using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank
{
    
    public class StairCase
    {

        public static void DrawingStairCase(int escalones) {

            string altura = "";
            for (int i = 0; i < escalones; i++)
            {
                altura += "#";
                string escalera = altura.PadLeft(escalones);
                Console.WriteLine(escalera);
            }

        }
        
}
}
