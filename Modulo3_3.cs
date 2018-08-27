using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, tabla, resultado;
            tabla = 9;

            for (numero = 1; numero <= 10; numero++)
            {
                resultado = tabla * numero;
                Console.WriteLine("{0} x {1} = {2}", tabla, numero, resultado);
            }
        }
    }
}
