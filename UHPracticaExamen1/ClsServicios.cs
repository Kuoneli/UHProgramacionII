using System;
using System.Collections.Generic;

namespace UHPracticaExamen1
{
    enum riesgo
    {
        Bajo,
        Medio,
        Alto,

    }
    static class ClsServicios
    {
        private static Dictionary<int, string> servicios = new Dictionary<int, string>()
        {

            {1, "Servicios Publicos" },
             {2, "Cambio de Cheques" },
              {3, "Depositos" },
               {4, "Emision Tarjetas Debito, Credito y Prepago" },
                {5, "Emision Chequera" },
                 {6, "Creditos hipotecarios y prestamos para autos" },

        };
        //Best ways to create a Menu
        public static void listaServicios()
        {
            Console.WriteLine("Menu de Opciones");
            foreach (var servicio in servicios)
            {
                Console.WriteLine($"Opcion {servicio.Key} - {servicio.Value}");
            }
        }

        public static string consultaServicios(int codigo)
        {
            if (servicios.TryGetValue(codigo, out string servicio))
            {
                return "El servicio es: " + servicio;
            }
            else
            {
                return "El servicio no existe";
            }
        }

        public static void seleccionarServicio()
        {
            ClsCajero1 cajero1 = new ClsCajero1();
            ClsCajero2 cajero2 = new ClsCajero2();
            ClsCajero3 cajero3 = new ClsCajero3();
            listaServicios();                
            Console.WriteLine("Cual servicio desea utilizar?");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {

                case 1:
                    servicios.TryGetValue(1, out string servicio);
                    Console.WriteLine($"{servicio} ha sido seleccionado");
                    Console.ReadKey();

                    break;
                case 2:
                    servicios.TryGetValue(2, out  servicio);
                    Console.WriteLine($"{servicio} ha sido seleccionado");
                    Console.ReadKey();

                    break;
                case 3:
                    servicios.TryGetValue(3, out servicio);
                    Console.WriteLine($"{servicio} ha sido seleccionado");
                    Console.ReadKey();

                    break;
                case 4:
                    servicios.TryGetValue(4, out servicio);
                    Console.WriteLine($"{servicio} ha sido seleccionado");
                    Console.WriteLine(riesgo.Bajo);
                    Console.ReadKey();

                    break;
                case 5:
                    servicios.TryGetValue(5, out servicio);
                    Console.WriteLine($"{servicio} ha sido seleccionado");
                    Console.WriteLine(riesgo.Medio);
                    cajero2.emisionChequera();
                    Console.ReadKey();

                    break;
                case 6:
                    servicios.TryGetValue(6, out  servicio);
                    Console.WriteLine($"{servicio} ha sido seleccionado");
                    Console.WriteLine(riesgo.Alto);
                    cajero3.hipotecas();
                    cajero3.prestamosAuto();    
                    Console.ReadKey();
                   
                    break;
                default:
                    Console.WriteLine($"El servicio seleccionado no existe");
                    Console.ReadKey();

                    break;
            }

        }



    }
}
