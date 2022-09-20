using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM21068_RC22009GL08Guia07Eje01
{
    class Program
    {
        public const float desc1 = 0.05f, desc2 = 0.07f, desc3 = 0.10f;
        public const float descA = 0.25f, descU = 0.50f;
        static void Main(string[] args)
        {
            Console.Title = "RM21068_RC22009GL08Guia07Eje01";
            //declaracion de variables
            string nombre; char condicion;
            float precio, total;
            int depto;
            //variables logicas
            bool deptoCorrecto, condicionCorrecta;
            //entrada de datos
            Console.WriteLine("Ingresar nombre del producto");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresar precio del producto");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("departamento: \n1.electronicos \n2.enseres \n3.muebles");
            depto = int.Parse(Console.ReadLine());
            Console.WriteLine("condicion \n'n' nuevo \n'u' usado \n'a' abierto");
            condicion = char.Parse(Console.ReadLine());
            deptoCorrecto = depto >= 1 && depto <= 3;
            condicionCorrecta = condicion == 'n' || condicion == 'u' || condicion == 'a';
            if (EsPositivo(precio) && deptoCorrecto && condicionCorrecta)
            {
                total = precio - descuentoxCondicion(precio, condicion) - descuentoxDepto(precio, depto, condicion);
                Console.WriteLine("producto: {0}, total a pagar: ${1:0.00}", nombre, total);
                if (condicion == 'n')
                {
                    Console.WriteLine("producto con garantia");
                }
                else {
                    Console.WriteLine("producto sin garantia");
                }
            }
            else {
                Console.WriteLine("error de datos ingresados");
                if (!EsPositivo(precio)) {
                Console.WriteLine("el precio debe ser positivo");
                }
                if (!deptoCorrecto) {
                Console.WriteLine("departamento debe ser 1,2 o 3");
                }
                if (!condicionCorrecta) {
                Console.WriteLine("la condicion debe ser 'n','u','a'");
            }
        }

            Console.ReadKey();

    }
        public static bool EsPositivo(float num) {
            bool valor;
            if (num > 0)
            {
                valor = true;
            }
            else {
                valor = false;
            }
            return valor;
        }
        public static float descuentoxDepto(float precio,int depto,char condicion) {
            float descuento = 0f;
            if(condicion == 'n') {
                switch (depto) {
                    case 1:
                        descuento = desc1 * precio;
                        break;
                    case 2:
                        descuento = desc2 * precio;
                        break;
                    case 3:
                        descuento = desc3 * precio;
                        break;
                
                 }
            }
            return descuento;
        }
         public static float descuentoxCondicion(float precio, char condicion) {
            float descuento = 0f;
            switch (condicion) {
                case 'a':
                    descuento = descA * precio;
                    break;
                case 'u':
                    descuento = descU * precio;
                    break;
             }
            return descuento;
         }
    }
}
