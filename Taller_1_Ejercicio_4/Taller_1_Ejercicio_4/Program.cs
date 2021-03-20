using System;

namespace Taller_1_Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
			string n;
			int d;
			int mod;
			Boolean bandera=true;
			Console.WriteLine("Ingrese un numero:");
			n = Console.ReadLine();
			d = int.Parse(n);


			for (int i = 2; i <= d-1; i++)
			{
				mod = (d%i);
				

				if (mod == 0)
                {
					bandera = false;
				}

				
			}

			if (bandera==true)
			{
				Console.WriteLine("Numero es primo");
			}
			else
			{
				Console.WriteLine("Numero no es primo");
			}





		}
    }
}
