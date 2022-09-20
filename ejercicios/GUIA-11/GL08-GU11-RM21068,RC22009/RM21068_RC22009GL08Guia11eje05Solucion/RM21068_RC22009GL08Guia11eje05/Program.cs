using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM21068_RC22009GL08Guia11eje05
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Escribir una palabra para comparar: ");
                string cadena1 = Console.ReadLine();
                Console.WriteLine("Escribir una palabra para comparar: ");
                string cadena2 = Console.ReadLine();

                Console.WriteLine("Al comparar '{0}' con '{1}'", cadena1, cadena2);
                int resultado = cadena1.CompareTo(cadena2);
                if (resultado == 0)
                {
                    Console.WriteLine("Las cadenas son iguales");
                }
                else if (resultado < 0)
                {
                    Console.WriteLine("{0} es menor que {1}", cadena1, cadena2);
                }
                else
                {
                    Console.WriteLine("{0} es mayor que {1}", cadena1, cadena2);
                Console.ReadKey();
                }
            }
        }
    }