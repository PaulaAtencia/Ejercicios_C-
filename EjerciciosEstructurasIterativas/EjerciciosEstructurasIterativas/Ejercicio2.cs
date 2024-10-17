using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructurasIterativas
{
    internal class Ejercicio2
    {
        public static void ejercicio2()
        {
            Console.Write("Introduce la cantidad de Kw consumidos: ");
            double kw = Convert.ToDouble(Console.ReadLine());

            double precio;
            if (kw < 1000)
            {
                precio = 0.14;
            }
            else if(kw <= 1800)
            {
                precio = 0.12;
            }
            else
            {
                precio = 0.8;
            }

            Console.WriteLine($"Total a pagar: {precio * kw} euros (el precio por kw es {precio})");
        }
    }
}
