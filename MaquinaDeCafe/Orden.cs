

namespace MaquinaDeCafe
{
    internal class Orden
    {
        public TamanoVaso Tamano { get; }
        public int CucharadasAzucar { get; }

        public Orden(TamanoVaso tamano, int cucharadasAzucar)
        {
            Tamano = tamano;
            CucharadasAzucar = cucharadasAzucar;
        }
    }
}
