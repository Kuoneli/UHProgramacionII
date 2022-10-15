namespace UHPracticaExamen1
{
    internal class ClsCajero2 : ClsCajero, Interfaces.ICaja2
    {
        public ClsCajero2()
        {
        }

        public ClsCajero2(string cedula, string nombre, string telefono, string direccion) : base(cedula, nombre, telefono, direccion)
        {
        }

        ClsCajero cajero = new ClsCajero();

        public void abir()
        {
            cajero.abrirCaja();
        }
        public void cerrar()
        {
            cajero.cerrarCaja();
        }

       public void bonos()
        {


        }

        public void emisionChequera()
        {

        }

    }
}
