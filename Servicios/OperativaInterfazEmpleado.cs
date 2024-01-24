using EjercicioRepaso.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso.Servicios
{
    internal interface OperativaInterfazEmpleado
    {
        public int MenuEmpleado();
        public void validarCliente(List<ClienteDto> listaClientes);
        public void borrarCliente(List<ClienteDto> listaClientes);
        public void mostrarCliente(List<ClienteDto> listaClientes);
    }
}
