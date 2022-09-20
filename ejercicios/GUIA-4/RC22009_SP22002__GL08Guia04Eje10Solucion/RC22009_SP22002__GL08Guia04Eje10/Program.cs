using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Guia:Guia04
/// Ejercicio:10
/// Fecha:10/03/2022
/// Autor:Hector Gerardo Rodriguez Chamagua
/// Carnet:RC22009
/// GL:08
/// Intructo:Carlos Ernesto Garcia
/// <summary>
namespace RC22009_SP22002__GL08Guia04Eje10
{
    class Program
    {
        /// <summary>
        /// Diseñe una solución que dado un ángulo en grados calcule e imprima el seno, coseno y tangente
        /// para ese ángulo.Nota: todos los lenguajes de programación trabajan en radianes
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Title = "Calcular seno,coseno,tangente dado un ángulo en grados";
            Console.WriteLine("Calcular seno,coseno,tangente dado un ángulo en grados");
            Console.WriteLine("Autor: Hector Rodriguez\n");

            //asignar variables
            Double anguloGrados, conversionRadianes,seno, coseno, tangente;

            //entrada de datos
            Console.WriteLine("Cual es el ángulo en grados?");
            anguloGrados = double.Parse(Console.ReadLine());

            //Operaciones
            conversionRadianes = (anguloGrados * Math.PI) / 180;

            seno = Math.Sin(conversionRadianes);

            coseno = Math.Cos(conversionRadianes);

            tangente = Math.Tan(conversionRadianes);

            
          
            //salida de datos
            Console.WriteLine($"El seno de {anguloGrados} es de: {seno}");
            Console.WriteLine($"El coseno de {anguloGrados} es de: {coseno}");
            Console.WriteLine($"El tangente de {anguloGrados} es de: {tangente}");
            Console.ReadKey();
        }
    }
}
