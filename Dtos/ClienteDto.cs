﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso.Dtos
{
    internal class ClienteDto
    {
        long idCliente;
        string dniCliente = "aaaaa";
        string nombreCliente = "aaaaa";
        string apellido1Cliente = "aaaaa";
        string apellido2Cliente = "aaaaa";
        string nombreCompletoCliente = "aaaaa";
        string emailCliente = "aaaaa";
        string contraseniaCliente = "aaaaa";
        bool esValidado = false;

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Apellido1Cliente { get => apellido1Cliente; set => apellido1Cliente = value; }
        public string Apellido2Cliente { get => apellido2Cliente; set => apellido2Cliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public string ContraseniaCliente { get => contraseniaCliente; set => contraseniaCliente = value; }
        public bool EsValidado { get => esValidado; set => esValidado = value; }

        public ClienteDto(long idCliente, string dniCliente,string nombreCompletoCliente, string emailCliente, string contraseniaCliente)
        {   
            this.idCliente = idCliente;
            this.dniCliente = dniCliente;            
            this.nombreCompletoCliente = nombreCompletoCliente;
            this.emailCliente = emailCliente;
            this.contraseniaCliente = contraseniaCliente;
            //IMPORTANTE
            string[] arrayNombre=nombreCompletoCliente.Split(" ");
            this.nombreCliente = arrayNombre[0];
            this.apellido1Cliente = arrayNombre[1];
            this.apellido2Cliente = arrayNombre[2];
            //IMPORTANTE
        }

        public ClienteDto()
        {
        }

        override
        public string ToString()
        {
            string elementoString = "[" + "id:" + this.idCliente +
                " - dni:" + this.dniCliente +
                " - nombre:" + this.nombreCliente + " - apellido1:" + 
                this.apellido1Cliente + " - apellido2:" + this.apellido2Cliente + 
                " - nombre completo:" + this.nombreCompletoCliente +
                " - email" + this.emailCliente + " - contrasenia:" + this.contraseniaCliente + "]";

            return elementoString;
        }
    }
}
