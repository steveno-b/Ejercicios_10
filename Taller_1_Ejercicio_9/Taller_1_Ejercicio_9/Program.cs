using System;

namespace Taller_1_Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double nterms,n1,n2,count,temp;

            Console.WriteLine("Cuantos terminos desea ver?");
            nterms= Convert.ToDouble(Console.ReadLine());


            

                
            n1 = 0;
            n2 = 1;
            count = 0;

               
            if (nterms <= 0) 
            {
                Console.WriteLine("Por favor ingrese un entero positivo");
            }
            if (nterms == 1)
            {
                Console.WriteLine("Serie de Fibonacci", nterms, ":");
                Console.WriteLine(n1);
            }
                   
            else
            {
                Console.WriteLine("Serie de Fibonacci:");
                while (count <= nterms)
                {


                    Console.WriteLine(n1);
                    temp = n1 + n2;

                    n1 = n2;
                    n2 = temp;
                    count++;

                }     

            }
        }
    }
}
