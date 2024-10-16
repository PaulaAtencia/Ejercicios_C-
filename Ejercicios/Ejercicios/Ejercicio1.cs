using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejercicio1
    {
        public static void ejercicio1()
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La suma es " + (num1 + num2));

            Console.WriteLine("La resta es: " + num1 + " - " + num2 + " = " + (num1 - num2)); 
            
            Console.WriteLine("La multiplicación es: " + (num1 * num2));

            Console.WriteLine("La división es: " + (num1 / num2));

            Console.WriteLine("El módulo es: " + (num1 % num2));
        }
    }
}
