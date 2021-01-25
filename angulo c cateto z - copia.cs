using System;

namespace angulo_c_cateto_z
{
    class Program
    {
        static void Main(string[] args)
        {

            // Este programa sirve para calcular el angulo faltante, la hipotenusa y cateto y, usando el angulo C y cateto z
            //pedir datos
            Console.WriteLine("Escriba angulo C");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Escriba cateto Z");
            double z = double.Parse(Console.ReadLine());
            //hallar t osea la hipo10USA
            double crad = c * Math.PI / 180;
            double t = z * (1 / (Math.Sin(crad)));
            Console.WriteLine("la hipotenusa t es de " + t + " unidades");
            //hallar cateto y
            double y = t * Math.Cos(crad);
            Console.WriteLine("El cateto y es de " + y + " unidades");
            //hallar angulo a
            double a = Math.Asin(y / t);
            Console.WriteLine("El angulo a es de  " + a + " radianes");
            double agra = (a * 180) / Math.PI;
            Console.WriteLine("El angulo a es de  " + agra + " grados");




        }
    }
}
