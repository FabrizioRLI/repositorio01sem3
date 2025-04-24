using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejercicio06();
            Console.ReadKey();
        }
        static void ejercicio01()
        {
            int num1;

            Console.Write("Ingrese un número entero: ");
            num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("El número es par");
            }
            else
            {
                Console.WriteLine("\nEl número es impar");
            }


        }
        static void ejercicio02()
        {
            int edad;

            Console.Write("Ingrese una edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad < 0)
            {
                Console.WriteLine("\nEdad inválida");
            }
            else
            {


                if (edad < 18)
                {
                    Console.WriteLine("\nEs menor de edad");
                }
                else
                {
                    Console.WriteLine("\nEs mayor de edad");
                }
            }
        }
        static void ejercicio03()
        {
            double sueldobase, sueldoM, sueldoJ, sueldoP, sueldoT;
            Console.Write("Ingrese un sueldo base ficticio: ");
            sueldobase = Convert.ToDouble(Console.ReadLine());
            sueldoM = (sueldobase * 0.95) - 25;
            sueldoJ = (sueldobase * 1.23) + 72;
            sueldoP = (sueldobase * 1.05) - 56;
            sueldoT = (sueldoM + sueldoJ + sueldoP);
            Console.WriteLine($"El sueldo de María es: {sueldoM:F2}");
            Console.WriteLine($"El sueldo de Juan es: {sueldoJ:F2}");
            Console.WriteLine($"El sueldo de Patricio es: {sueldoP:F2}");
            Console.WriteLine($"El sueldo total de todos es: {sueldoT:F2}");
        }
        static void ejercicio04()
        {
            int año;
            Console.Write("Ingrese un año: ");
            año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
            {
                Console.WriteLine($"{año} es un bisiesto.");
            }
            else
            {
                Console.WriteLine($"{año} no es un año bisiesto.");
            }
        }
        static void ejercicio05()
        {
            int opcion;
            double monto, dolares, euros;

            Console.Write("Ingrese el monto en soles (PEN): ");
            monto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n¿A qué moneda desea convertir?");
            Console.WriteLine("\n[1] Dólares (USD)");
            Console.WriteLine("[2] Euros (EUR)");
            Console.Write("\nSeleccione una opción (1 o 2): ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    dolares = monto / 3.75;
                    Console.WriteLine($"\nEl monto en dólares (USD) es: {dolares:F2}");
                    break;
                case 2:
                    euros = monto / 4.05;
                    Console.WriteLine($"\nEl monto en euros (EUR) es: {euros:F2}");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;


            }
        }
        static void ejercicio06()
        {
            int l;
            double area, b, h, r;

            Console.WriteLine("Bienvenido al sistema de calculo de áreas");
            Console.WriteLine("\n[1] Cuadrado");
            Console.WriteLine("[2] Triámgulo");
            Console.WriteLine("[3] Rectángulo");
            Console.WriteLine("[4] Circulo");
            Console.Write("\nElija del 1-4 la figura que quiere resolver su área: ");
            area = Convert.ToDouble(Console.ReadLine());

            switch (area)
            {
                case 1:
                    Console.Write("Ingrese el lado del cuadrado: ");
                    l = Convert.ToInt32(Console.ReadLine());
                    area = Math.Pow(l, 2);
                    Console.WriteLine($"El área del cuadrado es: {area}");
                    break;
                case 2:
                    Console.Write("Ingrese la base del triángulo: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la altura del triángulo: ");
                    h = Convert.ToDouble(Console.ReadLine());
                    area = (b * h) / 2.0;
                    Console.WriteLine($"El área del triángulo es: {area}");
                    break;
                    case 3:
                    Console.Write("Ingrese la base del rectángulo: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la altura del rectángulo: ");
                    h = Convert.ToDouble(Console.ReadLine());
                    area = b * h;
                    Console.WriteLine($"El área del rectángulo es: {area}");
                    break;
                    case 4:
                    Console.Write("Ingrese el radio del circulo: ");
                    r = Convert.ToDouble(Console.ReadLine());
                    area = Math.PI * Math.Pow(r, 2);
                    Console.WriteLine($"El área del circulo es: {area:F2}");
                    break;
                default:
                    Console.WriteLine("\nIngreso un valor incorrecto..");
                    break;
            }
                

        }
        static void ejercicio07()
        {
            double sueldobase, sueldoM, sueldoJ, sueldoP, sueldoT;
            Console.Write("Ingrese un sueldo base ficticio: ");
            sueldobase = Convert.ToDouble(Console.ReadLine());
            sueldoM = sueldobase - (sueldobase * 0.05) - 25;
            sueldoJ = sueldobase + (sueldobase * 0.23) + 72;
            sueldoP = sueldobase + (sueldobase * 0.05) - 56;
            sueldoT = (sueldoM + sueldoJ + sueldoP);
            Console.WriteLine($"El sueldo de María es: {sueldoM:F2}");
            Console.WriteLine($"El sueldo de Juan es: {sueldoJ:F2}");
            Console.WriteLine($"El sueldo de Patricio es: {sueldoP:F2}");
            Console.WriteLine($"El sueldo total de todos es: {sueldoT}");
        }


        

    }
}
