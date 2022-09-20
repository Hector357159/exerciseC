using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Guia:Guia3
/// Evaluacion:SI ES UNA EVALUACION
/// Ejercicio:12
/// Fecha:modificar
/// Autor:Hector Gerardo Rodriguez Chamagua
/// Carnet:RC22009
/// GL:08
/// Intructo:Carlos Ernesto Garcia
/// <summary>
namespace RM21068_RC22009GL08Guia07Eje06
{
    class Program
    {
        /// <summary>
        /// Diseñe una solución que dado el sexo de una persona y el día de la semana imprima el valor de la
        /// entrada a una discoteca.El precio para hombres es de $10 y para mujer es de $5, pero 
        /// dependiendo del día de la semana, se tienen los siguientes descuentos: para hombres: Domingo
        /// Domingo 50%, Jueves 10%, Martes 30% y para mujer: Lunes, Miércoles y Sábado se hace 50%. Además
        /// el Viernes las mujeres entran gratis.
        /// </summary>
        /// <param name="args"></param>
        /// 
        //Variabres contantes
        public const float HOMBREDESC1 = 0.50f, HOMBREDESC2 = 0.10f, HOMBREDESC3 = 0.30f;
        public const float MUJERDESC1 = 0.50f;
        public const int HOMBRE = 10;
        public const int MUJER = 5;
        static void Main(string[] args)
        {
            //Identificador del programa
            Console.Title = "dado el sexo de una persona y el día de la semana imprima el valor de la entrada a una discoteca";
            Console.WriteLine("dado el sexo de una persona y el día de la semana imprima el valor de la entrada a una discoteca");
            Console.WriteLine("Autor: Hector Gerardo Rodriguez Chamagua GL08");


            //Declaracion de variables
            float total;
            int sexo,diaSemana;


            //Entrada de Datos

            Console.WriteLine("Selecione que sexo es 1:Masculino o 2:Femenino");
            sexo = int.Parse(Console.ReadLine());
            Console.WriteLine("Selecione que dia de la semana es segun el numero:\n1:Lunes\n2:Martes\n3:Miercoles\n4:Jueves\n5:Viernes\n6:Sabado\n7:Domingo");
            diaSemana = int.Parse(Console.ReadLine());

            Console.Clear();

            //Procedimiento
            if(sexo==1)
            {
                switch(diaSemana)
                {
                    case 2:
                        total = HOMBREDESC3 * HOMBRE;
                        Console.WriteLine($"El pagar es de ${HOMBRE} pero con el descuento de {HOMBREDESC3}% el total es ${total}");
                        break;
                    case 4:
                        total = HOMBREDESC2 * HOMBRE;
                        Console.WriteLine($"El pagar es de ${HOMBRE} pero con el descuento de {HOMBREDESC2}% el total es ${total}");
                        break;
                    case 7:
                        total = HOMBREDESC1 * HOMBRE;
                        Console.WriteLine($"El pagar es de ${HOMBRE} pero con el descuento de {HOMBREDESC1}% el total es ${total}");
                        break;
                    default:
                        Console.WriteLine($"El total a pagar es de ${HOMBRE}");
                        break;
                }
            }
            else if(sexo == 2)
            {
                switch (diaSemana)
                {
                    case 1:
                        total = MUJERDESC1 * MUJER;
                        Console.WriteLine($"El pagar es de ${MUJER} pero con el descuento de {MUJERDESC1}% el total es ${total}");
                        break;
                    case 3:
                        total = MUJERDESC1 * MUJER;
                        Console.WriteLine($"El pagar es de ${MUJER} pero con el descuento de {MUJERDESC1}% el total es ${total}");
                        break;
                    case 6:
                        total = MUJERDESC1 * MUJER;
                        Console.WriteLine($"El pagar es de ${MUJER} pero con el descuento de {MUJERDESC1}% el total es ${total}");
                        break;
                    case 5:
                        Console.WriteLine($"Hoy es gratis");
                        break;
                    default:
                        Console.WriteLine($"El total a pagar es de ${MUJER}");
                        break;
                }
            }
            else
            {
                Console.WriteLine("no existe ese sexo");
            }

            //Salida de datos

            Console.ReadKey();
        }
    }
}
