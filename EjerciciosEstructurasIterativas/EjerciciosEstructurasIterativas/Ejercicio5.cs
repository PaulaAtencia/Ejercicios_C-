using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructurasIterativas
{
    internal class Ejercicio5
    {
        public static void ejercicio5()
        {
            Console.Write("Introduce una cadena de texto: ");
            string text = Console.ReadLine();

            Console.WriteLine($"Longitud: {text.Length}");

            Console.WriteLine($"Contiene la subcadena 'hola': {text.Contains("hola")}");

            Console.WriteLine($"Reemplazo de todas las 'a' por 'o': {text.Replace("a","o")}");

            Console.WriteLine($"Todo a mayúsculas: {text.ToUpper()}");

            Console.WriteLine($"Todo a minúsculas: {text.ToLower()}");

            Console.WriteLine($"Eliminamos carácter de la posición 2: {text.Remove(2,1)}");

            Console.WriteLine($"Substring desde la posición 1 a la 4: {text.Substring(1,4)}");
        }
    }
}
