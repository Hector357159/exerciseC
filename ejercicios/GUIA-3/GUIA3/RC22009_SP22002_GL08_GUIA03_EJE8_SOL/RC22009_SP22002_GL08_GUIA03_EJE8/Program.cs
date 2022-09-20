using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC22009_SP22002_GL08_GUIA03_EJE8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variable
            double Distancia, x1, x2;

            //Identificacion del programa en pantalla
            Console.WriteLine("Distancia entre dos puntos ");


            //Entrada de datos
            Console.WriteLine("ingresa  el valor de x1");
            x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("ingresa  el valor de x2");
            x2 = double.Parse(Console.ReadLine());


            //proceso de datos 
            Distancia = Math.Abs(x2 - x1);

            //salida de datos
            Console.WriteLine("respuesta");
            Console.WriteLine("la distancia es:{0:####.##} cm", Distancia);
            Console.ReadKey();
        }
    }
}
