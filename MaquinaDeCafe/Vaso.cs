

namespace MaquinaDeCafe
{
    public enum TamanoVaso { Pequeño = 3, Mediano = 5, Grande = 7 }

    public class Vaso
    {
        public TamanoVaso Tamano { get; private set; }

        public Vaso(TamanoVaso tamano)
        {
            Tamano = tamano;
        }
    }
}
