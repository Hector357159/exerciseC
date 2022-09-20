using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Guia:Guia11
/// Ejercicio:04
/// Fecha:30/05/2022
/// Autor:Hector Gerardo Rodriguez Chamagua
/// Carnet:RC22009
/// GL:08
/// Intructo:Carlos Ernesto Garcia
/// <summary>
namespace RC22009GL08Guia11Eje04
{
    class Program
    {
        /// <summary>
        /// Se lee una cadena de caracteres. Luego, se leen dos caracteres digitados por el usuario.
        ///  Se pide, realizar un programa que sustituya el primer caracter leído dentro de la cadena
        ///  por el segundo.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Title = "Se lee una cadena y se sustituye";
            Console.WriteLine("Se lee una cadena y se sustituye");
            Console.WriteLine("Autor: Hector Gerardo Rodriguez Chamagua GL08");
            //declaracion de variables
            string cadena = "Hola a todos los estudiantes de la Univercidad de El Salvador";
            char caracter0, caracter1;
            //proceso
            Console.WriteLine("------------------------Cadena sustituir-----------------------\n");
            Console.WriteLine(cadena);
            Console.WriteLine("\n------------------------**********-----------------------------");
            caracter0 = leerValor("\nEl caracter que desea sustituir:", cadena);
            caracter1 = leerValor("El que de sea agregar:", cadena);

            //finalizar
            Console.WriteLine(cadena.Replace(caracter0,caracter1));
            Console.ReadKey();
        }
        static char leerValor(string mensaje, string cadena)
        {
            char valor;
            bool valido;
            string dato;

            Console.WriteLine(mensaje);
            dato = Console.ReadLine();

            valido = char.TryParse(dato, out valor);

            while (!valido || string.IsNullOrWhiteSpace(dato))
            {
                Console.Clear();
                Console.WriteLine("Error al digitar el valor entero, intente de nuevo");
                Console.WriteLine("\n------------------------Cadena sustituir-----------------------\n");
                Console.WriteLine(cadena);
                Console.WriteLine("\n------------------------**********-----------------------------");
                Console.WriteLine(mensaje);
                dato = Console.ReadLine();

                valido = char.TryParse(dato, out valor);
            }

            return valor;
        }

    }
}
