using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            int username, password, user_temporal, pass_temporal;
            username = 1234;
            password = 1111;

            do
            {
                Console.Write("Introduzca usuario: ");
                user_temporal = Convert.ToInt32(Console.ReadLine());

                Console.Write("Intruduzca password: ");
                pass_temporal = Convert.ToInt32(Console.ReadLine());

                if (username != user_temporal && password != pass_temporal)
                {
                    Console.WriteLine("\nCredenciales incorrectas");
                }
            }
            while (username != user_temporal && password != pass_temporal);
            Console.WriteLine("Bienvenido!");
        }
    }
}
