using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Guia:Guia3
/// Ejercicio:12
/// Fecha:1/03/2022
/// Autor:Hector Gerardo Rodriguez Chamagua
/// Carnet:RC22009
/// GL:08
/// Intructo:Carlos Ernesto Garcia
/// </summary>
namespace SP22002_RC22009_GL08_GUIA03_EJE12
{
    class Program
    {
        static void Main(string[] args)
        {

                //declaracion de variable
                String numerador, denominador;

                Double cantidadNu, cantidadDe, resulatado;

                //pedimos lo que desea dividir y lo guardamos como numerador
                Console.WriteLine("Que desea dividir?");
                numerador = Console.ReadLine();

                //pedimos entre que desea dividir y lo guardamos como denominador
                Console.WriteLine($"Entre que desea dividir {numerador}");
                denominador = Console.ReadLine();

                //Pedimos la cantidad de numerador
                Console.WriteLine($"Cantidad de {numerador}:");
                cantidadNu = Convert.ToInt16(Console.ReadLine());

                //pedimos la cantidad de denominador
                Console.WriteLine($"Cantidad de {denominador}:");
                cantidadDe = Convert.ToInt16(Console.ReadLine());

                //operacion de divicion
                resulatado = cantidadNu / cantidadDe;

                //mostramos el resultado
                Console.WriteLine($"{resulatado} {numerador} por {denominador}");

                //detenemos la depuracion
                Console.ReadKey();
            }
    }
}
