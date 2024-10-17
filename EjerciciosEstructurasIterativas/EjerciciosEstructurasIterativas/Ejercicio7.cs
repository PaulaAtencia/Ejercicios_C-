using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructurasIterativas
{
    internal class Ejercicio7
    {
        public static void ejercicio7()
        {
            Console.WriteLine("Abecedario inverso:");
            for(int i = 90; i >= 65; i--)
            {
                Console.Write($"{Convert.ToChar(i)} ");
            }
            Console.WriteLine();
        }
    }
}

// No es ToString, se necesita usar ToChar para pasar el valor númerico a ASCII