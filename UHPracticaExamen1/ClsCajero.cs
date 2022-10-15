using System;
using System.Collections.Generic;

namespace UHPracticaExamen1
{

    public class ClsCajero
    {
        static int cant = 0;
        static int key = 0;
        private string cedula { get; set; }
        private string nombre { get; set; }
        private string telefono { get; set; }
        private string direccion { get; set; }

        public ClsCajero() { }

        public ClsCajero(string cedula, string nombre, string telefono, string direccion)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
        }
       
        public static void crearCajero()
        {
            Dictionary<int, ClsCajero> listaCajeros = new Dictionary<int, ClsCajero>();
            ClsCajero cajero = new ClsCajero();

            Console.WriteLine("Cuantos cajeros desea ingresar?");
            cant = int.Parse(Console.ReadLine());
            for (int i = 1; i <= cant; i++)
            {
                Console.WriteLine($"\nIngrese el nombre del Cajero {i}");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el numero de Cedula?");
                string cedula = Console.ReadLine();
                Console.WriteLine("Ingrese el numero de Telefono?");
                string telefono = Console.ReadLine();
                Console.WriteLine("Ingrese la dirreccion");
                string direccion = Console.ReadLine();

                listaCajeros.Add(i, new ClsCajero(cedula, nombre, telefono, direccion));
            }
            Console.WriteLine("\nIngreso el/los siguente cajeros");
            foreach (KeyValuePair<int, ClsCajero> item in listaCajeros)
            {
                Console.WriteLine($"Cajero ID {item.Key} \nCedula: {item.Value.cedula} \nNombre: {item.Value.nombre} \nDireccion: {item.Value.direccion} ");

            }
        }
        public void abrirCaja()
        {
            Console.WriteLine("La caja ha sido habierta");
            Console.Read();
        }

        public void cerrarCaja()
        {
            Console.WriteLine("La caja ha sido cerrada");
            Console.Read();

        }

        public void pagoServicios()
        {

            Console.WriteLine("Ha pagado los servicios seleccionados");
            Console.Read();

        }
        public void cambioCheques() 
        {
            Console.WriteLine("Ha cambiado un cheque");
            Console.Read();

        }

        public void depositos()
        {
            Console.WriteLine("Ha hecho un deposito");
            Console.Read();

        }

        public void asignarCajero()
        {
            Console.WriteLine("Asigno cajero a caja X");

            Console.Read();
        }

    }
}
