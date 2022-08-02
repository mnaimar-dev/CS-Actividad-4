// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double suma = 0;
            int counter = 0;

            Console.WriteLine("Introduce la calificación: ");
            suma += Convert.ToDouble(Console.ReadLine());
            counter++;

            Console.WriteLine("Deseas ingresar otra calificación? (y/n): ");
            String respuesta = Console.ReadLine();

            while (respuesta == "y")
            {
                Console.WriteLine("Introduce la calificación: ");
                suma += Convert.ToDouble(Console.ReadLine());
                counter++;
                Console.WriteLine("Deseas ingresar otra calificación? (y/n): ");
                respuesta = Console.ReadLine();
            }

            Console.WriteLine("El promedio es: " + suma / counter);
        }
    }
}



