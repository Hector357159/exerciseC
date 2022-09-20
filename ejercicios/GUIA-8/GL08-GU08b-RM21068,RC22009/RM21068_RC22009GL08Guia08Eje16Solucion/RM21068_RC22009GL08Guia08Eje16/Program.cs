using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Guia:Guia08
/// Evaluacion:
/// Ejercicio:16
/// Fecha:01/05/2022
/// Autor:Hector Gerardo Rodriguez Chamagua
/// Carnet:RC22009
/// GL:08
/// Intructo:Carlos Ernesto Garcia
/// <summary>
namespace RM21068_RC22009GL08Guia08Eje16
{
    class Program
    {
        /// <summary>
        /// Dado que la cantidad de grupos teóricos es diferente y la cantidad de alumnos
        /// examinados por grupo teórico también, diseñe una solución que permita ingresar
        /// por grupo teórico la nota de cada estudiante e imprima la nota promedio de cada grupo.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Title = "La nota promedio de cada grupo";
            Console.WriteLine("La nota promedio de cada grupo");
            Console.WriteLine("Autor: Hector Gerardo Rodriguez Chamagua GL08");
            //declaracion de variables
            int numeroGrupo, numeroAlumnos, numeroNotas,promedio;
            int sumaNotas = 0;
            int year = 0;
            int[] alumnos;
            int[] notaPromedio;

            //proceso
            numeroGrupo = leerValor("Cual es la taza de interes anual ?");
            notaPromedio = new int[numeroGrupo];
            for (int i = 0; i < numeroGrupo; i++)
            {
                numeroAlumnos = leerValor($"Cuantos alumnos son en el grupo {i + 1}");
                alumnos = new int[numeroGrupo];
                for (int j = 0; j < numeroAlumnos; j++)
                {
                    numeroNotas = leerValor($"Cual es la nota del alumno numero {j + 1} del grupo {i + 1}?");
                    sumaNotas = sumaNotas + numeroNotas;
                }
                notaPromedio[i] = sumaNotas / numeroAlumnos;
                sumaNotas = 0;


            }
            //salida de datos
            for (int i=0; i< numeroGrupo; i++)
            {
                Console.WriteLine($"El promedio de notas del grupo {i+1} es {notaPromedio[i]}");
            }
            Console.ReadKey();
        }
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
                Console.WriteLine("Error al digitar el valor entero, intente de nuevo");
                Console.WriteLine(mensaje);
                dato = Console.ReadLine();

                valido = int.TryParse(dato, out valor);
            }

            return valor;
        }
    }
}
