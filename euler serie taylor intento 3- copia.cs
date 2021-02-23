using System;

namespace euler_serie_taylor_intento_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.youtube.com/watch?v=Atk80TMdcZQ
            Console.WriteLine("Digite valor de x: ");
            double x = double.Parse(Console.ReadLine());
           // entre mayor sea n, mas preciso sera
            int n = 100;
            // inicializamos en 0 la variable t  va a ir acomulando los x^i/i!
            double t = 0;
            // para i q empieza en o hasta n , en paso 1, haga lo q dice los corchetes,
            for (int i = 0; i < n; i++)
            {
               t =t+ (Math.Pow(x, i) / Factorial(i));
            }
            Console.WriteLine("e"+"^"+x+"= " + t);
        }
        // crear la funcion Factorial
        static double Factorial(double numerito)
        {
            if (numerito <= 1) return 1;
            else
            {
                return numerito * Factorial(numerito -1 );
            }
        }
    }
}
