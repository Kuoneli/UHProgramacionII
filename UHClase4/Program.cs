using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UHClase4
{

    class Persona
    {
        public int cedula { get; set; }
        public string nombre { get; set; }
   
        public Persona() { }
        public Persona(int ced, string nomb)
        {
            cedula = ced;
            nombre = nomb;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

                //Diccionario sencillo creamos el diccionario <tipoDato, tipoDato> nombreDiccionario = new Diccionary <tipoDato, tipoDato>;
                Dictionary<int, String> ejemplo = new Dictionary<int, string>;

                ejemplo.Add(1, "Steven");
                ejemplo.Add(1, "Carlos");
                ejemplo.Add(1, "Jose");

                //Recorrer el diccionario
                foreach(var item in ejemplo)
            {
                Console.WriteLine($"Llave {ejemplo.Key} ,nombre: {ejemplo.Value}");
            }
                Console.Read();
                //
                Dictionary<String, String> provincias = new Dictionary<String, String>();
            { "SJ", "San Jose"}
            { "HE", "Heredia"}
            { "AL", "Alajuela"}
            //TryGetValue("Key" del elemento a buscar, out variable donde se guardara el dato)
            if(provincias.TryGetValue("HE", out String resultado))
            {
                Console.WriteLine(resultado)
            }
                //Cremos un diccionario conteniendo un Key(int) y de la Clase(Persona)
                Dictionary<int, Persona> persona = new Dictionary<int, Persona>();
                //Instancia de la Constructor vacio de la clase persona
                Persona p = new Persona();
                //Agregamos los datos persona(Diccionario).Add(1(Key), new Persona(creacionDeObjeto)
                persona.Add(1, new Persona(1, "Jose"));
                persona.Add(2, new Persona(9, "Catalina"));
                persona.Add(3, new Persona(7, "Sofia"));

                foreach (KeyValuePair<int, Persona> alumnos in persona)
                {
                    Console.WriteLine($"Llave {alumnos.Key} Cedula: {alumnos.Value.cedula} nombre: {alumnos.Value.nombre}");
                }

                Console.WriteLine("************************");

                Dictionary<int, int> numeros = new Dictionary<int, int>();
            {
                numeros.Add(1, 20);//<llave, dato>
                numeros.Add(2, 30);
                numeros.Add(3, 40);
            }
            //Con esto imprimimos cada uno de los valores del Diccionario y la llave(indice/posicion) el valor.
            foreach (var numero in numeros){

                Console.WriteLine($"Llave: {numero.Key}. Valor {numero.Value}");
                

            }
            {
}
            Console.Read();

        }
    }
}
