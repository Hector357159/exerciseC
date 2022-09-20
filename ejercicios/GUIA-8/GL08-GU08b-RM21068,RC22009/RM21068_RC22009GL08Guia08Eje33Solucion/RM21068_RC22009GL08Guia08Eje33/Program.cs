using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM21068_RC22009GL08Guia08Eje33
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0 , Eva;
            do
            {
                //ENTRADA DE DATOS

                Console.WriteLine("Digite Un Numero Desde -5 Asta 5");
                x = double.Parse(Console.ReadLine());

                if (x >= -5 && x <= 5)

                {
                    //PROCESO
                    Eva = Math.Pow(x, 3) + 3 * x + 1;

                    Console.WriteLine("La Funcion Es X^3+3X+1");

                    //SALIDA DE DATOS
                    Console.WriteLine("El Resultado Es:" + Math.Round(Eva, 4));
                }

                else
                {
                    Console.WriteLine("EL NUMERO INGRESADO ES INVALIDO");
                }
                Console.WriteLine("Digite 0 para salir");
            }
            while (x != 0);
            Console.ReadKey();
            }
    }
}
