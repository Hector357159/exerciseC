using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Guia:Guia06
/// Evaluacion:
/// Ejercicio:9
/// Fecha:28/03/2022
/// Autor:Hector Gerardo Rodriguez Chamagua
/// Carnet:RC22009
/// GL:08
/// Intructo:Carlos Ernesto Garcia
/// <summary>
namespace RM21068_RC22009GL08Guia06Eje09
{
    class Program
    {
        /// <summary>
        /// Diseñe una solución que dado el tiempo en segundos, lo calcule en términos de días, horas y
        /// minutos.Ejemplo: 1 Día 3 Horas 2 Minutos, pero sí la cantidad es cero no debe desplegarse.
        /// Ejemplo: 1 Día 7 Minutos(la cantidad de Horas es cero)
        /// </summary>
        /// <param name="args"></param>
        /// 
        //variables contante
        const Double segundosMinutos = 60;
        const Double minutosHoras = 60;
        const Double horasDias = 24;
        const int resto = 60;
        static void Main(string[] args)
        {
            //creacion de varibra
            Double segundos,minutos,horas,dias,restoMinutos,restoHoras,restoDias;

            //crar variables 

            Console.Title = "Calcular en términos de días, horas y minutos";
            Console.WriteLine("Calcular en términos de días, horas y minutos");
            Console.WriteLine("-Autor: Hector Gerardo Rodriguez Chamagua GL08");

            //entrada de datos

            Console.WriteLine("cuantos segundos son:");
            segundos = double.Parse(Console.ReadLine());

            Console.Clear();

            //procedimiento 
            minutos = SegundosAMinutos(segundos,segundosMinutos);

            horas = MinutosAHoras(minutos, minutosHoras);

            dias = HorasADias(horas, horasDias);

            restoHoras = horas % 60;
            restoMinutos = segundos % 60;
            restoDias = segundos % 24;

            //salida de datos
            if (minutos>0)
            {
                
                if(horas>0)
                {
                    if(dias>0)
                    {
                       
                        Console.WriteLine($"los segundos {segundos} es dias {dias}: horas {restoHoras}: minutos {restoMinutos}");

                    }
                    else
                    {
                        if (restoHoras == 0)
                        {
                            Console.WriteLine($"los segundos {segundos} es horas {horas}: minutos {restoMinutos}");
                        }
                        else
                        {
                            Console.WriteLine($"los segundos {segundos} es horas {horas}");
                        }
                        
                    }
                }
                else
                {
                    if(restoMinutos>0)
                    {
                        Console.WriteLine($"los segundos {segundos} en minutos   es minutos {minutos}");
                    }
                    else
                    {
                        Console.WriteLine($"los segundos {segundos}");
                    }
                   
                }
            }
            else
            {
                Console.WriteLine($"los segundos {segundos}");
            }
            Console.ReadKey();

        }
        static double SegundosAMinutos(Double segundos, Double convertirMinutos)
        {
            //proceso
            double conversion;
            int convercionEntero;
            conversion = segundos/convertirMinutos;
            convercionEntero = Convert.ToInt16(conversion);
            return convercionEntero;
        }
        static double MinutosAHoras(Double minutos, Double convertirHoras)
        {
            //proceso
            double conversion;
            int convercionEntero;
            conversion = minutos / convertirHoras;
            convercionEntero = Convert.ToInt16(conversion);
            return convercionEntero;
        }
        static double HorasADias(Double horas, Double convertirDias)
        {
            //proceso
            double conversion;
            int convercionEntero;
            conversion = horas / convertirDias;
            convercionEntero = Convert.ToInt16(conversion);
            return convercionEntero;
        }
    }
}
