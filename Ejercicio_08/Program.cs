using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar = "si";
            do
            {
                Double valorHs = 00;
                string nombre;
                int antiguedad;
                int cantHsTrabajadas = 0;
                Double importe = 00;
                double importeDesc;

                Console.WriteLine("****************************************");
                Console.WriteLine("*Ingrese nombre del empleado:          *");
                nombre = Console.ReadLine(); 
                Console.WriteLine("*Ingrese valor de la hs:               *");
                Double.TryParse(Console.ReadLine(), out valorHs);
                Console.WriteLine("*Ingrese antiguedad:                   *");
                int.TryParse(Console.ReadLine(), out antiguedad);
                Console.WriteLine("*Ingrese hs trabajadas:                *");
                int.TryParse(Console.ReadLine(), out cantHsTrabajadas);
                

                if (antiguedad <= 2)
                {
                    importe = (valorHs * cantHsTrabajadas);
                    Double desc = importe * 0.13;
                    importeDesc = importe - desc;

                    Console.WriteLine("******************************************");
                    Console.WriteLine("*Empleado:" + nombre ,                  "*");
                    Console.WriteLine("*Valor de hs:" + valorHs,               "*");
                    Console.WriteLine("*Antiguedad:" + antiguedad,             "*");
                    Console.WriteLine("*Hs trabajadas:" + cantHsTrabajadas,    "*");
                    Console.WriteLine("*Importe Bruto:" + importe,             "*");
                    Console.WriteLine("*Importe Neto:" +  importeDesc,         "*");
                    Console.WriteLine("******************************************");

                }
                else
                {
                    importe = ((valorHs * cantHsTrabajadas) + (antiguedad * 150));
                    
                    importeDesc = importe - (importe * 0.13);


                    Console.WriteLine("******************************************");
                    Console.WriteLine("*Empleado:" + nombre, "*");
                    Console.WriteLine("*Valor de hs:" + valorHs, "*");
                    Console.WriteLine("*Antiguedad:" + antiguedad, "*");
                    Console.WriteLine("*Hs trabajadas:" + cantHsTrabajadas, "*");
                    Console.WriteLine("*Importe Bruto:" + importe, "*");
                    Console.WriteLine("*Importe Neto:" + importeDesc, "*");
                    Console.WriteLine("******************************************");

                }





                Console.WriteLine("Desea continuar cargando empleados?");
                continuar = Console.ReadLine();
            } while (continuar == "si" || continuar == "SI" || continuar == "Si");



            Console.ReadKey();

        }
    }
}
