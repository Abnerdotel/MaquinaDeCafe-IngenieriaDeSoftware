

namespace MaquinaDeCafe
{
    public class Azucarero
    {
        public int CantidadAzucar { get; private set; }

        public Azucarero(int cantidadInicial)
        {
            CantidadAzucar = cantidadInicial;
        }

        public bool ServirAzucar(int cucharadas)
        {
            if (CantidadAzucar >= cucharadas)
            {
                CantidadAzucar -= cucharadas;
                return true;
            }
            return false;
        }

        public void RecargarAzucar(int cantidad)
        {
            CantidadAzucar += cantidad;
        }
    }
}
