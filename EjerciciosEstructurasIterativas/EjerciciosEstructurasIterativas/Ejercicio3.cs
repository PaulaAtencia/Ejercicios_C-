using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosEstructurasIterativas
{
    internal class Ejercicio3
    {
        public static void ejercicio3()
        {
            Console.Write("Introduce la inicial de su estado civil (S, C, D o V): ");
            string inicial_estado = Console.ReadLine();

            string estado_civil = "";
            bool input_correcto = true;
            switch (inicial_estado)
            {
                case "S":
                    estado_civil = "Solter@";
                    break;

                case "C":
                    estado_civil = "Casad@";
                    break;

                case "D":
                    estado_civil = "Divorciad@";
                    break;

                case "V":
                    estado_civil = "Viud@";
                    break;

                default:
                    Console.WriteLine("No se ha introducido ninguna inicial correcta.");
                    input_correcto = false;
                    break;
            }

            if(input_correcto) 
                Console.WriteLine($"Tu estado civil es {estado_civil}");
        }
    }
}
