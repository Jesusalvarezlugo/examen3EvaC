using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen3Eva.Dtos
{
    internal class VentaDto
    {
        //Atributos

        long id;
        double importe=0;
        DateTime fechaVenta;

        

        //Getters y Setters
        public long Id { get => id; set => id = value; }
        public double Importe { get => importe; set => importe = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }

        //Constructores

        public VentaDto()
        {

        }
        public VentaDto(long id, double importe, DateTime fechaVenta)
        {
            this.id = id;
            this.importe = importe;
            this.fechaVenta = fechaVenta;
        }

        //Metodo toString

        override

        public string ToString()
        {
            string texto = "ID: "+this.id+"\n IMPORTE: "+this.importe+"FECHA VENTA: "+this.fechaVenta;

            return texto;
        }
        

        

        
    }
}
