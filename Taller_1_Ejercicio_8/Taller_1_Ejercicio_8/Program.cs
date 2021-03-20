using System;
using System.Collections.Generic;

namespace Taller_1_Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba una palabra");
            string palabra = Console.ReadLine();
            List<char> list = new List<char>();
            int bandera = 0;
            int bandera2 = 0;

            foreach (char i in palabra)
            {
                list.Add(i);
            }
            foreach (var j in list)
            {
                Console.WriteLine(j);
            }

            for (int k = 0; k <= list.Count/2; k++)
            {
                if (list[k]==list[list.Count - k-1])
                {
                    bandera = 1 + bandera;
                }

                else
                {
                    bandera2 = 1 + bandera2;
                }

                //Console.WriteLine(bandera);
                //Console.WriteLine(bandera2);
            }

            if (bandera2 != 0)
            {
                Console.WriteLine("No es palindromo");
            }
           else
                {
                    Console.WriteLine("Es palindromo");
                }


}
}
}
