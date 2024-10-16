using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejercicio5
    {
        public static void ejercicio5()
        {
            Console.Write("Introduce 4 números: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
            Console.WriteLine(num3 + " * " + num4 + " = " + (num3 * num4));
        }
    }
}
