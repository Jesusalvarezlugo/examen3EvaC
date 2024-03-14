using examen3Eva.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen3Eva.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void calculoTotalVentas(List<VentaDto> listaAntigua)
        {
            double totalVentas=0;
            VentaDto venta=new VentaDto();
            string fechaAPedir;
            Console.WriteLine("Introduzca la fecha (dd-MM-yyyy) para calcular el total de ventas diario: ");
            fechaAPedir = Console.ReadLine();
            DateTime fechaDeString=Convert.ToDateTime(fechaAPedir);

            for(int i = 0; i < listaAntigua.Count; i++)
            {
                venta = listaAntigua[i];
                if (venta.FechaVenta.Day == fechaDeString.Day && venta.FechaVenta.Month == fechaDeString.Month && venta.FechaVenta.Year == fechaDeString.Year)
                {
                    totalVentas += venta.Importe;
                }
                else
                {
                    Console.WriteLine("Las fechas no coinciden.");
                    break;
                }
            }

            TimeSpan diferenciaTiempo = listaAntigua[0].FechaVenta - listaAntigua[listaAntigua.Count-1].FechaVenta;
            
            Console.WriteLine("Total ventas: "+totalVentas);
            Console.WriteLine("Tiempo transcurrido: "+diferenciaTiempo.Hours+" horas"+diferenciaTiempo.Minutes+" minutos y "+diferenciaTiempo.Seconds+" segundos.");
            
        }

        public void crearVenta(List<VentaDto> listaAntigua)
        {
            VentaDto venta= nuevaVenta(listaAntigua);

            listaAntigua.Add(venta);
        }

        private VentaDto nuevaVenta(List<VentaDto> listaAntigua)
        {
            VentaDto venta = new VentaDto();

            Console.WriteLine("Introduzca el importe de la venta: ");
            venta.Importe = Double.Parse(Console.ReadLine());

            venta.FechaVenta = DateTime.Now;

            venta.Id = autoId(listaAntigua);

            return venta;
        }

        private long autoId(List<VentaDto> listaAntigua)
        {
            int tamanioLista=listaAntigua.Count;
            long nuevoId;

            if (tamanioLista > 0)
            {
                nuevoId = listaAntigua[tamanioLista - 1].Id + 1;
            }
            else
            {
                nuevoId = 1;
            }

            return nuevoId;

        }

        public void menuEmpleado(List<VentaDto> listaAntigua)
        {
            

            int opcionS;
            bool cerrarMenu=false;
            MenuInterfaz mi = new MenuImplementacion();

            while (!cerrarMenu)
            {
                opcionS = mi.mostrarMenuYSeleccionEmp();

                switch (opcionS)
                {
                    case 0:
                        Console.WriteLine("[INFO] se volvera al menu principal");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("[INFO] se creara una nueva venta");
                        crearVenta(listaAntigua);
                        foreach (VentaDto venta in listaAntigua)
                        {
                            Console.WriteLine(venta.ToString());
                        }

                        break;

                    case 2:
                        calculoTotalVentas( listaAntigua);
                        break;
                }
            }
        }

        public void menuGerencia(List<VentaDto> listaAntigua)
        {
            int opcionS;
            bool cerrarMenu = false;
            MenuInterfaz mi = new MenuImplementacion();

            while (!cerrarMenu)
            {
                opcionS = mi.mostrarMenuYSeleccionGer();

                switch (opcionS)
                {
                    case 0:
                        Console.WriteLine("[INFO] se volvera al menu principal");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("[INFO] creara un nuevo pedido.");

                        break;

                    case 2:
                        Console.WriteLine("[INFO] escribira en un fichero todas las ventas.");
                        break;
                }
            }

        }

        
    }
}
