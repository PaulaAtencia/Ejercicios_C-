using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejercicio6
    {
        public static void ejercicio6()
        {
            Console.WriteLine("Introduce 4 números: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());

            int total = num1 + num2 + num3 + num4;
            Console.WriteLine("Suma total: " + total);
            Console.WriteLine("Promedio: " + (total / 4));
        }
    }
}
