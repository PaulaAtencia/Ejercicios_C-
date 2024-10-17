using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructurasIterativas
{
    internal class Ejercicio4
    {
        public static void ejercicio4()
        {
            Console.Write("Introduce un número del 1 al 9: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0 && num < 10)
            {
                Console.WriteLine($"Tabla del {num}");
                for(int i=1; i<=10; i++)
                {
                    Console.WriteLine($"{num} * {i} = {num * i}");
                }
            }
            else
                Console.WriteLine("No se introdujo un número correcto");
        }
    }
}
