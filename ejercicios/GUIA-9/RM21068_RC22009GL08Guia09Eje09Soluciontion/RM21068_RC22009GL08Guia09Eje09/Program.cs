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
namespace RM21068_RC22009GL08Guia09Eje09
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
            double promedioMayor, promedioIntermedio, promedioMenor;
            double salarioMayor = 0;
            double salarioIntermedio = 0;
            double salarioMenor = 0;
            int i = 0;

            foreach (int empleado in empleados)
            {
                Console.WriteLine($"El empreado numero {empleado} y el sarario es {salario[i]}");
                if (salario[i] > 1500)
                {
                    salarioMayor++;

                }
                else if (salario[i] <= 1500 || salario[i] > 850)
                {
                    salarioIntermedio++;

                }
                else if (salario[i] <= 850)
                {
                    salarioMenor++;
                }
                i++;
            }




            promedioMayor = (salarioMayor / salario.Length) * 100;
            promedioIntermedio = (salarioIntermedio / salario.Length) * 100;
            promedioMenor = (salarioMenor / salario.Length) * 100;
            Console.WriteLine($"los empredaos con el salario de $1500.00 es: {salarioMayor}\nlos empredaos con entre $850.00 y $1500.00 es: {salarioIntermedio}\n los empredaos con salario de $850.00 es: {salarioMenor}");
            Console.WriteLine($"El porcentaje de empredaos con el salario de $1500.00 es: {promedioMayor:0.0}%\nEl porcentaje empredaos con entre $850.00 y $1500.00 es: {promedioIntermedio:0.0}\nEl porcentaje empredaos con salario de $850.00 es: {promedioMenor:0.0}");
            Console.ReadKey();
        }

    }
}
