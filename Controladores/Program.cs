using EjercicioRepaso.Dtos;
using EjercicioRepaso.Servicios;
using System.Collections.Generic;

namespace EjercicioRepaso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ClienteDto> listaClientes = new List<ClienteDto>();

            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfazEmpleado oie = new OperativaImplementacionEmpleado();
            OperativaInterfazCliente oic = new OperativaImplementacionCliente();

            bool cerrarMenu = false;
            int opcionElegida;

            while (!cerrarMenu)
            {
                opcionElegida = mi.mostrarMenu();
                Console.WriteLine(opcionElegida);

                switch (opcionElegida)
                {
                    case 0:
                        Console.WriteLine("[INFO] - Cerrar menu.");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("[INFO] -  Se ejecuta la opcion numero 1.");
                        int opcionElegidaEmpleado=oie.MenuEmpleado();
                        if (opcionElegidaEmpleado == 0)
                        {
                            Console.WriteLine("Volvemos al menu principal");
                            mi.mostrarMenu();
                        }
                        else if (opcionElegidaEmpleado == 1)
                        {
                            oie.validarCliente(listaClientes);
                        }
                        else if (opcionElegidaEmpleado == 2)
                        {
                            oie.borrarCliente(listaClientes);
                        }
                        else if (opcionElegidaEmpleado == 3)
                        {
                            oie.mostrarCliente(listaClientes);
                        }
                        else
                        {
                            Console.WriteLine("la opcion introducida no existe");
                        }
                        break;

                    case 2:
                        Console.WriteLine("[INFO] -  Se ejecuta la opcion numero 2.");                        
                        int opcionElegidaCliente = oic.MenuCliente();
                        if (opcionElegidaCliente == 0)
                        {
                            Console.WriteLine("Volvemos al menu principal");
                            mi.mostrarMenu();
                        }
                        else if (opcionElegidaCliente == 1)
                        {
                            oic.registrarCliente(listaClientes);
                        }
                        else if (opcionElegidaCliente == 2)
                        {
                            oic.accesoCliente(listaClientes);
                        }
                        else
                        {
                            Console.WriteLine("la opcion introducida no existe");
                        }
                        break;

                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no existe.");
                        break;
                }
            }
        }
    }
}