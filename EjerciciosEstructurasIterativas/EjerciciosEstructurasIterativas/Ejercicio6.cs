using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructurasIterativas
{
    internal class Ejercicio6
    {
        public static void ejercicio6()
        {
            Console.Write("Introduce un número positivo: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine($"No existe el factorial de {num}");
            }
            else if(num == 0)
            {
                Console.WriteLine("El factorial de 0 es 1");
            }
            else
            {
                Console.WriteLine($"Factorial de {num}: ");

                double res = 1;
                for(int i=num; i>0; i--)
                {
                    res *= i;
                    Console.Write($"{i}");
                    if (i > 1) Console.Write(" * ");
                }
                Console.WriteLine($" = {res}");
            }
        }
    }
}
