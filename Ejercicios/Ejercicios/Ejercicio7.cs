using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejercicio7
    {
        public static void ejercicio7()
        {
            Console.Write("Introduce precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce cantidad que tiene el cliente: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Coste total: " + (precio * cantidad));
        }
    }
}
