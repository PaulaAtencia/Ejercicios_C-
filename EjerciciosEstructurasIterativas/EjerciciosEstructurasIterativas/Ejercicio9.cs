using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructurasIterativas
{
    internal class Ejercicio9
    {
        public static void ejercicio9()
        {
            Console.Write("Indica el tamaño del array (número positivo): ");
            int size = Convert.ToInt32(Console.ReadLine());

            if (size > 0)
            {
                int[] array = new int[size];

                for(int i=0; i<size; i++)
                {
                    Console.Write($"Introduce valor {i+1} de la lista: ");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                List<int> pares = new List<int>();
                List<int> impares = new List<int>();

                foreach (int i in array)
                {
                    if(i % 2 == 0) pares.Add(i);
                    else impares.Add(i);
                }

                Console.WriteLine($"Número pares: {string.Join(", ", pares)}");
                Console.WriteLine($"Números impares: {string.Join(", ", impares)}");
            }
            else
                Console.WriteLine("No se introdujo un valor correcto");
        }
    }
}
