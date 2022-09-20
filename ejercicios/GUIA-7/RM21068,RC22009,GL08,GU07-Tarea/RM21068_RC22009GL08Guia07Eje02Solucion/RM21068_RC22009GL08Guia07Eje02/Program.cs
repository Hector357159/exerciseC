using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Guia:Guia07
/// Evaluacion:
/// Ejercicio:02
/// Fecha:04/04/2022
/// Autor:Hector Gerardo Rodriguez Chamagua
/// Carnet:RC22009
/// GL:08
/// Intructo:Carlos Ernesto Garcia
/// <summary>
namespace RM21068_RC22009GL08Guia07Eje02
{
    class Program
    {
        /// <summary>
        /// Para la realización del segundo examen parcial de Introducción a la Informática se exigirá que cada
        /// estudiante haya asistido a, por lo menos, el 75% de las 8 clases teóricas y 4 sesiones de laboratorios
        /// a evaluar.Dado el carnet del estudiante y sus respectivas asistencias, despliegue carnet, porcentaje
        /// de asistencia de cada tipo de actividad y si tiene derecho a realizar el examen.
        /// </summary>
        /// <param name="args"></param>
        /// 
        //Contantes
        const int PORCENTAJE = 100;
        const int TOTALCLASES = 12;
        static void Main(string[] args)
        {
            //identificador del programa
            Console.Title = "Realizar examen segun la asisencia del estudiante";
            Console.WriteLine("Realizar examen parcial,segun la asisencia del estudiante por lo menos: \n8 clases teóricas y 4 sesiones de laboratorios");
            Console.WriteLine("\n-Autor: Hector Gerardo Rodriguez Chamagua GL08");

            //Declaracion de variables
            int clasesTeoricas,clasesLaboratorio,porcentaje,asistencia;
            String carnet;


            //Entrada de Datos

            Console.WriteLine("Cual es su numero de carnet:");
            carnet = Console.ReadLine();
            Console.WriteLine("A Cuantas clases Teoricas asistio (0 a 8):");
            clasesTeoricas = int.Parse(Console.ReadLine());
            Console.WriteLine("A Cuantas clases Laboratorio asistio (0 a 4):");
            clasesLaboratorio = int.Parse(Console.ReadLine());

            Console.Clear();

            //Procedimiento 
            asistencia = CalcularAsistencia(clasesTeoricas,clasesLaboratorio);




            //Salida de datos
            porcentaje = CalcularPorcentaje(asistencia,carnet);

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo para calcular el numero de clases asistidas
        /// </summary>
        /// <param name="clasesTeoricas"></param>
        /// <param name="clasesLaboratorio"></param>
        /// <returns></returns>
        static int CalcularAsistencia(int clasesTeoricas,int clasesLaboratorio)
        {
            //Declaracion de variables
            int asistencia=0;

            //procedimiento
            asistencia = clasesLaboratorio + clasesTeoricas;

            //return
            return asistencia;
        }
        /// <summary>
        /// Metodo para calcular el porcentaje de asistencia y mostrar si hace el examen
        /// </summary>
        /// <param name="asistencia"></param>
        /// <param name="carnet"></param>
        /// <returns></returns>
        static int CalcularPorcentaje(int asistencia, string carnet)
        {
            //Declaracion de variables
            int porcentaje = 0;

            //procedimiento
            porcentaje = PORCENTAJE * asistencia / TOTALCLASES;
            if(asistencia>=9)
            {
                Console.WriteLine($"El carnet del estudian es: {carnet}\ncuya asistensia es: {porcentaje}%\nTiene derecho a realizar la prueba");
            }
            else
            {               
               Console.WriteLine($"El carnet del estudian es: {carnet}\ncuya asistensia es: {porcentaje}%\nNo tiene derecho a realizar la prueba");
            }

            return porcentaje;
        }
    }
}
