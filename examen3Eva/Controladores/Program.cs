using examen3Eva.Dtos;
using examen3Eva.Servicios;

namespace examen3Eva
{
    class Program
    {
        public static void Main(string[] args)
        {
            int opcionS;
            bool cerrarMenu = false;
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            List<VentaDto> listaVentas = new List<VentaDto>();
            List<ProductoDto> listaPedidos=new List<ProductoDto>();

            while (!cerrarMenu)
            {
                opcionS = mi.mostrarMenuYSeleccionPrin();

                switch (opcionS)
                {
                    case 0:
                        Console.WriteLine("[INFO] Se cerrara el menu");
                        cerrarMenu = true;
                        break;

                    case 1:
                        oi.menuEmpleado(listaVentas);
                        
                        break;

                    case 2:
                        oi.menuGerencia(listaPedidos,listaVentas);
                        break;
                }
            }
        }
    }
}
