using System;
using System.Collections.Generic;
namespace string_reto_intento_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // usuario digita frace, el programa dice en que posicion y cuantas veces esta  una palabra que tambien digita el ususario.
            //https://www.youtube.com/watch?v=jmmhU79UTtE
            Console.WriteLine("Ingrese frace");
            string frace = Console.ReadLine();
            Console.WriteLine("Ingrese PalabraBuscada a buscar");
            string palabraBuscada = Console.ReadLine();
            string fraceMayus = frace.ToUpper();
            int countador = 0, index =0  ;         
            List<int> posiciones = new List<int>();
            

            Console.WriteLine("Lista de palabras");
            string[] palabras = frace.Split(' ');

            for (int i = 0; i < palabras.Length; i++)
            {
                Console.WriteLine(i+": "+palabras[i]); 
            }
            //
            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i]==palabraBuscada)
                {
                    posiciones.Add(i);
                    countador++;
                    Console.WriteLine("Esta en la posicion: " + i);
                }
            }
            Console.WriteLine("La palabra esta " + countador + " veces");

           /* for (int i = 0; i < palabras.Length-1; i++) //si tiene una lista o una matriz a la que está accediendo en un bucle, el contador de bucle debe ser menor que el recuento de elementos:
            {
               
                Console.WriteLine("Esta en la posicion: "+posiciones[i]);
                if (posiciones.Count > countador) break;
            }
            */
            
        }
    }
}
