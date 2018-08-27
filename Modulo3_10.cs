using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nombre de usuario: ");
            string nombre = Console.ReadLine();

            if (nombre == "Martin")
            {
                Console.WriteLine("Hola " + nombre);
            }
            else
                Console.WriteLine("No te conozco");
        }
    }
}
