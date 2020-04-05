﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese número: ");
            string numero = Console.ReadLine();
            int j;

            if (int.TryParse(numero, out j))
            {
                for (int centro = 1; centro <= j; centro++)
                {
                    int acum = 0;
                    for (int i = 1; i < centro; i++)
                    {
                        acum += i;
                    }

                    int contador = centro + 1;
                    do
                    {
                        acum -= contador;
                        contador++;

                    } while (acum > 0);
                    if (acum == 0 )
                    {
                        Console.WriteLine("{0} es centro numérico", centro);
                    }
                    else
                    {
                        Console.WriteLine("{0} no es centro numérico", centro);
                    }
                }
            }
            else
            {
                Console.WriteLine("No es un número");

            }

            Console.ReadKey();
        }
    }
}
