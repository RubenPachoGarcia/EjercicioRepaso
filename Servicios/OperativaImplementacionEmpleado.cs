using EjercicioRepaso.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso.Servicios
{
    internal class OperativaImplementacionEmpleado:OperativaInterfazEmpleado
    {
        public int MenuEmpleado()
        {
            int opcionIntroducidaEmpleado;
            Console.WriteLine("-------------------------------");
            Console.WriteLine("0. Volver al menu principal");
            Console.WriteLine("1. Validar cliente");
            Console.WriteLine("2. Borrado de cliente");
            Console.WriteLine("3. Mostrar cliente");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Seleccione una opcion: ");

            opcionIntroducidaEmpleado = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducidaEmpleado;
        }
        public void validarCliente(List<ClienteDto> listaClientes)
        {
            Console.WriteLine("Clientes sin validacion");
            List<ClienteDto> listaAuxiliar = new List<ClienteDto>();

            foreach (ClienteDto cliente in listaClientes)
            {
                if (cliente.EsValidado == false)
                {
                    Console.WriteLine("\\\\\\\\\\\\\\\\\\\\");
                    Console.WriteLine("DNI: " + cliente.DniCliente);
                    Console.WriteLine("Nombre: " + cliente.NombreCompletoCliente);
                    Console.WriteLine("\\\\\\\\\\\\\\\\\\\\");
                    listaClientes.Add(cliente);
                }
            }
            if (listaAuxiliar.Count > 0)
            {
                Console.WriteLine("Introduzca el DNI del cliente a validar: ");
                string dniClienteAValidar = Console.ReadLine();
                foreach (ClienteDto cliente in listaClientes)
                {
                    if (cliente.DniCliente.Equals(dniClienteAValidar))
                    {
                        listaClientes.Remove(cliente);
                        Console.WriteLine("El cliente que tiene como DNI " + dniClienteAValidar + " ha sido borrado");
                    }
                }
            }
        }
        public void borrarCliente(List<ClienteDto> listaClientes)
        {
            Console.WriteLine("BORRAR CLIENTE");

            if (listaClientes.Count > 0)
            {
                Console.WriteLine("Introduzca el DNI del cliente a borrar: ");
                string dniClienteBorrado = Console.ReadLine();
                ClienteDto clienteAuxiliar = new ClienteDto();
                foreach (ClienteDto cliente in listaClientes)
                {
                    if (cliente.DniCliente.Equals(dniClienteBorrado))
                    {
                        clienteAuxiliar = cliente;
                    }
                }
                listaClientes.Remove(clienteAuxiliar);
                Console.WriteLine("El cliente que tiene como DNI " + dniClienteBorrado + " ha sido validado con exito");
            }
        }
        public void mostrarCliente(List<ClienteDto> listaClientes)
        {
            foreach (ClienteDto cliente in listaClientes)
            {               
                Console.WriteLine("%%%%%%%%%%");
                Console.WriteLine("DNI: " + cliente.DniCliente);
                Console.WriteLine("Nombre: " + cliente.Apellido1Cliente + " " + 
                cliente.Apellido2Cliente + ", " + cliente.NombreCliente);
                string sn;
                if(cliente.EsValidado==true)
                {
                    sn = "si";
                }
                else
                {
                    sn = "no";
                }
                Console.WriteLine("ESTADO DE VALIDACION: " + sn);
                Console.WriteLine("%%%%%%%%%%");                              
            }
        }
    }
}
