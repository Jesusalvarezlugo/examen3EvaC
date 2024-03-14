using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen3Eva.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int mostrarMenuYSeleccionPrin()
        {
            int opcion;

            Console.WriteLine("##########################");
            Console.WriteLine("0. Salir del menu");
            Console.WriteLine("1. Menu empleado");
            Console.WriteLine("2. Menu Gerencia");
            Console.WriteLine("##########################");
            Console.WriteLine("Seleccione una opcion: ");
            opcion = Console.ReadKey().KeyChar - ('0');

            return opcion;
        }

        public int mostrarMenuYSeleccionEmp()
        {
            int opcion;

            Console.WriteLine("##########################");
            Console.WriteLine("0. Salir del menu");
            Console.WriteLine("1. Añadir venta");
            Console.WriteLine("2. calculo total de ventas diario");
            Console.WriteLine("##########################");
            Console.WriteLine("Seleccione una opcion: ");
            opcion = Console.ReadKey().KeyChar - ('0');

            return opcion;
        }

        public int mostrarMenuYSeleccionGer()
        {
            int opcion;

            Console.WriteLine("##########################");
            Console.WriteLine("0. Salir del menu");
            Console.WriteLine("1. crear un nuevo pedido");
            Console.WriteLine("2. escribir en un fichero todas las ventas");
            Console.WriteLine("##########################");
            Console.WriteLine("Seleccione una opcion: ");
            opcion = Console.ReadKey().KeyChar - ('0');

            return opcion;
        }

        
    }
}
