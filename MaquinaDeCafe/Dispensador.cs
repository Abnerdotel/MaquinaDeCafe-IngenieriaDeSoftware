
namespace MaquinaDeCafe
{
    internal class Dispensador
    {
        private Cafetera cafetera;
        private Azucarero azucarero;

        public Dispensador(Cafetera cafetera, Azucarero azucarero)
        {
            this.cafetera = cafetera;
            this.azucarero = azucarero;
        }

        public  string ProcesarOrden(Orden orden)
        {
            int cantidadCafe = (int)orden.Tamano; 

            if (!cafetera.ServirCafe(cantidadCafe))
                return "No hay suficiente cafe.";

            if (!azucarero.ServirAzucar(orden.CucharadasAzucar))
                return "No hay suficiente azucar.";

            return $"Se ha servido un cafe {orden.Tamano} ({cantidadCafe} Oz) con {orden.CucharadasAzucar} cucharadas de azucar.";
        }

    }
}

