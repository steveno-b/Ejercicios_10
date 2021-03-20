using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace AppListObjetos
{
    class Program
    {
        static Validaciones Vericar = new Validaciones(); //intaciar la clase para crear objeto
        static List<Empleado> ListaEmpleados = new List<Empleado>();

      

        static void Main(string[] args)
        {
            int OpcMen;
            int opc1;

            string temporal;


            //-------------------
            do
            {
                bool EntradaValida = false;
                Console.Clear();
                gui.Marco(1, 110, 1, 25);
                gui.BorrarLinea(40, 22, 80);
                Console.SetCursorPosition(40, 5); Console.Write("*** Aplicación 1 *** ");
                gui.Linea(40, 80, 6);
                Console.SetCursorPosition(40, 7); Console.Write("1. Quienes somos");
                Console.SetCursorPosition(40, 8); Console.Write("2. Menu aplicaciones");
                Console.SetCursorPosition(40, 12); Console.Write("0. Salir");
                do
                {
                    gui.BorrarLinea(40, 15, 80);
                    Console.SetCursorPosition(40, 15); Console.Write("Escoja Opcion: ");
                    temporal = Console.ReadLine();
                    if (!Vericar.Vacio(temporal))
                        if (Vericar.TipoNumero(temporal))
                            EntradaValida = true;
                } while (!EntradaValida);

            } while (temporal=="1" || temporal == "2");



            do
            {
                bool EntradaValida = false;
                Console.Clear();
                gui.Marco(1,110,1,25);
                gui.BorrarLinea(40, 22, 80);
                Console.SetCursorPosition(40, 5);Console.Write("*** Menu Principal * ");
                gui.Linea(40, 80, 6);
                Console.SetCursorPosition(40, 7); Console.Write("1. Insertar Empleado");
                Console.SetCursorPosition(40, 8); Console.Write("2. Listar Empleados");
                Console.SetCursorPosition(40, 9); Console.Write("3. Buscar Empleados");
                Console.SetCursorPosition(40, 10); Console.Write("8 Leer Archivo Disco");
                Console.SetCursorPosition(40, 11); Console.Write("9. Guardar Archivo en Disco");
                Console.SetCursorPosition(40, 12); Console.Write("0. Salir");
              
            
                do
                {
                    gui.BorrarLinea(40, 15, 80);
                    Console.SetCursorPosition(40, 15);Console.Write("Escoja Opcion: ");
                    temporal = Console.ReadLine();
                    if (!Vericar.Vacio(temporal))
                        if (Vericar.TipoNumero(temporal))
                            EntradaValida = true;
                } while (!EntradaValida);

               
                OpcMen = Convert.ToInt32(temporal);

                switch (OpcMen)
                {
                    case 1:
                        InsertarNombre();
                        break;
                    case 2:
                        ListarNombres();
                        break;
                    case 3:
                        BuscarNombre();
                        break;
                    case 8:
                        LeerArchivoXml();
                        break;
                    case 9:
                        EscrirArchivoXml();
                        break;
                    case 0:
                        {
                         gui.BorrarLinea(40, 22, 80);
                        Console.SetCursorPosition(40, 22); Console.Write(" ... Gracias por usar el programa");
                        }
                        break;
                    default:
                        { gui.BorrarLinea(40, 22, 80); 
                        Console.SetCursorPosition(40, 22); Console.Write(" Opcion Invalida");
                        }
                        break;

                }
                gui.BorrarLinea(40, 23, 80);
                Console.SetCursorPosition(40, 23); Console.Write("presione cualquier tecla para continuar");
                Console.ReadKey();
            } while (OpcMen > 0);



        }
        static void InsertarNombre()
        {
            bool EntradaValidaNombre = false;
            bool EntradaValidaCodigo = false;
            bool EntradaValidaSalario = false;
            bool EntradaValidaCaja = false;

            string codigo;
            string nombre;
            string salario;
            string caja;

            Console.Clear();
            gui.Marco(1, 110, 1, 25);
            Console.SetCursorPosition(40, 5); Console.WriteLine("Insertardo empleado");
            gui.Linea(40, 6, 30);

            // .................................... ..validaciones
            do // pedir el codigo
            {
                gui.BorrarLinea(34, 8, 64);
                Console.SetCursorPosition(10, 8); Console.Write("Digite Codigo Empleado: ");
                codigo = Console.ReadLine();
                if (!Vericar.Vacio(codigo))
                    if (Vericar.TipoNumero(codigo))
                        EntradaValidaCodigo = true;
            } while (!EntradaValidaCodigo);

            if (!Existe(Convert.ToInt32(codigo))) {  // inicia el if del existe

                do // pedir el nombre
            {
                    gui.BorrarLinea(33, 9, 64);
                    Console.SetCursorPosition(10, 9); Console.Write("Digite Nombre Empleado:");
                nombre = Console.ReadLine();
                if (!Vericar.Vacio(nombre))
                    if (Vericar.TipoTexto(nombre))
                        EntradaValidaNombre = true;
            } while (!EntradaValidaNombre);

            do // pedir el salario
            {
                    gui.BorrarLinea(37, 10, 64);
                    Console.SetCursorPosition(10, 10); Console.Write("Digite Salario Empleado: ");
                salario = Console.ReadLine();
                if (!Vericar.Vacio(salario))
                    if (Vericar.TipoNumero(salario))
                        EntradaValidaSalario = true;
            } while (!EntradaValidaSalario);

            do // pedir el caja
            {
                    gui.BorrarLinea(34, 11, 64);
                    Console.SetCursorPosition(10, 11); Console.Write("Empleado Tiene Caja Compensacion S/N");
                caja = Console.ReadLine();
                if (!Vericar.Vacio(caja))
                    if (Vericar.sino(caja))
                        EntradaValidaCaja = true;
            } while (!EntradaValidaCaja);
                //..........................................





                Empleado myEmpleado = new Empleado(); // creo el objeto  myEmpledo
            myEmpleado.Codigo = Convert.ToInt32(codigo);
            myEmpleado.Nombre = nombre;
            myEmpleado.Salario = Convert.ToInt32(salario);
            if (caja.ToLower() == "s")
                myEmpleado.Caja = true;
            else
                myEmpleado.Caja = false;

           
                ListaEmpleados.Add(myEmpleado);
            }  // cierra el si exisete 
            else
                Console.WriteLine("El usuario con el codigo " + codigo + " Ya Existe en el sistema");

        }

        static void ListarNombres()
        {
            Console.Clear();
            gui.Marco(1, 110, 1, 25);
            Console.SetCursorPosition(40, 2); Console.Write(" Cantidad de Empleados" + ListaEmpleados.Count);
            int altura = 6;
            gui.Linea(3, 107, 3);

            Console.SetCursorPosition(2, 5); Console.Write("CODIGO");
            Console.SetCursorPosition(10, 5); Console.Write("NOMBRE");
            Console.SetCursorPosition(30, 5); Console.Write("SALARIO");
            Console.SetCursorPosition(42, 5); Console.Write("BASE COT.");
            Console.SetCursorPosition(52, 5); Console.Write("EPS");
            Console.SetCursorPosition(62, 5); Console.Write("PENSION");
            Console.SetCursorPosition(72, 5); Console.Write("ARL");
            Console.SetCursorPosition(82, 5); Console.Write("CAJA");
            Console.SetCursorPosition(92, 5); Console.Write("TOTAL");


            foreach (Empleado ObjetoEmpleado in ListaEmpleados)
            {


                Console.SetCursorPosition(2, altura); Console.Write(ObjetoEmpleado.Codigo);
                Console.SetCursorPosition(10, altura); Console.Write(ObjetoEmpleado.Nombre);
                Console.SetCursorPosition(30, altura); Console.Write(ObjetoEmpleado.Salario);
                parafiscales(ObjetoEmpleado.Salario, ObjetoEmpleado.Caja, altura);
            
                altura++;
            }

        }

        static void BuscarNombre()
        {
            string codigo;
            bool EntradaValidaCodigo = false;

            Console.Clear();
            gui.Marco(1, 110, 1, 25);
            Console.SetCursorPosition(40, 5); Console.WriteLine("Insertardo empleado");
            gui.Linea(40, 6, 30);

            do // pedir el codigo
            {
                gui.BorrarLinea(34, 8, 64);
                Console.SetCursorPosition(10, 8); Console.Write("Digite Codigo Empleado");
                codigo = Console.ReadLine();
                if (!Vericar.Vacio(codigo))
                    if (Vericar.TipoNumero(codigo))
                        EntradaValidaCodigo = true;
            } while (!EntradaValidaCodigo);

            if (Existe(Convert.ToInt32(codigo)))
            {
                Empleado myEmpleado = ObtenerDatos(Convert.ToInt32(codigo));

                int altura = 11;
                gui.Linea(3, 107, 9);
                gui.Linea(3, 107, 12);

                Console.SetCursorPosition(2, 10); Console.Write("CODIGO");
                Console.SetCursorPosition(10, 10); Console.Write("NOMBRE");
                Console.SetCursorPosition(30, 10); Console.Write("SALARIO");
                Console.SetCursorPosition(42, 10); Console.Write("BASE COT.");
                Console.SetCursorPosition(52, 10); Console.Write("EPS");
                Console.SetCursorPosition(62, 10); Console.Write("PENSION");
                Console.SetCursorPosition(72, 10); Console.Write("ARL");
                Console.SetCursorPosition(82, 10); Console.Write("CAJA");
                Console.SetCursorPosition(92, 10); Console.Write("TOTAL");

                Console.SetCursorPosition(2, altura); Console.Write(myEmpleado.Codigo);
                Console.SetCursorPosition(10, altura); Console.Write(myEmpleado.Nombre);
                Console.SetCursorPosition(30, altura); Console.Write(myEmpleado.Salario);
                parafiscales(myEmpleado.Salario, myEmpleado.Caja, altura);

               
            }
            else { 
                gui.BorrarLinea(40, 22, 80);
            Console.SetCursorPosition(40, 22); Console.Write(" El usuario del codigo " + codigo + " No existe");
            }





        }

        static bool Existe(int cod)
        {
            bool aux = false;

            foreach (Empleado myEmpleado in ListaEmpleados)
            {
                if (myEmpleado.Codigo == cod)
                    aux = true;
            }
            return aux;
        }

        static Empleado ObtenerDatos(int cod)
        {
            foreach (Empleado myEmpleado in ListaEmpleados)
            {
                if (myEmpleado.Codigo == cod)
                    return myEmpleado;
            }
            return null;

        }

        static void EscrirArchivoXml()
        {
            XmlSerializer codificador = new XmlSerializer(typeof(List<Empleado>));
            TextWriter escribirXml = new StreamWriter("D:/datosapp/ArchivoEmpleados.xml");
            codificador.Serialize(escribirXml, ListaEmpleados);
            escribirXml.Close();

            gui.BorrarLinea(40, 22, 80);
            Console.SetCursorPosition(40, 22); Console.Write(" Archivo guardado con exito .... ");
        }

        static void LeerArchivoXml()
        {
            if (File.Exists("D:/datosapp/ArchivoEmpleados.xml")) {
            ListaEmpleados.Clear();
            XmlSerializer codificador = new XmlSerializer(typeof(List<Empleado>));
            FileStream leerXml = File.OpenRead("D:/datosapp/ArchivoEmpleados.xml");
            ListaEmpleados = (List<Empleado>)codificador.Deserialize(leerXml);
            leerXml.Close();
        }


            gui.BorrarLinea(40, 22, 80);
            Console.SetCursorPosition(40, 22); Console.Write(" Archivo cargad0 con exito .... ");
        }


        static void parafiscales (int salario , bool caja, int altura)
        {
            Double baseCotizacion;
            Double eps;
            Double pension;
            Double arl;
            Double cajaCompesancion=0;
           
            // calculos
            baseCotizacion = salario * 0.4;
            if (baseCotizacion <= 908000)
                baseCotizacion = 908000;
            eps = baseCotizacion * 0.12;
            pension = baseCotizacion * 0.16;
            arl = baseCotizacion * 0.0052;
            if (caja)
                cajaCompesancion = baseCotizacion * 0.04;

            Double total = eps + pension + arl + cajaCompesancion;
            Console.SetCursorPosition(42, altura); Console.Write(baseCotizacion);
            Console.SetCursorPosition(52, altura); Console.Write(eps);
            Console.SetCursorPosition(62, altura); Console.Write(pension);
            Console.SetCursorPosition(72, altura); Console.Write(arl.ToString("#.#"));
            Console.SetCursorPosition(82, altura); Console.Write(cajaCompesancion);
            Console.SetCursorPosition(92, altura); Console.Write(total);

            
           
        }

    }
}
