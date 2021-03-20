using System;

namespace Taller_1_Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {

			
			double d;
			
			
			for (int j = 2; j < 10; j++)
			{
				d = j;
				for (int i = 1; i < 11; i++)
				{
					Console.WriteLine(d + "*" + i + "=" + d * i);
				}
			}
		}
    }
}
