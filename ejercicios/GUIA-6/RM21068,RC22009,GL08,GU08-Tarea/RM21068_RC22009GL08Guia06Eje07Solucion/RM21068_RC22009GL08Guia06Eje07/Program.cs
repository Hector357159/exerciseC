using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Guia:Guia6
/// Evaluacion:
/// Ejercicio:7
/// Fecha:27/03/2022
/// Autor:Hector Gerardo Rodriguez Chamagua
/// Carnet:RC22009
/// GL:08
/// Intructo:Carlos Ernesto Garcia
/// <summary>
namespace RM21068_RC22009GL08Guia06Eje07
{
    class Program
    {
        /// <summary>
        /// Dadas la talla de cintura de una persona y la distancia de la cintura al tobillo en
        /// centímetros, despliegue si su talla es S, M ó L y la cantidad de tela, en yardas, necesaria para
        /// hacer un pantalón.Tomar en cuenta que: S (menor a 60 cm), M(de 60 a 80cm), L(mayor que
        /// 80cm). La cantidad de tela a utilizar, viene dada por la relación: ((cintura+altura)/2) * 2.5 / 91.44
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Title = "Calcular en términos de días, horas y minutos";
            Console.WriteLine("Calcular en términos de días, horas y minutos");
            Console.WriteLine("-Autor: Hector Gerardo Rodriguez Chamagua GL08");
            //crear variables 

            string nombre;
            double cm, cintura, pantalon;

            //entrada de datos
            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la talla de su Cintura:");
            cintura = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la medida que hay entre su cintura al tobillo (en cm):");
            cm = double.Parse(Console.ReadLine());

            //procedimiento
            pantalon = ((cm + cintura / 2) * (2.5 / 91.44));

            //salida de datos
            if (cintura <= 59)
            {
                
                Console.WriteLine($"Su talla es S, {pantalon:0.0000}, es la cantidad de yardas que necesitara para hacer un pantalon");
            }
            else if (cintura == 60 || cintura <= 80)
            {
                
                Console.WriteLine($"Su talla es M, {pantalon:0.0000}, es la cantidad de yardas que necesitara para hacer un pantalon");
            }
            else if (cintura > 80)
            {
                
                Console.WriteLine($"Su talla es L, {pantalon:0.0000}, es la cantidad de yardas que necesitara para hacer un pantalon");
            }

            Console.ReadKey();
        }
    }
}
