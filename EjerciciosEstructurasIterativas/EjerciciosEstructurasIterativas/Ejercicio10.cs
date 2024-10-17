using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructurasIterativas
{
    internal class Ejercicio10
    {
        public static void ejercicio10()
        {
            int[] lista = { 44, 21, 60, 6, -32, 99, -26, 0, 180, -2 };

            Array.Sort(lista);

            Console.Write("Lista ordenada: [ ");
            for (int i= 0; i < lista.Length; i++)
            {
                Console.Write(lista[i]);
                if(i != lista.Length - 1) Console.Write(", ");
            }
            Console.WriteLine(" ]");
        }
    }
}
