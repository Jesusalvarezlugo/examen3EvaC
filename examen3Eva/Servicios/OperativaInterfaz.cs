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

        /*
            metodo para calcular el total de ventas diarias
         */
        public void calculoTotalVentas(List<VentaDto> listaAntigua);

        
        public void menuEmpleado(List<VentaDto> listaAntigua);

        
        public void menuGerencia(List<ProductoDto> listaAntiguaP,List<VentaDto> listaAntigua);

        /*
            Metodo que  genera un fichero con todas las ventas.
            
         */
        public void mostrarVentas(List<VentaDto> listaAntigua);
    }
}
