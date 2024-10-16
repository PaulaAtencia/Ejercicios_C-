using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejercicio9
    {
        public static void ejercicio9()
        {
            Console.Write("Introduce cantidad que aporta socio 1: ");
            double socio1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce cantidad que aporta socio 2: ");
            double socio2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce cantidad que aporta socio 3: ");
            double socio3 = Convert.ToDouble(Console.ReadLine());

            double total = socio1 + socio2 + socio3;

            Console.Write($"El porcentaje del socio 1 es {Math.Round(socio1 * 100 / total, 3)}%, ");
            Console.Write($"el porcentaje del socio 2 es {Math.Round(socio2 * 100 / total, 3)}%, ");
            Console.WriteLine($"el porcentaje del socio 3 es {Math.Round(socio3 * 100 / total, 3)}%");
        }
    }
}
