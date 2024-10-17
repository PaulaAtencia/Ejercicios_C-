using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructurasIterativas
{
    internal class Ejercicio1
    {
        public static void ejercicio1()
        {
            Console.Write("Introduce un número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce otro número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El número mayor entre {num1} y {num2} es {Math.Max(num1,num2)}");
        }
    }
}
