using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejercicio4
    {
        public static void ejercicio4()
        {
            Console.Write("Introduzca el valor de un lado del cuadrado: ");
            int lado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Perímetro del cuadrado: " + (4 * lado));
        }
    }
}
