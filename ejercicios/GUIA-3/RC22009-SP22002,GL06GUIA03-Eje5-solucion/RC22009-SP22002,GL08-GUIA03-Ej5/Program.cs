using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC22009_SP22002_GL08_GUIA03_Ej5
{
    class Program
    {
      

        static void Main(string[] args)
        {
            //Declaracion de variable
            double f, c;

            //Identificacion del programa en pantalla
            Console.WriteLine("programa para convertir fahrenheiAcelsius");

            //Entrada de datos
             Console.WriteLine("ingresar los grados en Fahrenhei ");

            f = double.Parse(Console.ReadLine());

            //proceso de datos 
            c =((f - 32) * 5 / 9);

            //salida de datos
            Console.WriteLine("respuesta");
            Console.WriteLine ("grados celsious :{0:####,####}",c);
            Console.ReadKey();

          
        }

      
        }
    }

