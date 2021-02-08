using System;

namespace switch_y_case_tipos_de_contrato
{
    class Program
    {
        static void Main(string[] args)

        // tipo de contrato usando swtich-case
        //https://www.youtube.com/watch?v=ANEv8gF47T4
        {
            Console.WriteLine("Ingrese su salario mensual: ");

            int salariom = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su tipo de contato:" + " (1) Dependiente." + " (2) para Independiente ");
            int tipoContrato = int.Parse(Console.ReadLine());

            int sml = 877802;
            double basecot = salariom * 0.4; 
            if (basecot < sml) basecot = sml;
            
            switch (tipoContrato) {


            case 1:
                    double pension = basecot * 0.04;
                    double eps = basecot * 0.04;
                    double prima = salariom;
                    double salarioreal = salariom - (pension + eps);
                    double salarioanual = (salarioreal * 12) + (prima);

                    Console.WriteLine("Salario real: " + salarioreal + ",Salario anual : " + salarioanual);
                    Console.WriteLine("EPS: " + eps + ",Pensión:" + pension);
                    double dedu = eps + pension;
                    Console.WriteLine("Deducciones: " + dedu);

                    break;
               
                default:
                    Console.WriteLine("Ingrese su grado de riesgo laboral del 1 al 5: ");
                    int riesgo = int.Parse(Console.ReadLine());

                    switch (riesgo) {

                        case 1:
                            double pension1 = basecot * 0.16;
                            double eps1 = basecot * 0.125;
                            double arl1 = basecot * 0.00522;
                            double salarioreal1 = salariom - (pension1 + eps1 + arl1);
                            double salarioanual1 = (salarioreal1 * 12);
                            double dedu1 = eps1 + pension1+arl1;
                            Console.WriteLine("Deducciones: " + dedu1);

                            Console.WriteLine("Salario real : " + salarioreal1 + ",Salario anual : " + salarioanual1);
                            Console.WriteLine("ARL: " + arl1 + " ,EPS: " + eps1 + " ,Pensión: " + pension1);

                            break;

                        case 2:
                            double pension2 = basecot * 0.16;
                            double eps2 = basecot * 0.125;
                            double arl2 = basecot * 0.01044;
                            double salarioreal2 = salariom - (arl2 + pension2 + eps2);
                            double salarioanual2 = (salarioreal2 * 12);
                            double dedu2 = eps2 + pension2+arl2;
                            Console.WriteLine("Deducciones: " + dedu2);

                            Console.WriteLine("Salario real : " + salarioreal2 + ",Salario anual : " + salarioanual2);
                            Console.WriteLine("ARL:" + arl2 + ",EPS: " + eps2 + ",Pensión:" + pension2);
                            break;

                        case 3:
                            double pension3 = basecot * 0.16;
                            double eps3 = basecot * 0.125;
                            double arl3 = basecot * 0.02436;
                            double salarioreal3 = salariom - (arl3 + pension3 + eps3);
                            double salarioanual3 = (salarioreal3 * 12);
                            double dedu3 = eps3 + pension3+arl3;
                            Console.WriteLine("Deducciones: " + dedu3);

                            Console.WriteLine("Salario real : " + salarioreal3 + ",Su salario anual : " + salarioanual3);
                            Console.WriteLine("ARL:" + arl3 + ",EPS: " + eps3 + ",Pensión:" + pension3);
                            break;

                        case 4:
                            double pension4 = basecot * 0.16;
                            double eps4 = basecot * 0.125;
                            double arl4 = basecot * 0.04350;
                            double salarioreal4 = salariom - (arl4 + pension4 + eps4);
                            double salarioanual4 = (salarioreal4 * 12);
                            double dedu4 = eps4 + pension4+arl4;
                            Console.WriteLine("Deducciones: " + dedu4);

                            Console.WriteLine("Salario real : " + salarioreal4 + ",Salario anual : " + salarioanual4);
                            Console.WriteLine(" ARL:" + arl4 + ",EPS: " + eps4 + ",Pensión:" + pension4);
                            break;

                      case 5:
                            double pension5 = basecot * 0.16;
                            double eps5 = basecot * 0.125;
                            double arl5 = basecot * 0.0696;
                            double salarioreal5 = salariom - (arl5 + pension5 + eps5);
                            double salarioanual5 = (salarioreal5 * 12);
                            double dedu5 = eps5 + pension5+arl5;
                            Console.WriteLine("Deducciones: " + dedu5);

                            Console.WriteLine("Salario real : " + salarioreal5 + ",Salario anual : " + salarioanual5);
                            Console.WriteLine(" ARL:" + arl5 + ",EPS: " + eps5 + ",Pensión:" + pension5); 
                            break;
                    

                    }

                    break;




            }


        }



    }






}






    

                  





            



















