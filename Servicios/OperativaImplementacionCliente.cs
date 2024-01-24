using EjercicioRepaso.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso.Servicios
{
    internal class OperativaImplementacionCliente: OperativaInterfazCliente
    {
        public int MenuCliente()
        {
            int opcionIntroducidaCliente;
            Console.WriteLine("-------------------------------");
            Console.WriteLine("0. Volver al menu principal");
            Console.WriteLine("1. Registro cliente");
            Console.WriteLine("2. Acceso cliente (Login)");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Seleccione una opcion: ");

            opcionIntroducidaCliente = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducidaCliente;
        }

        private long calcularNuevoId(List<ClienteDto> listaCliente)
        {
            long idCalculado;
            int tamanioLista=listaCliente.Count;
            if (tamanioLista == 0) 
            { 
                idCalculado=1;
            }
            else
            {
                idCalculado = listaCliente[tamanioLista - 1].IdCliente + 1;
            }
            return idCalculado;
        }
        public void registrarCliente(List<ClienteDto> listaCliente)
        {
            ClienteDto nuevoCliente = new ClienteDto();

            long id=calcularNuevoId(listaCliente);
            Console.WriteLine("Introduzca el DNI: ");
            nuevoCliente.DniCliente = Console.ReadLine();
            Console.WriteLine("Introduzca el nombre: ");
            nuevoCliente.NombreCliente = Console.ReadLine();
            Console.WriteLine("Introduzca el 1º apellido: ");
            nuevoCliente.Apellido1Cliente = Console.ReadLine();
            Console.WriteLine("Introduzca el 2º apellido: ");
            nuevoCliente.Apellido2Cliente = Console.ReadLine();
            Console.WriteLine("Introduzca el email: ");
            nuevoCliente.EmailCliente = Console.ReadLine();
            Console.WriteLine("Introduzca la contraseña: ");
            nuevoCliente.ContraseniaCliente = Console.ReadLine();

            listaCliente.Add(nuevoCliente);
        }
        public void accesoCliente(List<ClienteDto> listaCliente)
        {
            ClienteDto nuevoCliente = new ClienteDto();

            Console.WriteLine("LOGIN");

            Console.WriteLine("Introduzca el email: ");
            string emailClienteAcceso=Console.ReadLine();
            Console.WriteLine("Introduzca la contraseña: ");
            string contraseniaClienteAcceso=Console.ReadLine();

            foreach(ClienteDto cliente in listaCliente)
            {
                if (cliente.EmailCliente.Equals(emailClienteAcceso) & 
                    cliente.ContraseniaCliente.Equals(contraseniaClienteAcceso) &
                        cliente.EsValidado == true)
                {
                    Console.WriteLine("INICIO DE SESION CORRECTO");
                }
                else
                {
                    Console.WriteLine("ERROR EN EL INICIO DE SESION");
                }
            }
            
        }
    }
}
