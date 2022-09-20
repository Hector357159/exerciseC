using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GT_7_FORMATIVA2_RC22009_CR22112
{
    class Program
    {
        const double PI = 3.141592;


        static void Main(string[] args)
        {
            //Variables
            Double radio, altura, area, volumen;
            String material;

            //obtenemos el radio del cilindro
            Console.WriteLine("Cual es el radio del cilindro?");
            radio = Convert.ToDouble(Console.ReadLine());

            //obtenemos la haltura del cilindro
            Console.WriteLine("Cual es la altura del cilindro?");
            altura = Convert.ToDouble(Console.ReadLine());

            //obtenemos el material del cilindro
            Console.WriteLine("Cual es el material del cilindro?");
            material = Console.ReadLine();

            //efectuamos las operaciones para encontrar area y volumen
            area = 2 * Math.PI * radio*(altura+radio);
            volumen = Math.PI*Math.Pow(radio,2)*altura;
            
            //imprimimos el resultado
            Console.WriteLine($"El area es:{area}.\nEl volumen es:{volumen}.\nEl material es:{material}");

            Console.ReadKey();

        }
    }
}
