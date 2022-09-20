using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Guia:06
/// Ejercicio:01
/// Fecha:26/03/2022
/// Autor:Natalia Alexandra Ramirez Mendoza 
/// Carnet:RM21068
/// GL:08
/// Intructo:Carlos Ernesto Garcia 
/// </summary>
namespace RM21068_RC22009GL08Guia06Eje01
{
    class Program
    {
        /// <summary>
        /// 1. Dados el nombre, salario, años trabajados y la categoría de un empleado, desplegar el
        /// nombre y el nuevo salario en dólares del próximo año, sabiendo que: Nuevo Salario = Salario
        /// + Incremento, donde: Incremento = IncrementoxCategoría + IncrementoxAños.Los
        /// porcentajes son: Categoría 1-
        /// 15%, Categoría 2-10% y Categoría 3-5%. Por cada año trabajado se le debe incrementar 0.5 %
        /// </summary>
        /// <param name="args"></param>
        const float INCXCAT1 = 0.15f, INCXCAT2 = 0.1f, INCXCAT3 = 0.05f;
        const float INCXTIEMPO = 0.005f;
        static void Main(string[] args)
        {
            string nombre;
            float salario, nuevoSal, incremento;
            int tiempo, cat;
            Console.WriteLine("Ingrese el nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el salario $");
            salario = float.Parse(Console.ReadLine());
            cat = LeerEntero("¿Cual es la categoría del empleado?");
            tiempo = LeerEntero("Tiempo de trabajo en la empresa");
            if (salario > 0 && tiempo > 0 && (cat >= 1 && cat <= 3))
            {
                incremento = IncrementoXTiempo(salario, tiempo) + IncrementoXCategoría(salario,
               cat);
                nuevoSal = salario + incremento;
                Console.WriteLine("Empleado: {0} Nuevo Salario ${1:0.00}", nombre,
               nuevoSal);
            }
            else
            {
                Console.WriteLine("No puede efectuarse la operación porque los datos son erróneos");
            }
            Console.ReadKey();
        }
        //Metodo para verificar que el dato es correcto
        static int LeerEntero(string mensaje)
        {
            int numero;
            Console.Write(mensaje);
            numero = int.Parse(Console.ReadLine());
            if (numero <= 0)
            {
                Console.WriteLine("El dato debe ser mayor que cero");
            }
            return numero;
        }
        //metodo que calcula el incremento de salario con respecto al tiempo
        static float IncrementoXTiempo(float salario, int tiempo)
        {
            float incremento;
            incremento = salario * (tiempo * INCXTIEMPO);
            return incremento;
        }

        //Calcula el incremento según categoría del empleado
        static float IncrementoXCategoría(float sal, float cat)
        {
            float incremento = 0;
            if (cat == 1)
            {
                incremento = sal * INCXCAT1;
            }
            if (cat == 2)
            {
                incremento = sal * INCXCAT2;
            }
            if (cat == 3)
            {
                incremento = sal * INCXCAT3;
            }
            return incremento;
        }
    }
}