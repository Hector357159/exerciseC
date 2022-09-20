using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Guia:Guia08
/// Evaluacion:
/// Fecha:01/05/2022
/// Autor:Hector Gerardo Rodriguez Chamagua
/// Carnet:RC22009
/// GL:08
/// Intructo:Carlos Ernesto Garcia
/// <summary>
namespace RM21068_RC22009GL08Guia08Eje14
{
    class Program
    {
        /// <summary>
        /// Diseñe una solución que dada la cantidad de años lea para cada año el monto de
        /// cada una de las compras de petróleo en $ (la cantidad de compras por año varía);
        /// se debe imprimir el promedio por año y el total en los n años.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Title = "El promedio por año y el total en los n años.";
            Console.WriteLine("El promedio por año y el total en los n años.");
            Console.WriteLine("Autor: Hector Gerardo Rodriguez Chamagua GL08");
            //declaracion de variables
            int cantidadYear,promedioYears;
            int valorYears = 0;
            int[] years;

            //proceso
            cantidadYear = leerValor("Cuantos año son:");
            years = new int[cantidadYear];
            for (int i=0; i< cantidadYear; i++)
            {
                years[i]= leerValor($"El monto del año {i+1}cada una de las compras de petróleo en $");
                valorYears += years[i];
            }
            promedioYears = valorYears / cantidadYear;

            //salida de datos
            Console.WriteLine($"el promedio por año es {promedioYears} y el Total de {cantidadYear} años es: {valorYears}");
            Console.ReadKey();
        }
        /// <summary>
        /// para validar el resultador
        /// </summary>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        static int leerValor(string mensaje)
        {
            int valor;
            bool valido;
            string dato;

            Console.WriteLine(mensaje);
            dato = Console.ReadLine();

            valido = int.TryParse(dato, out valor);

            while (!valido || valor < 0)
            {
                Console.Clear();
                Console.WriteLine("Error al digitar el valor, intente de nuevo");
                Console.WriteLine(mensaje);
                dato = Console.ReadLine();

                valido = int.TryParse(dato, out valor);
            }

            return valor;
        }
    }
}
