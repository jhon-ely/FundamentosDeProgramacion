using System;

namespace desafio_01_04_entrada_wdx_sallida_y
{
    class Program
    {
        static void Main(string[] args)
        {
            // desafio 01-04 entradas wdx salida y
            //obtener datos
            Console.WriteLine("Escriba hipotesua mayor W");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Escriba angulo d");
            double d = double.Parse(Console.ReadLine());
            double drad = d * (Math.PI / 180);
            Console.WriteLine("Escriba cateto x");
            double x = double.Parse(Console.ReadLine());
            //proceso

            /* La suma de los angolos del triangulo mayor es de 180 osea "pi" si trabajamos en radianes, esta suma viene de los angulos 
              d, que ya lo tenemos, un angulo de 90 grados que en radianes son pi/2 y otro que llamaremos "elotro", este se encontrara con el fin de
            referenciar y relacionar su cateto opuesto con la hipotenusa w que ya tenemos, a travez del seno, ya que en ese se encuentra "y" que
            es el que queremos encontrar*/
            double elotro = Math.PI - (Math.PI / 2) - drad;
            /* y=(sen(elotro)(w))-y   ->remplazando el seno->  y=((x+y)/w)(w))-x ->cancelando w -> y=(x+y)-y -> y=y */

            double y = (Math.Sin(elotro) * w) - x;
            y = Math.Round(y, 2);
            Console.WriteLine("El cateto y es de " + y + " unidades");
     
            
        }
    }
}
