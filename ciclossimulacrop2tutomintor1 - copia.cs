using System;

namespace ciclossimulacrop2tutomintor1
{
    class Program
    {
        static void Main(string[] args)
        {

            // https://www.youtube.com/watch?v=fYPQkXHP5W4
            int contador1s = 0;
            int vidas = 3;
            string answer="s";
            int acomulados = 0;
            int turno = 0;
            int especiales = 0;
            int dado = 0;
            int dadox = 0;

           
            //-----------------------------------------------------------------
            while (vidas>0  && acomulados<=100 && (answer == "s"|| answer == "esp")) 
            {
                
                Random aleatorio = new Random();
                Console.WriteLine("maximo de vidas 3");
                
                Console.WriteLine("¿lanzar los dados? s/n/esp");
                answer = Console.ReadLine();

               

                if (answer=="esp"&& especiales<2) 
                {
                    dado = aleatorio.Next(1, 13);
                    turno++;
                    Console.WriteLine("dado: " + dado);
                    acomulados = acomulados + dado;
                    Console.WriteLine("puntos acomulados: " + acomulados);
                    especiales++;
                    Console.WriteLine("Ya usaste "+especiales+"/2 especiales");
                }

                if (answer == "s" )
                {

                    dado = aleatorio.Next(1, 7);
                    turno++;
                    Console.WriteLine("dado: " + dado);
                    acomulados = acomulados + dado;
                    Console.WriteLine("puntos acomulados: " + acomulados);


                }
                
                if (answer == "n")
                {
                    Console.WriteLine("Saliste de el juego");
                    break;
                }

                if (dado == 1)
                {
                    contador1s++;
                    Console.WriteLine("llevas " + contador1s + " unos"); //borrar al final
                }
                if (contador1s == 2)
                {
                    vidas = vidas - 1;
                    acomulados = acomulados - 10;
                    contador1s = 0;
                    Console.WriteLine("perdiste una vida\nvidas actuales " + vidas + "\nmenos 10 puntos " + "\n acomulados " +acomulados);
                }

                //
                if (dado == 6)
                {


                    Console.WriteLine("¿lanzar los dados? s/n/esp");
                    answer = Console.ReadLine();
                    if (answer == "s")
                    {

                        dadox = aleatorio.Next(1, 7);
                        turno++;
                        Console.WriteLine("dado: " + dadox);
                        acomulados = acomulados + dadox;
                        Console.WriteLine("puntos acomulados: " + acomulados);
                        if (dadox == 6)
                        {
                            vidas = vidas + 1;
                            Console.WriteLine("Ganaste una vida al sacar dos veces consecutivas 6 \ntus vidas actuales son: " + vidas);
                            if (vidas > 3)
                            {
                                vidas = vidas - 1;
                                Console.WriteLine("el maximo de vidas es 3");
                            }
                            
                        }
                    }
                    if (answer == "esp"&&especiales<2)
                    {
                        dadox = aleatorio.Next(1, 13);
                        turno++;
                        Console.WriteLine("dado: " + dadox);
                        acomulados = acomulados + dadox;
                        Console.WriteLine("puntos acomulados: " + acomulados);
                        especiales++;
                        Console.WriteLine("Ya usaste " + especiales + "/2 especiales");
                        if (dadox == 6)
                        {
                            vidas = vidas + 1;
                            Console.WriteLine("Ganaste una vida al sacar dos veces consecutivas 6 \ntus vidas actuales son: " + vidas);
                            if (vidas > 3)
                            {
                                vidas = vidas - 1;
                                Console.WriteLine("el maximo de vidas es 3");
                            }
                        }

                    }
                }
                //

                if (acomulados > 100)
                {
                    Console.WriteLine("Ganaste, acomulaste mas de 100 puntos");
                    break;
                }

               

            }
            //-----------------------------------------------------------------




        }
    }
}

