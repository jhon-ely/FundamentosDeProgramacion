using System;

namespace desafio_01_04_entrada_dby_salida_z
{
    class Program
    {
        static void Main(string[] args)
        {

            //desafio 01-04 entradas dby salida z

            // obtencion de datos
            Console.WriteLine("Escriba angulo d");
            double d = double.Parse(Console.ReadLine());
            double drad = d * (Math.PI / 180);

            Console.WriteLine("Escriba angulo b");
            double b = double.Parse(Console.ReadLine());
            double brad = b * (Math.PI / 180);

            Console.WriteLine("Escriba cateto y");
            double y = double.Parse(Console.ReadLine());

            /* calcular e: El triangulo que contiene el angulo e esta formado por los angulos e,d,b,
            la suma de ellos da 180, ya que estamos en radianes, se expresara como Pi, al cual se le restara los otros dos, para hallar e */
            double e = Math.PI - drad - brad;

            /* calcular c: el angulo c, se encuentra en la base del triangulo junto a e, formando juntos un angulo de 180 grados
             , por ende se le restara a estos 180 en angulo e, para hallar c*/
            double c = Math.PI - e;

            /* calcular z: para calcular este cateto, se hara referencia a el por medio de Tan de C quedando y/z pues tan=co/ca,
              para quitar el z del ca se multiplicara por este ya que es el mismo y, a continuacion la demostracion z=(tan(c))(y) -> z= (z/y)*y -> z=z )*/
            double z = Math.Tan(c) * y;
            z = Math.Round(z,2);
            Console.WriteLine("el acteto z es de " + z +  " unidades");


        }
    }
}
