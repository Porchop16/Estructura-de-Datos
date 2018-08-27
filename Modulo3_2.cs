using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, contador, control;
            Console.WriteLine("Ingrese un numero");
            numero = Convert.ToInt32(Console.ReadLine());

            contador = 1;
            control = 10;

            while (control <= numero)
            {
                contador = contador + 1;
                control = control * 10;
            }

            Console.WriteLine("La cantidad de cifras de {0} son en total {1}", numero, contador);

        }
    }
}
