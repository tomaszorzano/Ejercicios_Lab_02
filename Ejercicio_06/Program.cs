using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {

            int anioIngresado;


            Console.WriteLine("Ingrese anio: ");

            if (int.TryParse(Console.ReadLine(), out anioIngresado))
            {
                int i = 0;



                for (int j = 4; j <= anioIngresado; j++)
                {
                    for (i = 4; i < j; i++)
                    {
                        
                        if (j % 4 != 0)
                        {
                            if (j % 100 == 0 || j % 400 != 0)
                            {
                                break;
                            }
                            
                        }

                    }

                    if (i == j)
                    {
                        Console.WriteLine("{0} es un año bisiesto ", j);
                    }
                }




            }


            Console.ReadKey();
        }
    }
}
