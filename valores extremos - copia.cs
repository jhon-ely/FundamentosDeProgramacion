using System;

namespace valores_extremos
{
    class Program
    {
        static void Main(string[] args)
        {
            // valores extremos
            //https://www.youtube.com/watch?v=LNjd3zv3C8I

            double total = 0;
            Console.WriteLine("digite numero de datos");
            int n = int.Parse(Console.ReadLine());
            int i=0, max=0, min= 500;
            string nombremax = "";
            string nombremin = "";

            while (i < n) 
            {
                Console.WriteLine("Ingrese el nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la edad");
                int edad = int.Parse(Console.ReadLine());

                if(edad>max)
                {
                    max = edad;
                    nombremax = nombre;
                }
                if(edad<min)
                {
                    min = edad;
                    nombremin = nombre;
                }
                total += edad;
                i++;
            }
            double promedio = total / n;
            Console.WriteLine("El promedio fue de: " + promedio);
            Console.WriteLine("Mayor: " + max+" , "+nombremax);
            Console.WriteLine("Menor: " + min + " , " + nombremin);

        }
    }
}
