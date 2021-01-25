using System;

namespace triangulo_rectamgulo_con_dos_catetos
{
    class Program
    {
        static void Main(string[] args)
        {
            // este programa sirve para calcular los otros aspectos del triangulo rectangulo, como hipotenusa y lados a travez de dos catetos
            Console.WriteLine("escriba cateto y");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("escriba cateto z");
            double z = double.Parse(Console.ReadLine());
            //hallar t osea la hipo10USA
            double t = Math.Sqrt(Math.Pow(z,2)+ Math.Pow(y, 2));
            Console.WriteLine("La hipotenusa t es de " + t);
            // hallar angulo a
            double angarad = Math.Asin((y/t));
            Console.WriteLine("el angulo a es de "+ angarad + " radianes");
            double angagra = (angarad*180)/Math.PI;
            Console.WriteLine("el angulo a es de " + angagra + " grados");
            // hallar angulo c
            double angcrad = Math.Asin((z/ t));
            Console.WriteLine("el angulo c es de " + angcrad + " radianes");
            double angcgra = (angcrad * 180) / Math.PI;
            Console.WriteLine("el angulo c es de " + angcgra + " grados");


        }
    }
}
