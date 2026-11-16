
namespace MaquinaCafe
{
    public class Cafetera
    {
        private int cantidadCafe;

        public Cafetera(int cantidadCafe)
        {
            this.cantidadCafe = cantidadCafe;
        }

        public void SetCantidadDeCafe(int cantidad)
        {
            cantidadCafe = cantidad;
        }

        public int GetCantidadCafe()
        {
            return cantidadCafe;
        }

        public bool HasCafe(int cantidad)
        {
            return cantidadCafe >= cantidad;
        }

        public void GiveCafe(int cantidad)
        {
            cantidadCafe -= cantidad;
        }
    }
}
