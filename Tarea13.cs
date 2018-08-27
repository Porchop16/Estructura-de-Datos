using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea13
{
    class Program
    {
        static void Main(string[] args)
        {
            
            char numero;
            Console.Write("Ingrese un numero del 1 al 5: ");
            numero = Convert.ToChar(Console.ReadLine());

            switch (numero)
            {
                case '1':
                    Console.WriteLine("uno");
                    break;
                case '2':
                    Console.WriteLine("Dos");
                    break;
                case '3':
                    Console.WriteLine("Tres");
                    break;
                case '4':
                    Console.WriteLine("Cuatro");
                    break;
                case '5':
                    Console.WriteLine("Cinco");
                    break;
                default:
                    Console.WriteLine("Asigno un numero fuera de rango o una caracter");
                    break;
            }

        }
    }
}
