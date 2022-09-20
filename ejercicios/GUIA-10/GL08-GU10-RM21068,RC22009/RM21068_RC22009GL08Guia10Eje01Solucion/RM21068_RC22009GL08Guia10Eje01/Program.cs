using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM21068_RC22009GL08Guia10Eje01
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;

                Console.Title = "NOTAS";
                Console.Clear();
                int i = 0, j = 0;
                double[,] notas = new double[5, 4];
                double[] promedio_alumnos = new double[5];
                double promedio, sumanotas = 0;

                notas = ingresar_notas();
                promedio_alumnos = promedio_alumno(notas);




                Console.WriteLine();
                Console.WriteLine("Las Notas Por Alumno Son:");
                for (i = 0; i < 5; i++)
                {
                    for (j = 0; j < 4; j++)
                        Console.Write("[{0}]\t", notas[i, j]);
                    Console.WriteLine("");
                }


                Console.WriteLine("El Promedio Por Alumno Es:");
                for (i = 0; i < 5; i++)
                    Console.WriteLine("{0} - {1}", i + 1, promedio_alumnos[i]);
                {

                    for (i = 0; i < 5; i++)
                    {

                        sumanotas = sumanotas + promedio_alumnos[i];
                    }
                    promedio = (sumanotas / 5);

                    Console.WriteLine();
                    Console.WriteLine("La Nota Promedio Es:");
                    Console.WriteLine("{0:0.00}", Math.Round(promedio, 2));
                    Console.WriteLine();
                    Console.ReadKey();


                }
            }

            public static double[,] ingresar_notas()
            {
                int i, j;
                double[,] notas = new double[5, 4];

                for (i = 0; i < 5; i++)
                    for (j = 0; j < 4; j++)
                        do
                        {
                            Console.WriteLine("Ingresar La Nota {0}, Del  Alumno 1", j + 1, i + 1);
                            notas[i, j] = double.Parse(Console.ReadLine());
                        } while (notas[i, j] < 0 || notas[i, j] > 10);
            Console.ReadKey();

            return notas;
            }
            public static double[] promedio_alumno(double[,] x)
            {
                int i, j;
                double[] alumno = new double[5];

                for (i = 0; i < 5; i++)
                    for (j = 0; j < 4; j++)
                        alumno[i] += x[i, j] / 4;

                return alumno;
            }
        }
    }









