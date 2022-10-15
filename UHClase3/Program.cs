using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHClase3
{
    internal class Program
    {


        class vehiculo
        {
            public void viajar()
            {

                Console.WriteLine("Vija por ");
            }

        }
        class avion : vehiculo { 
            public void viajar()
            {
                Console.WriteLine("Vija por aire");
            }
        }
        class carro : vehiculo
        {
            public void viajar()
            {
                Console.WriteLine("Vija por pista");
            }
        }
        class electrico
        {
            public void viaja() { 
            
            }
     
        }

        enum color
        {
            verde,
            amarillo,
            rojo,
            azul

        }
        static void Main(string[] args)
        {
            avion Jet = new avion();
            vehiculo vehiculo = new vehiculo();
            carro mazda = new carro();
            electrico tesla = new electrico();
            //Polimorfismo
            Jet.viajar();
            vehiculo.viajar();
            mazda.viajar();
            Console.Read();

            color color = color.verde;
            Console.WriteLine();
            Console.Read();


        }
    }
}
