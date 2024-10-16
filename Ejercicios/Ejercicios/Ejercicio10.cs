using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejercicio10
    {
        public static void ejercicio10()
        {
            Console.Write("Introduce cadena de texto: ");
            string cadena = Console.ReadLine();

            Console.WriteLine($"La cadena empieza por 'www': {cadena.StartsWith("www")}");
        }
    }
}
