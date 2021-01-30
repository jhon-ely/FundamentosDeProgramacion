using System;

namespace Tarifa_a_partir_de_salario
{
    class Program
    {
        static void Main(string[] args)
        {
            // reto 01 calculo de tarifa
            Console.WriteLine("smmlv del 2021 es de 908.526 pesos");
            double smmlv = 908526;
            Console.WriteLine("Su salario es de: ");
            double salario = double.Parse(Console.ReadLine());

            double dossmmlv = (2 * smmlv);
            Console.WriteLine("2 smmlv = "+ dossmmlv);
            double cuatrosmmlv = (4 * smmlv);
            Console.WriteLine("4 smmlv = " + cuatrosmmlv);
            if (salario < dossmmlv)
            {
                Console.WriteLine("Su salario de " + salario + " Lo pone en tarifa (A)= menos de 2 smmlv");
            }
            else if (salario >= dossmmlv && salario < cuatrosmmlv )
            {
                Console.WriteLine("Su salario de " + salario + " Lo pone en tarifa (B)= 2 o mas smmlv y menos de 4 smmlv");
            }
            else {
                Console.WriteLine("Su salario de " + salario + " Lo pone en tarifa (C)= 4 o mas ");
            }
            
            


        }
    }
}
