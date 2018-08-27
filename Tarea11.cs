using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.Write("Ingrese un numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese un numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("El primer numero ingresado es Mayor ");
            }
            else
            {
                if (numero1 == numero2)
                    Console.WriteLine("Ambos numeros son iguales");
                else
                {
                    Console.WriteLine("El primer numero ingresado es Menor ");
                }

            }
        }
    }
}           