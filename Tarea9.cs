using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, producto;
            Console.Write("Ingrese el 1er numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el 2do numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            producto = numero1 * numero2;

            Console.WriteLine("El producto de esos numeros es {0}", producto);
        }
    }
}
