using System;

namespace Taller_1_Ejercicio_5_y_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] edad = { 12, 50, 23, 11, 18, 35, 41, 85, 16, 45 };
            string[] nombre = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
            int auxiliar;
            string auxiliar2;

            for (int ciclo = 1; ciclo <= edad.Length; ciclo++)
            {
                //---------------Menor------------------
                for (int i = 0; i < edad.Length - ciclo; i++)
                {
                    if (edad[i] > edad[i + 1])
                    {
                        auxiliar = edad[i];
                        edad[i] = edad[i + 1];
                        edad[i + 1] = auxiliar;

                        auxiliar2 = nombre[i];
                        nombre[i] = nombre[i + 1];
                        nombre[i + 1] = auxiliar2;
                    }

                }
                //-----------------------------------------------
            }

            
            {
                Console.WriteLine("El menor es "+ nombre[0]+" y el mayor es "+ nombre[nombre.Length-1]);
            }

            for(int ciclo = 1; ciclo <= edad.Length; ciclo++)
           {
                //---------------Mayor------------------
                for (int i = 0; i < edad.Length - ciclo; i++)
                {
                    if (edad[i] < edad[i + 1])
                    {
                        auxiliar = edad[i];
                        edad[i] = edad[i + 1];
                        edad[i + 1] = auxiliar;
                    }

                }
                //---------------------------------------------
            }

            

        }

    }
}


