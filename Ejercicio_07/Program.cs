using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime fechaActual = DateTime.Now;
            DateTime fechaNacimiento = new DateTime();
            int diasVividos;


            Console.WriteLine("Ingrese fecha de nacimiento");
            DateTime.TryParse(Console.ReadLine(), out fechaNacimiento);

            TimeSpan tSpan = fechaActual - fechaNacimiento;

            diasVividos = tSpan.Days;

            Console.WriteLine("Pasaron {0} días", diasVividos);


            Console.ReadKey();

        }
    }
}
