using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejercicio2
    {
        public static void ejercicio2()
        {
            const double precio_hamburguesa = 8,
                precio_bebida = 2,
                precio_papa = 4;

            Console.Write("Cantidad de hamburguesas: ");
            int hamburguesas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cantidad de bebidas: ");
            int bebidas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cantidad de papas: ");
            int papas = Convert.ToInt32(Console.ReadLine());

            double total = hamburguesas * precio_hamburguesa + bebidas * precio_bebida + papas * precio_papa;
            Console.WriteLine("Cantidad a pagar: " + total + "$");
        }
    }
}
