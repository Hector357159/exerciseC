using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Guia:Guia11
/// Ejercicio:06
/// Fecha:30/05/2022
/// Autor:Hector Gerardo Rodriguez Chamagua
/// Carnet:RC22009
/// GL:08
/// Intructo:Carlos Ernesto Garcia
/// <summary>
namespace RM21068_RC22009GL08Guia11Eje06
{
    class Program
    {
        /// <summary>
        /// Se leen dos palabras por separado y se despliega la de menos caracteres en minúsculas y
        ///en mayúsculas la más larga; si las palabras son de la misma longitud solamente se indica
        ///mediante el mensaje: “Las Cadenas son Iguales”
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //declaracion de la variable
            string palabra0, palabra1;

            Console.Title = "Se leen dos palabras por separado";
            Console.WriteLine("Se leen dos palabras por separado");
            Console.WriteLine("Autor: Hector Gerardo Rodriguez Chamagua GL08");

            //Proceso
            palabra0 = leerValor("Cual es la primera palabra");
            palabra1=leerValor("Cual es la segunda palabra");
            Console.Clear();
            if(palabra0.Length >= palabra1.Length)
            {
                if(palabra0.Length == palabra1.Length)
                {
                    Console.WriteLine("Las Cadenas son Iguales");
                }
                else { 
                Console.WriteLine($"Palabra mas larga\n{ palabra0.ToUpper()}\n");
                Console.WriteLine($"palabla mas corta\n{palabra1.ToLower()}\n");
                }

            }
            else
            {
                Console.WriteLine($"Palabra mas larga\n{ palabra0.ToLower()}\n");
                Console.WriteLine($"palabla mas corta\n{palabra1.ToUpper()}\n");
            }
            //final
            Console.ReadKey();

        }
        static String leerValor(string mensaje)
        {
            string dato;

            Console.WriteLine(mensaje);
            dato = Console.ReadLine();

            

            while (string.IsNullOrWhiteSpace(dato))
            {
                Console.Clear();
                Console.WriteLine("Error al digitar el valor entero, intente de nuevo");
                Console.WriteLine(mensaje);
                dato = Console.ReadLine();

               
            }

            return dato.Trim();
        }

    }
}
