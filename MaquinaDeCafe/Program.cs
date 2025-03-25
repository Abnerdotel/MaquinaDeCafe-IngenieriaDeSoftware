namespace MaquinaDeCafe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cafetera cafetera = new Cafetera(50);
            Azucarero azucarero = new Azucarero(20);
            Dispensador dispensador = new Dispensador(cafetera, azucarero);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Bienvenido a la máquina de cafe");
                Console.WriteLine("Seleccione el tamaño de su cafe:");
                Console.WriteLine("1. Pequeño (3 Oz)");
                Console.WriteLine("2. Mediano (5 Oz)");
                Console.WriteLine("3. Grande (7 Oz)");
                Console.Write("Ingrese una opción: ");

                TamanoVaso tamano;
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        tamano = TamanoVaso.Pequeño;
                        break;
                    case "2":
                        tamano = TamanoVaso.Mediano;
                        break;
                    case "3":
                        tamano = TamanoVaso.Grande;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida. Intente de nuevo.");
                        continue;
                }

                Console.Write("Ingrese la cantidad de cucharadas de azucar: ");
                if (!int.TryParse(Console.ReadLine(), out int cucharadasAzucar) || cucharadasAzucar < 0)
                {
                    Console.WriteLine(" Cantidad invalida.");
                    continue;
                }

                Orden orden = new Orden(tamano, cucharadasAzucar);
                Console.WriteLine(dispensador.ProcesarOrden(orden));

                Console.Write("\n¿Desea pedir otro cafe? (s/n): ");
                if (Console.ReadLine().ToLower() != "s")
                    break;
            }
        }
    }
}

