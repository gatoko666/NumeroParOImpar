using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Escribir un método que acepte un número y devuelva True si el número es par, o false si es impar.
namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                try
                {
                    Console.WriteLine("Escriba un número: ");
                    int numero1 = int.Parse(Console.ReadLine());

                    if (numero1 % 2 == 0)
                    {
                        Console.WriteLine("El número es par ");

                    }
                    else
                    {
                        Console.WriteLine("El número es impar ");

                    }

                    break;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Escibre un número XD ");
                }
            }
          

            Console.Read();
        }
    }
}
