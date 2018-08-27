using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una letra: ");
            Char letra = Convert.ToChar(Console.ReadLine());

            switch (letra)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u': Console.WriteLine("Es una vocal");
                    break;
                default:
                    break;
            }
        }
    }
}
