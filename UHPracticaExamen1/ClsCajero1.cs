namespace UHPracticaExamen1
{
    internal class ClsCajero1 : ClsCajero, Interfaces.ICaja1
    {
        public ClsCajero1()
        {
        }

        public ClsCajero1(string cedula, string nombre, string telefono, string direccion) : base(cedula, nombre, telefono, direccion)
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
        public void tarjetasCredito()
        {

        }

        public void tarjetaDebito()
        {

        }
        public void tarjetaPrepago()
        {

        }

    }
}
