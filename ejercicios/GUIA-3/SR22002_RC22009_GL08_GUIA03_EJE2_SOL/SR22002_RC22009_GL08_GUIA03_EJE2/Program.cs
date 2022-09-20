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
/// <summary>
namespace SR22002_RC22009_GL08_GUIA03_EJE2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variable
            Double X1,Y1,X2, Y2,Distancia;

            //obtenemos los primeros punto X1 y Y1
            Console.WriteLine("Ingrese el Punto x: ");
            X1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el punto Y: ");
            Y1 = Convert.ToDouble(Console.ReadLine());

            //Obtenemos el segundo punto X2 y Y2
            Console.WriteLine("Ingrese el Punto x: ");
            X2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el punto Y: ");
            Y2 = Convert.ToDouble(Console.ReadLine());

            //la operacion de teorema de pitagoras para saber la distancia en el los puntos
            Distancia = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));

            //imprimimos el resultado
            Console.WriteLine($"La distancia de los puntos ({X1},{Y1}) y ({X2},{Y2}) es: {Distancia}");

            //detenemos el depurar
            Console.ReadKey();
        }
    }
}
