using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/// <summary>
/// Guia:Guia12
/// Ejercicio:02
/// Fecha:06/06/2022
/// Autor:Hector Gerardo Rodriguez Chamagua
/// Carnet:RC22009
/// GL:08
/// Intructo:Carlos Ernesto Garcia
/// <summary>
namespace RM21068_RC22009GL08Guia12Eje02
{
    class Program
    {
        /// <summary>
        /// Elabore un programa que lea números enteros de un dígito desde un archivo y
        ///los almacene en un vector, mostrando el vector resultante.Considere un vector de
        ///máximo
        ///100 elementos
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char[] numeros = new char[1000];
            //var currenPath = Directory.GetCurrentDirectory();

            //var filePath = currenPath + currenPath + Path.DirectorySeparatorChar + "a.txt";

            var file = new FileStream("a.txt", FileMode.OpenOrCreate);
            var reader = new StreamReader(file);
            var write = new StreamWriter(file);




            numeros = reader.ReadToEnd().Replace(" ",string.Empty).ToCharArray();

            for(int i=0;i<numeros.Length;i++)
            {
                Console.WriteLine(numeros[i]);
            }
                
    



            file.Close();
            Console.ReadKey();
        }
    }
}
