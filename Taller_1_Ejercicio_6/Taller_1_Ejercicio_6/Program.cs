using System;

namespace Taller_1_Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] edad = { "12", "50", "23", "11", "18", "35", "41", "85", "16", "45" };
            string[] nombre = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
            string nomBus;
            int pos=0;
            Boolean bandera = false;
            Console.WriteLine("\n  Digite el nombre a buscar ");
            nomBus = Console.ReadLine();

            for (int i = 0; i < nombre.Length-1; i++)
            {
                if (nombre[i] == nomBus)
                {
                    Console.WriteLine("Existe");
                    pos = i;
                    bandera = true;
                }
                

            }
            if (bandera == true)
            {
                Console.WriteLine("La edad de " + nombre[pos] + " es " + edad[pos]);
            }

            else
            {
                Console.WriteLine("No existe");
            }
        }
    }
}
