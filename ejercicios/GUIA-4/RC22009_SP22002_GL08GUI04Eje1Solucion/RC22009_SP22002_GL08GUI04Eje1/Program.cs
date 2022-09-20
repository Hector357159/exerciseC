using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Guia:Guia04
/// Ejercicio:01
/// Fecha:10/03/2022
/// Autor:Hector Gerardo Rodriguez Chamagua
/// Carnet:RC22009
/// GL:08
/// Intructo:Carlos Ernesto Garcia
/// <summary>
namespace RC22009_SP22002_GL08GUI04Eje1
{
    class Program
    {
        /// <summary>
        /// Programa para una Unaagencia de viajes necesita hacer cotizaciones a sus
        /// clientes que viene dado por los siguientes elementos :costo por uso 
        /// del vehiculo por cada dia,cantidad de gasolina que se gaste en el viaje,
        /// segun la distancia recorrida, salario diario del motorista y la ganancia
        /// que es un 50% del total de gastos.   Se sabe que el rendimiento del
        /// vehiculo a utilizar es de 40 Km/galon/
        /// Modifique este ejercicio que se desarrolló como ejemplo de tal forma que presente el
        /// costo neto del viaje, el total a pagar al conductor, la inversión de gasolina que se hará.
        /// </summary>
        /// <param name="args"></param>
        /// 
        //lo primero que se hace es la declaracion de constantes

        public const double GANANCIA = 0.5;
        public const int RENDIMIENTO = 40;

        static void Main(string[] args)
        {
            Console.Title = "El costo neto del viaje, el total a pagar al conductor, la inversión de gasolina que se hará";
            Console.WriteLine("El costo neto del viaje, el total a pagar al conductor, la inversión de gasolina que se hará");
            Console.WriteLine("Autor: Hector Gerardo Rodriguez Chamagua.\\n");

            //Declaracion de variable
            Double costoParaCliente, costoDiaVehiculo, distancia, salario, precioGalon;
            Double valorPorGasolina, pagoMotorista, cantidadGas, costoDelVieje;
            int dias;

            //entrada de datos
            Console.Write("Digite el costo por uso del vehículo por dia ");
            costoDiaVehiculo = double.Parse(Console.ReadLine());

            Console.Write("Cuántos días dura el viaje? ");
            dias = int.Parse(Console.ReadLine());

            Console.Write("Digite la distancia del viaje( mayor que 0) ");
            distancia = double.Parse(Console.ReadLine());

            Console.Write("Cual es el salario diario del empleado? ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Cual es el precio del galon de gasolina? ");
            precioGalon = double.Parse(Console.ReadLine());

            //Procedimiento
            cantidadGas = distancia / RENDIMIENTO;
            valorPorGasolina = cantidadGas * precioGalon;
            pagoMotorista = salario * dias;
            costoDelVieje = costoDiaVehiculo * dias + valorPorGasolina + pagoMotorista;
            costoParaCliente = costoDelVieje + costoDelVieje * GANANCIA;

            //Salida de Información
            Console.WriteLine("Estimado Cliente el costo de su viaje es :{0:0.00}", costoParaCliente);
            Console.WriteLine($"Elcosto neto del viaje es: {costoDelVieje}");
            Console.WriteLine($"Total a pagar al conductor: {pagoMotorista}");
            Console.WriteLine($"La inversion en gasolina es: {valorPorGasolina}");
            Console.ReadKey();
        }
    }
}
