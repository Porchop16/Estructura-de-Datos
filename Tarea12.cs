using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, resultado;

            Console.Write("Ingrese un numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese un numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero2 == 0)
                Console.WriteLine("Error: No se puede dividir entre 0");
            else
            {
                resultado = numero1 / numero2;
                    Console.WriteLine("El resultado de dividir {0} entre {1} es {2}", numero1, numero2, resultado);
            }
        }
    }
}
