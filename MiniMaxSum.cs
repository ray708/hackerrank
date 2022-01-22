using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class MiniMaxSum
    {
        public static void Calculo(List<int> lista) {

            long minimaSuma;
            long maximaSuma;
            long sumaTotal=0;
            int maximo = lista.Max();
            int minimo = lista.Min();
            foreach (var item in lista)
            {
                 sumaTotal += item;
            }
            maximaSuma = sumaTotal - minimo;
            minimaSuma = sumaTotal - maximo;
            Console.Write( "{0} {1}",minimaSuma, maximaSuma);

        }
    }
}
