using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            // Ingresamos nuestro nombre
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("\n" + nombre + ", Bienvenido al curso de Fundamentos de algoritmos");
            Console.ReadKey();
            Console.WriteLine("Fabrizio\n18\nIng.Sistemas");
            Console.ReadLine();
        }
        static void ejercicio02()
        {
            Console.WriteLine("Fabrizio\n18\nIng.Sistemas");
            Console.ReadKey();
        }
       static void ejercicio03()
        {
            int num1, num2;

            Console.WriteLine("Ingrese el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("La suma es: " + (num1 + num2));
            Console.WriteLine("La resta es: " + (num1 - num2));
            Console.WriteLine("La multiplicación es: " + (num1 * num2));
            Console.WriteLine("La división es: " + (num1 / num2));
            Console.WriteLine("El módulo es: " + (num1 % num2));

            Console.ReadKey();

        }
    }
    
}
