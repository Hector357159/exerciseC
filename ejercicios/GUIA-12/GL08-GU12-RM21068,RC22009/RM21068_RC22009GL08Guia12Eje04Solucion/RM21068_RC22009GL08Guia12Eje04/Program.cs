using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/// <summary>
/// Guia:Guia12
/// Ejercicio:04
/// Fecha:06/06/2022
/// Autor:Hector Gerardo Rodriguez Chamagua
/// Carnet:RC22009
/// GL:08
/// Intructo:Carlos Ernesto Garcia
/// <summary>
namespace RM21068_RC22009GL08Guia12Eje04
{
    class Program
    {
        /// <summary>
        /// Haga un archivo con los siguientes números enteros: 20,15,17,64,12,47,36,45,26,
        /// cada uno debe estar en una línea del archivo(en lista) y sin la coma.Elabore un
        /// programa que permita leer los números del archivo creado y asignarlos a una matriz de
        /// 3 por 3 de enteros. Imprima la matriz
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string[,] numeros = new string[3,3];
            //var currenPath = Directory.GetCurrentDirectory();

            //var filePath = currenPath + currenPath + Path.DirectorySeparatorChar + "a.txt";

            var file = new FileStream("a.txt", FileMode.OpenOrCreate);
            var reader = new StreamReader(file);
            var write = new StreamWriter(file);

            

            for (int i = 0; !reader.EndOfStream ;i++)
            {
                for (int j = 0;j<3; j++)
                {
                    numeros[i,j] = reader.ReadLine();
                    Console.WriteLine(numeros[i,j]);
                }
            }



            file.Close();
            Console.ReadKey();
        }
    }
}
 