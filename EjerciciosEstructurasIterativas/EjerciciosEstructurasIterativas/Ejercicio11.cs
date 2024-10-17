using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructurasIterativas
{
    internal class Ejercicio11
    {
        public static void ejercicio11()
        {
            Stack<int> pila = new Stack<int>();

            int num;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Introduce valor {i} en la pila: ");
                num = Convert.ToInt32( Console.ReadLine() );
                pila.Push( num );
            }

            Console.WriteLine($"Pila: {string.Join(", ", pila)}");

            // Quitamos los dos valores
            pila.Pop();
            pila.Pop();

            Console.WriteLine($"Pila tras sacar dos valores: {string.Join(", ", pila)}");
        }
    }
}
