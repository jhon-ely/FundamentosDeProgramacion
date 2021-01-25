using System;

namespace hipotenusa_t_y_angulo_a
{
    class Program
    {
        static void Main(string[] args)
        {
            // Este programa sirve para hallar los catetos y el angulo faltante, con un angulo (no el recto) y la hipotenusa
            //ingreso de datos
            Console.WriteLine("escriba hipotenusa t");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("escriba el angulo a");
            double a = double.Parse(Console.ReadLine());
            //encontrar cateto y
            double agra = (a * Math.PI) / 180;
            double y = Math.Sin(agra) * t;
            Console.WriteLine("El cateto y es de " + y + " unidades");
            //encontrar cateto z
            double z = Math.Cos(agra) * t;
            Console.WriteLine("El cateto z es de " + z + " unidades");
            //hallando angulo c
            double c = Math.Asin(z / t);
            Console.WriteLine("El angulo c es de " + c + " radianes");
            double cgra = (c * 180) / Math.PI;
            Console.WriteLine("El angulo c es de " + cgra + " grados");
        }
    }
}
