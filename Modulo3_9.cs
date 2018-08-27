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
            string username, password, confirmacion;

            Console.Write("Nombre de usuario:");
            username = Console.ReadLine();
            
            do
            {
                Console.Write("Contraseña: ");
                password = Console.ReadLine();
                Console.Write("Confirmar contraseña: ");
                confirmacion = Console.ReadLine();

                if (password != confirmacion)
                {
                    Console.WriteLine("Las contraseñas no coinciden");
                }
            }
            while (password != confirmacion);
            Console.WriteLine("Bienvenido!");
        }   

    }
}
