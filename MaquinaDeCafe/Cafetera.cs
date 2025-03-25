

namespace MaquinaDeCafe
{
    public class Cafetera
    {
        public int CantidadCafe { get; private set; }

        public Cafetera(int cantidadInicial)
        {
            CantidadCafe = cantidadInicial;
        }

        public bool ServirCafe(int cantidad)
        {
            if (CantidadCafe >= cantidad)
            {
                CantidadCafe -= cantidad;
                return true;
            }
            return false;
        }

        public void RecargarCafe(int cantidad)
        {
            CantidadCafe += cantidad;
        }
    }
}
