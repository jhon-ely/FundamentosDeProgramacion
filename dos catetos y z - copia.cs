using System;

namespace dos_catetos_y_z
{
    class Program
    {
        static void Main(string[] args)
        {
            // desafio 02-01
            Console.WriteLine("escriba cateto y");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("escriba cateto z");
            double z = double.Parse(Console.ReadLine());
            //hallar t osea la hipo10USA
            double t = Math.Sqrt(Math.Pow(z, 2) + Math.Pow(y, 2));
            Console.WriteLine("La hipotenusa t es de " + t);
            // hallar angulo a
            double angarad = Math.Asin((y / t));
            Console.WriteLine("el angulo a es de " + angarad + " radianes");
            double angagra = (angarad * 180) / Math.PI;
            Console.WriteLine("el angulo a es de " + angagra + " grados");
            // hallar angulo c
            double angcrad = Math.Asin((z / t));
            Console.WriteLine("el angulo c es de " + angcrad + " radianes");
            double angcgra = (angcrad * 180) / Math.PI;
            Console.WriteLine("el angulo c es de " + angcgra + " grados");
        }
    }
}
