using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class GradingStudents
    {

        public static List<int> Grading(List<int> lista) {

            for (int i = 0; i < lista.Count ; i++)
            {
                int numero = lista.ElementAt(i);

                if (numero > 37)
                {
                    if ((numero + 1) % 5 == 0) lista[i] = numero + 1;
                    if ((numero + 2) % 5 == 0) lista[i] = numero + 2;
                };

            }

            return lista;
        
        }
    }
}
