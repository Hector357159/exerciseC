using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Guia:Guia10
/// Ejercicio:02
/// Fecha:23/05/2022
/// Autor:Hector Gerardo Rodriguez Chamagua
/// Carnet:RC22009
/// GL:08
/// Intructo:Carlos Ernesto Garcia
/// <summary>
namespace RM21068_RC22009GL08Guia10Eje2
{
    class Program
    {
        /// <summary>
        /// Diseñe un programa que llene de ceros una matriz cuadrada de nxn, excepto la
        /// diagonal principal donde debe asignar 1. Por ejemplo, si n=4 la matriz resultante, que
        ///se debe de imprimir es:
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Title = "Matriz";
            Console.WriteLine("Matriz");
            Console.WriteLine("Autor: Hector Gerardo Rodriguez Chamagua GL08");
            // variables 
            int n = cuadrado();
            int[,] matriz =new int [n,n];
            //proceso
            for(int i = 0;i<n;i++)
            {
                for(int j=0;j< n;j++)
                {
                    if (j==i)
                    {
                        matriz[i, j] = 1;
                    }
                    else
                    {
                        matriz[i, j] = 0;
                    }
                    Console.Write(" " + matriz[i, j]);

                }
                Console.WriteLine();
            }
            //salida de datos 
            Console.ReadKey();
        }
        static int cuadrado()
        {
            int n;
            Console.WriteLine("De cuanto es la matriz?");
            n = Convert.ToInt16(Console.ReadLine());
            return n;
        }
    }
}
