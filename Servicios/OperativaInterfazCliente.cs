using EjercicioRepaso.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso.Servicios
{
    internal interface OperativaInterfazCliente
    {
        public int MenuCliente();
        public void registrarCliente(List<ClienteDto> listaCliente);
        public void accesoCliente(List<ClienteDto> listaCliente);
    }
}
