using System;

namespace casa_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.youtube.com/watch?v=tH8DTlY4xIo
            string answer = "y";           
            int puntos = 0;
            int turno = 0;  
            
           while (answer=="y") {
             
            turno ++ ;
            Random aleatorio = new Random();
            int dado;
            dado = aleatorio.Next(1,13);
            puntos =dado+puntos;
               
            
            Console.WriteLine("El numerito generado es "+ dado);
            Console.WriteLine("puntos acomulados " + puntos);
            Console.WriteLine("Turno Nro:" + turno);
              if (turno > 3) {                              
                if ((dado % 2 ) == 0)
                {

                        if (dado == 12 && answer == "y")
                        {
                            Random aleatoriots = new Random();
                            int dadots;
                            dadots = aleatoriots.Next(1, 13);

                            //Console.WriteLine("El numerito generado fue: " + dadots);
                            if (dadots == 10) 
                            { Console.WriteLine("El numerito generado es " + dadots);
                                answer = "n"; Console.WriteLine("¡ganaste!");
                                Console.WriteLine("salio 10 luego de 12"); 
                            }

                        }

                        if (puntos < 100 && answer == "y" )
                    {
                        Console.WriteLine("desea volver a tirar: ? y/n");
                        answer = Console.ReadLine();
                    }
                    else if (answer=="y" && puntos >=100) 
                        { Console.WriteLine("supero o llego a los 100! ganaste ");
                          answer = "no"; 
                        }
                }
                else  
                    { Console.WriteLine("saco impar, you lose");
                    answer = "n"; }
              }

              else {
                    Console.WriteLine("se encuentra en turnos libres");
                    Console.WriteLine("desea volver a tirar= ? y/n");
                answer = Console.ReadLine();
              }


                if (dado==12 && answer == "y") 
                {
                    Random aleatoriots = new Random();
                    int dadots;
                    dadots = aleatoriots.Next(1, 13);                   
                    //Console.WriteLine("El numerito generado fue: " + dadots);
                    if (dadots == 10) 
                    { Console.WriteLine("El numerito generado es " + dadots ); 
                      answer = "n"; Console.WriteLine("¡ganaste!");
                        Console.WriteLine("salio 10 luego de 12"); 
                    }

                }

                

                

           }

        }
    }
}
