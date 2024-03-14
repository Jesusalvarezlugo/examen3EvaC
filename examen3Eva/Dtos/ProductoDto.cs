using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen3Eva.Dtos
{
    internal class ProductoDto
    {
        //Atributos

        long idProducto;
        string nombreProducto = "aaaaa";
        int cantidadProducto = 0;
        DateTime fechaEntrega;

        

        //Getters y Setters
        public long IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }

        //Constructores

        public ProductoDto()
        {

        }
        public ProductoDto(long idProducto, string nombreProducto, int cantidadProducto, DateTime fechaEntrega)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.cantidadProducto = cantidadProducto;
            this.fechaEntrega = fechaEntrega;
        }
    }
}
