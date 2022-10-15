using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHPracticaExamen1
{
    internal class Interfaces
    {
        /*Con las interfaces obligamos a los programadores a mantener un order de procedimientos 
         *especificos para ciertas areas. Que se apeguen a ciertos patrones

         
         */
        public interface ICaja1
        {

            void tarjetasCredito();

            void tarjetaDebito();
            void tarjetaPrepago();

        }
        
       public interface ICaja2
        {

            void bonos();

            void emisionChequera();
        }

       public interface ICaja3
        {
            void hipotecas();
            void prestamosAuto();
        }
    }
}
