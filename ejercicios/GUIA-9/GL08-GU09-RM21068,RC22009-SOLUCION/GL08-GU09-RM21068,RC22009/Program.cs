using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Guia:Guia3
/// Ejercicio:09
/// Fecha:16/05/2022
/// Autor:Hector Gerardo Rodriguez Chamagua
/// Carnet:RC22009
/// GL:08
/// Intructo:Carlos Ernesto Garcia
/// <summary>
namespace GL08_GU09_RM21068_RC22009
{
    class Program
    {
        //Se desea conocer la siguiente información de una empresa:
        //Imprimir toda la nómina de empleados ordenados por un número correlativo.
        //Cuantos empleados ganan más de $1500.00
        //Cuántos entre $850.00 y $1500.oo
        //Cuantos menos de $850.00
        //Porcentaje de empleados con salarios menores de $850.oo
        //Porcentaje de empleados cuyo salario oscila entre $850.oo y $1000.oo
        //Porcentaje de empleados con salario mayor a $1000.oo
        //Diseñe el programa correspondiente utilizando vectores.
        static void Main(string[] args)
        {
            int[] empleados = { 1, 2, 3, 4, 5, 6, 7 };
            double[] salario = { 850.00, 1500.00, 700.00, 2000.00, 1700.00, 250.00, 900.00 };
            int i = 0;

            foreach (int empleado in empleados)
            {

                Console.WriteLine($"El empreado numero {empleado} y el sarario es {salario[i]}");
                i++;
            }
            Console.ReadKey();
        }
    }
}
