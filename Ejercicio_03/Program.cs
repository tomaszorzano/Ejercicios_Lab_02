using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numIngresado;
            

            Console.WriteLine("Ingrese numero: ");
           
            if (int.TryParse(Console.ReadLine(), out numIngresado)) 
            {
                int i = 0;

                for (int j = 2; j <= numIngresado; j++)
                {
                    for (i = 2; i < j; i++)
                    {
                        if ((j % i) == 0)
                        {
                            break;
                        }
                    }

                    if (i == j)
                    {
                        Console.WriteLine("{0} es primo", j);
                    }
                }
            }
      

            Console.ReadKey();

        }
    }
}
