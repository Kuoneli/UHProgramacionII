namespace UHPracticaExamen1
{
    internal class ClsCajero3 : ClsCajero, Interfaces.ICaja3
    {
        public ClsCajero3()
        {
        }

        public ClsCajero3(string cedula, string nombre, string telefono, string direccion) : base(cedula, nombre, telefono, direccion)
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

        public void hipotecas()
        {

        }
        public void prestamosAuto()
        {


        }

    }
}
