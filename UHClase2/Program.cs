using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UHClase2
{
    internal class Program
    {
        static int n1, n2, total; //esta es una variable global tiene que estar fuera del main
        //puedo tener variables globales y locates que tengan el mismo nombre
        //Para distinguir una variable de una local de una global agregamos el Prefijo "Program.nombreVariable"
        static void Main(string[] args)
        {
            //Arreglos
            string[] vehiculos = new string[] { "audi", "honda", "nissan" };
            string[] vacunas = new string[10];
            char[][] matriz = new char[10][];



            for (int i = 0; i < vehiculos.Length; i++)


            menu();



        }

        public static void menu()
        {
            bool salir = true;
            byte opcion = 0;
            do
            {
                Console.WriteLine("Menu \n");
                Console.WriteLine("1 - Suma ");
                Console.WriteLine("2 - Resta");
                Console.WriteLine("3 - Multiplicacion");
                Console.WriteLine("Digite una opcion");
                opcion = byte.Parse(Console.ReadLine());
                switch (opcion)
                {

                    case 1:
                        ingresarValores();
                        Console.WriteLine(suma(n1, n2));
                        Console.Read();
                        break;
                    case 2: break;
                        ingresarValores();
                        Console.WriteLine(resta(n1, n2));
                        Console.Read();
                        break;
                    case 3: break;

                    default: Console.WriteLine("La opcion no exitste");
                        break;
                }
                

            } while (opcion != 3);
            

        }

        public static void ingresarValores()
        {
           Console.WriteLine("Digite un numero: ");
           n1 = int.Parse(Console.ReadLine());
           Console.WriteLine("Digite un numero: ");
           n2 = int.Parse(Console.ReadLine());
        }

        public static int suma(int dig1, int dig2 )// Parametros son locales
        { //Parametros son valores que reciben como referencia del main o alguna otra funcion.
            total = n1 + n2;
            return total;
        }

        public static int resta(int dig1, int dig2)// Parametros son locales
        { //Parametros son valores que reciben como referencia del main o alguna otra funcion.
            total = n1 - n2;
            return total;
        }
    }
}
