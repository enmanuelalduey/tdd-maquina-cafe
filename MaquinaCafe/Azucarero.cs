
namespace MaquinaCafe
{
    public class Azucarero
    {
        private int cantidadDeAzucar;

        public Azucarero(int cantidadDeAzucar)
        {
            this.cantidadDeAzucar = cantidadDeAzucar;
        }

        public void SetCantidadDeAzucar(int cantidad)
        {
            cantidadDeAzucar = cantidad;
        }

        public int GetCantidadAzucar()
        {
            return cantidadDeAzucar;
        }

        public bool HasAzucar(int cantidad)
        {
            return cantidadDeAzucar >= cantidad;
        }

        public void GiveAzucar(int cantidad)
        {
            cantidadDeAzucar -= cantidad;
        }
    }
}
