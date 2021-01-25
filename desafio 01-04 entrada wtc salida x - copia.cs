using System;

namespace desafio_01_04_entrada_wtc_salida_x
{
    class Program
    {
        static void Main(string[] args)
        {
            // desafio 01-04 entrada wtc salida x
            // obtener datos
            Console.Write("Digite hipotenusa mayor w: ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Digite hipotenusa menor t: ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("Digite angulo c: ");
            double c = double.Parse(Console.ReadLine());
            double crad = c * (Math.PI / 180.0);
            
            /* obtener z: z=sen(c)*t -> z=(z/t)*t -> z=z aqui se utilizo el seno del angulo conosido ya que relacionaba z
             con la hipotenusa menor t que ya tenemos, lo que nos permite despejarla */
            double z = Math.Sin(crad) * t;
            /* obtener y: desde el triangulo menor, se observa que t^2=y^2+z^2 -> despejando y -> y =raiz de t al cuadrado menos z al cuadrado */
            double y = Math.Sqrt(Math.Pow(t,2) - Math.Pow(z,2));
            /* obtener x,: para esto planteamos que en el triangulo mayor, aplicando pitagoras quedaria w^2=(x+y)^2+z^2, despejando x en wolframe queda
             x= (sqrt(w^2-z^2))-y*/
            double x = Math.Sqrt(Math.Pow(w,2) - Math.Pow(z,2)) - y;

            x = Math.Round(x, 2); 

            Console.WriteLine("El cateto x mide = " + x + " unidades");

        }
    }
}
