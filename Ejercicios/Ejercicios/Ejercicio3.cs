using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejercicio3
    {
        public static void ejercicio3()
        {
            Console.Write("Introduce un número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor absoluto: " + Math.Abs(num));

            Console.WriteLine("Potencia al cubo: " + Math.Pow(num,3));

            Console.WriteLine("Raíz cuadrada: " + Math.Sqrt(num));

            Console.WriteLine("Seno: " + Math.Sin(num));

            Console.WriteLine("Coseno: " + Math.Cos(num));

            Console.WriteLine("Número máximo entre 8 y " + num + ": " + Math.Max(num,8));

            Console.WriteLine("Número mínimo entre 9 y " + num + ": " + Math.Min(num,9));
        }
    }
}
