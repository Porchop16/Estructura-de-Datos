using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, mayor;
            Console.Write("Ingrese un numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese otro numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            mayor = numero1 > numero2 ? numero1 : numero2; // Esto equivale a decir if (a > b) si es V "a es mayor", else "b es mayor"

            Console.WriteLine("El mayor de los numeros es {0}", mayor);
        }
    }
}
