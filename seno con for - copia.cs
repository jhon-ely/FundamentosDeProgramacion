using System;

namespace seno_con_for
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.youtube.com/watch?v=4Y8lOez4MTY
            Console.WriteLine("Digite X: ");
            double x = double.Parse(Console.ReadLine());
            Sin(x);
        }
        // creamos la funcion sen
        static void Sin(double x)
        {
         double t = 0;
         int n = 100;
         for (int i = 0; i < n; i++)
         {
             t = t  + ((Math.Pow(-1, i)) / Factorial((2 * i) + 1)) * (Math.Pow(x, (2 * i) + 1));
         }
            Console.WriteLine("El valor de sen"+"("+x+")= " + t);
        }
        // creamos la funcion factorial
        static double Factorial(double numerito)
        {
            if (numerito <= 1) return 1;
            return numerito * Factorial(numerito - 1);
        }
    }
}

    

