using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Guia:Guia11
/// Ejercicio:09
/// Fecha:30/05/2022
/// Autor:Hector Gerardo Rodriguez Chamagua
/// Carnet:RC22009
/// GL:08
/// Intructo:Carlos Ernesto Garcia
/// <summary>
namespace RM21068_RC22009GL08Guia11Eje09
{
    class Program
    {
        /// <summary>
        /// Diseñar un programa que lea el nombre completo de una persona (dos nombres y dos
        /// apellidos) y despliegue solamente el primer apellido.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Title = "Apellidos";
            Console.WriteLine("Apellidos");
            Console.WriteLine("Autor: Hector Gerardo Rodriguez Chamagua GL08");
            //declaracion de bariables
            string nombre;
            string[] list = new string[4];
            //proceso

            do
            {
                
                Console.WriteLine("cual es tu nombre Completo?");
                nombre = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(nombre));
            list = nombre.Split(' ');


            //salida dedatos

            Console.WriteLine(list[2]);
            Console.ReadKey();

        }
        
    }
}
