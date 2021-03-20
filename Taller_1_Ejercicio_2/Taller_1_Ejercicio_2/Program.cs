using System;

namespace Taller_1_Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
			string n;
			double d;
			Console.WriteLine("Ingrese un numero:");
			n = Console.ReadLine();
			double d = double.Parse(n);
			for (int j = 2; i < 10; i++)
			{d=j;
				for (int i = 1; i < 11; i++)
				{
					Console.WriteLine(d+"*"+i+"="+d*i);
				}
			}
			
		}
    }
}
