using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_2___primer_proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and then initialize to zero.
            double num1 = 0; int num2 = 0;

        
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to type the first number.
            Console.WriteLine("Escriba un número y, a continuación, presione Enter");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Ask the user to type the second number.
            Console.WriteLine("Escriba otro número y presione Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to choose an option.
            Console.WriteLine("Elija una opción de la siguiente lista:");
            Console.WriteLine("\ts - sumar");
            Console.WriteLine("\tr - restar");
            Console.WriteLine("\tm - multiplicar");
            Console.WriteLine("\td - dividir");
            Console.Write("¿Cuál opción eligira? ");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "s":
                    Console.WriteLine($"El resultado de {num1} + {num2} es:  " + (num1 + num2));
                    break;
                case "r":
                    Console.WriteLine($"El resultado de  {num1} - {num2} es:  " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"El resultado de {num1} * {num2} es:  " + (num1 * num2));
                    break;

                    while (num2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }

            // Wait for the user to respond before closing.
            Console.Write("Presione cualquier tecla para cerrar la aplicación de la consola calculadora");
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
