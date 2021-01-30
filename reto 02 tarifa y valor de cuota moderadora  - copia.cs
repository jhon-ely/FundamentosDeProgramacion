using System;

namespace tarifa_y_valor_de_cuota_moderadora_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // reto 02 calculo de cuota moderadora
            Console.WriteLine("Digite su salario...");
            double salario = double.Parse(Console.ReadLine());
            double smmlv = 908526;
            Console.WriteLine("El smmlv del 2021 es de "+smmlv);
            Console.WriteLine("Para determinar el valor de la cuota moderadora se toma el smmlv ");
            Console.WriteLine("y se divide entre 30 para determinar el salario mínimo diario");
            double salariomindiario = (smmlv / 30);
            Console.WriteLine(smmlv+"/"+"30"+"= "+salariomindiario);
            Console.WriteLine("dependiendo de su tarifa, se le sacara un porcentaje a su salario minimo diario" );
            Console.WriteLine("y el resultado sera su tarifa de cuota moderadora ");
            
            double dossmmlv = (2 * smmlv);
            Console.WriteLine("2 smmlv = " + dossmmlv);
            double cincosmmlv = (5 * smmlv);
            Console.WriteLine("5 smmlv = " + cincosmmlv);
           

            if (salario < dossmmlv)
            {
                Console.WriteLine("Su salario de " + salario + " Lo pone en tarifa (A)= menos de 2 smmlv");
                double cuotamoderadora = salariomindiario*(11.70/100);
                Console.WriteLine("tarifa moderadora= "+ salariomindiario + "*"+" 11.70/100 " + "=" + cuotamoderadora);

            }
            else if (salario >= dossmmlv && salario < cincosmmlv)
            {
                Console.WriteLine("Su salario de " + salario + " Lo pone en tarifa (B)= 2 o mas smmlv y menos de 5 smmlv");
                double cuotamoderadora = salariomindiario * (46.10/100);
                Console.WriteLine("tarifa moderadora= " + salariomindiario + "*" + " 46.10/100 " + "=" + cuotamoderadora);
            }
            else
            {
                Console.WriteLine("Su salario de " + salario + " Lo pone en tarifa (C)= 5 o mas smmlv ");
                double cuotamoderadora = salariomindiario * (121.50/100);
                Console.WriteLine("tarifa moderadora= " + salariomindiario + "*" + " 121.50/100 " + "=" + cuotamoderadora);
            }

        }
    }
}
