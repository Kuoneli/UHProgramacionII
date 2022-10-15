using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UHClase2
{
    internal class Vehiculo
    {
        public string color { get; set; }
        public string name { get; set; } //global
        public int anhio { get; set; } //global

        public Vehiculo(string color, string name, int anhio ) //Constructor
        {
            this.color = color;
            this.name = name;
            this.anhio = anhio;
        }       

        public Vehiculo(){}


        ///Get es una funcion - Set es un procedimiento

        public void setColor(string color)
        {
            this.color = color;
        }
        public string getColor()
        {
            return this.color;  
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public void setAnhio(int anhio)
        {
            this.anhio = anhio;
        }
        public int getAnhio()
        {
            return this.anhio;
        }







    }
}
