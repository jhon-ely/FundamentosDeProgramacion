using System;

namespace desafio_01_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // desafio 01_04 con b,z,y para hallar x
            //ingresar datos
            Console.WriteLine("escriba el angulo b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("escriba el cateto z");
            double z = double.Parse(Console.ReadLine());

            Console.WriteLine("escriba el cateto y");
            double y = double.Parse(Console.ReadLine());

            // calculando a: Tan(a)=co/ca -> tan(a)=y/z -> Atan(y/z)=a
            double a = Math.Atan(y / z);
            double agra = a*(180/Math.PI);
            // como a y b forman un angulo del triangulo grandote los sumaresmos en una variable llamada amasb
            double amasb = agra + b;
            double amasbgra = amasb * (Math.PI / 180);

            // sacando la x usamos tangente para relacionar el co con ca, cancelando el adyacente en la operacion y restando el y que no hace parte de x
            // x=(tan(a+b)*z)-y  -> x= tan(53.13)*3)-y  -> tan=(co/ca) -> (((x+2)/3)*3)-2 -> x=(x+2)-2 
            //usamos la expresion tangente para conectar el cateto donde se encontraba x, sin conoserla, pero si haciendo referencia al angulo al que era opuesto  
            double x = (Math.Tan(amasbgra) * z) - y;
            
            Console.WriteLine("x vale " + x);           

        }
    }
}
