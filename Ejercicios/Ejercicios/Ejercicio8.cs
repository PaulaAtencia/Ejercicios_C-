using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Ejercicio8
    {
        public static void ejercicio8()
        {
            Console.Write("Introduce nota de primer parcial: ");
            double nota_parcial1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce nota de segundo parcial: ");
            double nota_parcial2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce nota de examen final: ");
            double nota_examen_final = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce nota trabajo final: ");
            double nota_trabajo_final = Convert.ToDouble(Console.ReadLine());

            double nota_final = nota_trabajo_final * 0.2 + nota_examen_final * 0.3 + ((nota_parcial1 + nota_parcial2) / 2) * 0.5;
            Console.WriteLine("Nota final en Interfaces de Usuario es: " + nota_final);
        }
    }
}
