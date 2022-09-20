using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// <summary>
/// Guia:Guia04
/// Ejercicio:04
/// Fecha:10/03/2022
/// Autor:Hector Gerardo Rodriguez Chamagua
/// Carnet:RC22009
/// GL:08
/// Intructo:Carlos Ernesto Garcia
/// <summary>
namespace RC22009_SP22002_GL08Guia04Eje4
{
    class Program
    {
        /// <summary>
        /// Un docente necesita calcular la nota final de la asignatura de Introducción a la
        /// Informática que viene dada por el promedio de 4 notas.Realice un programa que
        /// permita realizarlo.
        /// </summary>
        /// <param name="args"></param>
        /// 
        static void Main(string[] args)
        {

            Console.Title = "calcular la nota final de la asignatura de Introducción a la Informática";
            Console.WriteLine("calcular la nota final de la asignatura de Introducción a laInformática");
            Console.WriteLine("Autor: Hector Rodriguez\n");

            //Declaracion de variables
            Double nota1, nota2, nota3, nota4, promedio;


            //Entrada de datos
            Console.WriteLine("Cual es la primera nota?");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Cual es la segunda nota?");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Cual es la tercera nota?");
            nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Cual es la cuarta nota?");
            nota4 = double.Parse(Console.ReadLine());

            //procedimieno
            promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            //salida de informacion
            Console.WriteLine($"El promedio es: {promedio}");
            Console.ReadKey();
        }
    }
}
