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
            ejercicio08();
                Console.ReadKey();
        }
            static void ejercicio01()
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

        }

        static void ejercicio04()
        {
            Console.WriteLine("\"Fabrizio\"");
        }
        static void ejercicio05()
        {
            
            int bas, alt;
            double área;

            Console.Write("Ingrese un número a la base: ");
            bas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese un número a la altura: ");
            alt = Convert.ToInt32(Console.ReadLine());
            área = (bas * alt) / 2;
            Console.WriteLine("\nEl área de un triángulo es: " + área);
        }
        static void ejercicio06()
        {
            double num1, num2, num3, promedio;

            Console.Write("Ingrese el primer número: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el tercer número: ");
            num3 = Convert.ToDouble(Console.ReadLine());

            promedio = (num1 + num2 + num3) / 3;
            Console.WriteLine($"El promedio es: {promedio:F2}");
        }
            static void ejercicio07()
            {
                // Pide el radio de un círculo y calcula  área usando la fórmula: área = π * radio².
                double radio, área;

                Console.Write("Ingrese el radio: ");
                radio = Convert.ToDouble(Console.ReadLine());

                área = Math.PI * Math.Pow(radio, 2);
                Console.WriteLine($"\nEl área del círculo es: {área}");

            }
        static void ejercicio08()
        {
            // Solicita un número decimal y muestra: La raíz cuadrada y su potencia a 3.
            double numdec, raizcuadrada, potentres;

            Console.Write("Ingrese un número decimal: ");
            numdec = Convert.ToDouble(Console.ReadLine());

            raizcuadrada = Math.Sqrt(numdec);

            potentres = Math.Pow(numdec, 3);

            Console.WriteLine($"\nLa raíz cuadrada es: {raizcuadrada}");
            Console.WriteLine($"La potencia a 3 es {potentres}");
        }

    }
    
}
