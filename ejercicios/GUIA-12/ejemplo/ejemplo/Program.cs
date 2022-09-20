using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 1,q=1;
            while (q <= 4&&--q<a)
            {
                q += a;
                a++;
            }

            Console.WriteLine($"{q}");*/
            //int altura = 5;
            int n = 3,ban=1,suma=0;
            do
            {
                suma += n;
                n++;
            }
            while (ban == 1 && suma <= 6);
            
            Console.WriteLine($"{suma}");
            Console.ReadKey();

        }
        static int leerValor(string mensaje)
        {
            string[] cars = new string[4];

            int[,] matriz = new int[4, 5];

            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int col = 0; col < matriz.GetLength(1); col++)
                {
                    Console.Write(matriz[fila, col] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            int valor;
            bool valido;
            string dato;

            Console.WriteLine(mensaje);
            dato = Console.ReadLine();

            valido = int.TryParse(dato, out valor);

            while (!valido || valor < 0)
            {
                Console.Clear();
                Console.WriteLine("Error al digitar el valor entero, intente de nuevo");
                Console.WriteLine(mensaje);
                dato = Console.ReadLine();

                valido = int.TryParse(dato, out valor);
            }

            return valor;
        }
    }
}
