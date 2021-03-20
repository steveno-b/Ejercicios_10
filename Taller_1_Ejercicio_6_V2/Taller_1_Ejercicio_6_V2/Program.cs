using System;

namespace Taller_1_Ejercicio_6_V2
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] edad = { "12", "50", "23", "11", "18", "35", "41", "85", "16", "45" };
            string[] nombre = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
            string nomBus;
            
            string bandera2 = "s";
            Console.Clear();
            ImprimirVector(edad, " Edades ");
            ImprimirVector(nombre, " Nombres ");
            //Console.WriteLine("\n  Digite el nombre a buscar ");
            //nomBus = Console.ReadLine();
            


            

            while (bandera2 != "n") {
                Boolean bandera = false;
                Console.WriteLine("\n  Digite el nombre a buscar ");
                nomBus = Console.ReadLine();
                ValidarVacio(nomBus);

                while (bandera == false)
                {
                    if (ValidarVacio(nomBus) == false)
                    {
                        Console.WriteLine("Nombre no puede ser vacio ");
                        Console.WriteLine("\n  Digite el nombre a buscar ");
                        nomBus = Console.ReadLine();
                        ValidarVacio(nomBus);
                    }

                    else
                    {
                        bandera = true;
                    }
                }


                if (ExisteNombre(nombre, nomBus))
                {
                    Console.WriteLine(" El Usuario " + nomBus + " si existe y tiene " + edad[PosocionPersona(nombre, nomBus)] + " Anos de edad ");
                }
                else
                {
                    Console.WriteLine(" El Usuario " + nomBus + " No existe ");
                }

                Console.WriteLine("\n  ¿Desea salir? pulse cualquier tecla para continuar, de lo contrario pulse n ");
                string respuesta = Console.ReadLine();
                bandera2 = respuesta;

            }

        } 


        static void ImprimirVector(Array vector, string titulo)
        {
            Console.WriteLine("\n Arreglo " + titulo);

            foreach (string elemento in vector)
            {
                Console.Write(" [ " + elemento + " ] ");
            }
        }


        static bool ExisteNombre(Array vector, string persona)
        {
            bool existe = false;
            foreach (string elemento in vector)
            {
                if (elemento == persona)
                    existe = true;
            }
            return existe;
        }

        static int PosocionPersona(Array vector, string persona)
        {
            int indice = 0;
            int posicion = 0;
            foreach (string elemento in vector)
            {
                if (elemento == persona)
                {
                    posicion = indice;
                }
                indice++;
            }
            return posicion;
        }


        static bool ValidarVacio(string nomBusq)
        {
            Boolean bandera;
            {
                string nomBusq2 = nomBusq;
                if (String.IsNullOrEmpty(nomBusq))
                {
                    bandera = false;
                }

                else
                {
                    bandera = true;
                }
                //Console.WriteLine(bandera);
                return bandera;  
            }
            




        }
}
}
