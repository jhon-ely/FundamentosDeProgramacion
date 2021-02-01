using System;

namespace Evaluacióndeprácticatiposdecontrato
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedir datos
            Console.WriteLine("Ingrese su salario mensual");
            double salariomensual = double.Parse(Console.ReadLine());
            double smmlv = 908526;
            double basedecotizacion = 0;
            Console.WriteLine("digite (1) para tipo de contrato Dependiente");
            Console.WriteLine("digite (2) para tipo de contrato Independiente");
            int tipodecontrato = int.Parse(Console.ReadLine());
            // si la base de cotización es menor al SMMLV, la base de cotización pasa a ser el SMMLV.
            if (salariomensual >= smmlv) 
            {
                basedecotizacion = salariomensual * 0.4;
                Console.WriteLine("base de cotizacion es de " + basedecotizacion);
            }
            if (salariomensual < smmlv)
            {
                basedecotizacion = smmlv;
                Console.WriteLine("base de cotizacion es de " + basedecotizacion);
            }
            // independiente

            if (tipodecontrato == 2)
            {    //pedir clase riesgo
                Console.WriteLine("Esciba su clase de riesgo ");
                double clasederiesgo = double.Parse(Console.ReadLine());
                // calcular pension y eps
                double pension = basedecotizacion * 16 / 100;
                Console.WriteLine("pension es de " + pension);
                double eps = basedecotizacion * 12.5 / 100;
                Console.WriteLine("EPS es de " + eps);
                // calcular dependiendo del riesgo arl,deducciones,salario real,salario anual
                if (clasederiesgo == 1)
                {
                    double arl = basedecotizacion * 0.522 / 100;
                    Console.WriteLine("ARL " + arl);
                    double deducciones = eps + pension + arl;
                    Console.WriteLine("deducciones " + deducciones);
                    double salarioreal = salariomensual - deducciones;
                    Console.WriteLine("su salario real es de " + salarioreal);
                    double salarioanual = salarioreal * 12;
                    Console.WriteLine("su salario anual es de " + salarioanual);
                }
                if (clasederiesgo == 2)
                {
                    double arl = basedecotizacion * 1.044 / 100;
                    Console.WriteLine("ARL " + arl);
                    double deducciones = eps + pension + arl;
                    Console.WriteLine("deducciones " + deducciones);
                    double salarioreal = salariomensual - deducciones;
                    Console.WriteLine("su salario real es de " + salarioreal);
                    double salarioanual = salarioreal * 12;
                    Console.WriteLine("su salario anual es de " + salarioanual);
                }
                if (clasederiesgo == 3)
                {
                    double arl = basedecotizacion * 2.436 / 100;
                    Console.WriteLine("ARL" + arl);
                    double deducciones = eps + pension + arl;
                    Console.WriteLine("deducciones " + deducciones);
                    double salarioreal = salariomensual - deducciones;
                    Console.WriteLine("su salario real es de " + salarioreal);
                    double salarioanual = salarioreal * 12;
                    Console.WriteLine("su salario anual es de " + salarioanual);
                }
                if (clasederiesgo == 4)
                {
                    double arl = basedecotizacion * 4.350 / 100;
                    Console.WriteLine("ARL " + arl);
                    double deducciones = eps + pension + arl;
                    Console.WriteLine("deducciones " + deducciones);
                    double salarioreal = salariomensual - deducciones;
                    Console.WriteLine("su salario real es de " + salarioreal);
                    double salarioanual = salarioreal * 12;
                    Console.WriteLine("su salario anual es de " + salarioanual);
                }
                if (clasederiesgo == 5)
                {
                    double arl = basedecotizacion * 6.960 / 100;
                    Console.WriteLine("ARL " + arl);
                    double deducciones = eps + pension + arl;
                    Console.WriteLine("deducciones " + deducciones);
                    double salarioreal = salariomensual - deducciones;
                    Console.WriteLine("su salario real es de " + salarioreal);
                    double salarioanual = salarioreal * 12;
                    Console.WriteLine("su salario anual es de " + salarioanual);
                }
            }
                // dependiente
            else if(tipodecontrato==1)
            {
                int arl = 0;
                Console.WriteLine("ARL "+arl);

                double pension = (basedecotizacion * 4)/100;
                Console.WriteLine("pension es de " + pension);

                double eps = (basedecotizacion * 4)/100;
                Console.WriteLine("eps es de " + eps);

                double deducciones = eps+pension;
                Console.WriteLine("las deducciones son de " + deducciones);

                double salarioreal = salariomensual - deducciones;

                Console.WriteLine("su salario real es " + salarioreal);

                double salarioanual = salariomensual + salarioreal * 12;
                Console.WriteLine("su salario anual es de " + salarioanual);

            }
           



        }
    }
}
