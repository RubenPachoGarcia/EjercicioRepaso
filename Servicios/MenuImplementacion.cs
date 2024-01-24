using EjercicioRepaso.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso.Servicios
{
    internal class MenuImplementacion:MenuInterfaz
    {
        public int mostrarMenu()
        {
            int opcionIntroducida;
            Console.WriteLine("-------------------------------");
            Console.WriteLine("0. Cerra aplicacion");
            Console.WriteLine("1. Versión Empleado");
            Console.WriteLine("2. Versión Cliente");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Seleccione una opcion: ");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;
        }
    }
}
