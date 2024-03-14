using examen3Eva.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen3Eva.Servicios
{
    internal interface OperativaInterfaz
    {
        public void crearVenta(List<VentaDto> listaAntigua);

        public void calculoTotalVentas(List<VentaDto> listaAntigua);

        public void menuEmpleado(List<VentaDto> listaAntigua);
    }
}
