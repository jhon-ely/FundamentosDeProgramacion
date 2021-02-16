using System;

namespace casa1
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.youtube.com/watch?v=YINa-vnxetk
            string answer = "si";
            int puntosdetiro = 0;
            int puntos = 0;
            int vecesquesaliomasdeseis = 0;
            int veces = 0;
            int sacopar = 0;
           

            while (answer=="si" && puntos <100 ) { 
            Random aleatorio = new Random();
                int dadoA;
                int dadoB;
                dadoA = aleatorio.Next(1,7);
                dadoB = aleatorio.Next(1,7);
                //dadoA = 1;
                //dadoB = 1;
                 
                Console.WriteLine("dadoA: "+dadoA);
            Console.WriteLine("dadoB: "+dadoB);
            puntosdetiro = dadoA + dadoB;
                if ( 3<4 && dadoA==dadoB) { sacopar++;}
                if (puntosdetiro > 6) { vecesquesaliomasdeseis ++; }
                    veces++; 
            puntos = puntos + puntosdetiro;
                if (dadoA==1 && dadoB==1)
                {
                 Console.WriteLine("Usted ha perdido al sacar  1 en ambos dados");
                 answer = "no"; 
                }

                Console.WriteLine("Su total de lanzamiento: "+ puntosdetiro);
                Console.WriteLine("Su total hasta los tiros actuales: " + puntos);
                Console.WriteLine("nro de tiro " + veces);
                if (puntos >= 100) { Console.WriteLine("Usted ha ganado"); answer = "no"; }

                else if (sacopar==3) 
                { 
                    answer = "no";
                    Console.WriteLine(" saco tres veces par, ha ganado ");
                }
                else if (puntosdetiro != 2) {
                    Console.WriteLine("¿desea tirar los dados una vez mas? si/no");
                    answer = Console.ReadLine(); 
                }                             
            }

            int tirosrealizados= veces ;
            Console.WriteLine("Tiros realizados: " + tirosrealizados);
            Console.WriteLine("de los cuales: " + vecesquesaliomasdeseis + " salieron > 6");
            double porcentajetirosmayoigualesseis = (100* vecesquesaliomasdeseis) /tirosrealizados;
            Console.WriteLine("de los tiros realizados un " + porcentajetirosmayoigualesseis +  " % " +  " fueron mayores a seis");






        }
    }
}
