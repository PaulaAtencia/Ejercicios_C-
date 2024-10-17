using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructurasIterativas
{
    internal class Ejercicio8
    {
        public static void ejercicio8()
        {
            Random random = new Random();
            Console.WriteLine($"Número aleatorio entre 10 y 30: {random.Next(10,31)}");
        }
    }
}
