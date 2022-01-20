using System;
using System.Collections.Generic;

namespace Hackerrank
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 10;
            string bases = "";
            for (int i = 0; i < numero; i++)
            {
                bases += "#";
                string valor = bases.PadLeft(numero);
                Console.WriteLine(valor);
            }
            
        }

    }
}
