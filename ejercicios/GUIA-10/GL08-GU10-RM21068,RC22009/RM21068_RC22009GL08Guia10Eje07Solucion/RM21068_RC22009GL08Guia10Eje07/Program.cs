using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Guia:Guia10
/// Ejercicio:07
/// Fecha:23/05/2022
/// Autor:Hector Gerardo Rodriguez Chamagua
/// Carnet:RC22009
/// GL:08
/// Intructo:Carlos Ernesto Garcia
/// <summary>
namespace RM21068_RC22009GL08Guia10Eje07
{
    class Program
    {
        /// <summary>
        /// Se tienen las 6 calificaciones de 25 alumnos de Programación I, se necesita
        /// calcular lo siguiente:
        ///La nota promedio de cada examen
        ///El promedio final de cada alumno
        ///El mayor promedio final de los alumnos.
        ///DEBE TRABAJAR CON MATRICES Y VECTORES.
        /// </summary>
        const int ALUMNOS = 25;
        const int EVALUACIONES = 6;
        static void Main(string[] args)
        {
                    //variables
                    double[,] notas = new double[ALUMNOS, EVALUACIONES];
                    double[] notaAlumno = new double[ALUMNOS];
                    double[] promedioExamen = new double[EVALUACIONES];
                    double mayor;

                    Console.Title = "Las notas de los alumnos";
                    Console.WriteLine("Autor: Hector Gerardo Rodriguez Chamagua GL08");
                    Console.WriteLine("Las notas de los alumno");

                    //proceso
                    leerNotas(notas);
                    calculaNotaFinal(notas, notaAlumno);
                    calculoPromedioExamen(notas, promedioExamen);
                    mayor = buscaMayor(notaAlumno);

                    //salida
                    imprimir(notaAlumno, promedioExamen, mayor);
                    Console.WriteLine();
                     Console.Read();


                }
                static void imprimir(double[] notaAlumno, double[] promedioExamen, double mayor) {
                    Console.WriteLine();
                    Console.WriteLine("* Las notas finales de cada alumno son *");
                    foreach (double v in notaAlumno)
                        Console.WriteLine("{0:n}", v);
                    Console.WriteLine("\n");
                    Console.WriteLine("La nota promedio por examen es de ");
                    foreach (double v in promedioExamen)
                        Console.Write("{0:n}    ", v);
                    Console.WriteLine("\n");
                    Console.WriteLine("El mayor promedio es {0:n}", mayor);


                }
        static double buscaMayor(double[] notaAlumno) {
                    double notaMayor;
                    notaMayor = notaAlumno[0];

                    foreach (double v in notaAlumno)
                    {
                        if (v > notaMayor)
                            notaMayor = v;
                    }
                    return notaMayor;


                }
                static void calculoPromedioExamen(double[,] notas, double[] promedioExamen)
                {

            double suma;
            for (int i = 0; i < EVALUACIONES; i++)
            {
                suma = 0;
                for (int j = 0; j < ALUMNOS; j++)
                    suma += notas[j, i];
                promedioExamen[i] = suma / ALUMNOS;
            }
        }
        static void calculaNotaFinal(double[,] notas, double[] notaAlumno)
        {
    double suma;
    for (int i = 0; i < ALUMNOS; i++)
    {
        suma = 0;
        for (int j = 0; j < EVALUACIONES; j++)
            suma += notas[i, j];
        notaAlumno[i] = suma / EVALUACIONES;
    }

}
        static void leerNotas(double[,] notas) {
                    Random nota = new Random();
                    for (int i = 0; i < ALUMNOS; i++)
                        for (int j = 0; j < EVALUACIONES; j++)
                            notas[i, j] = nota.NextDouble() * 10;
                }
    }
}
