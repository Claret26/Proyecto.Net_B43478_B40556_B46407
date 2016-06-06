using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.Common.Domain
{
    public class ClienteEmpleador
    {
        private int idClienteEmpleador;
        private String nombreCliente;
        private String direccion;
        private String ciudad;
        private String provincia;
        private int codigoPostal;

        public ClienteEmpleador(int idClienteEmpleador, String nombreCliente, String direccion, String ciudad,
             String provincia, int codigoPostal)
        {
            this.IdClienteEmpleador = idClienteEmpleador;
            this.NombreCliente = nombreCliente;
            this.Direccion = direccion;
            this.Ciudad = ciudad;
            this.Provincia = provincia;
            this.CodigoPostal = codigoPostal;
        }
        public ClienteEmpleador()
        {

        }

        public int IdClienteEmpleador
        {
            get
            {
                return idClienteEmpleador;
            }

            set
            {
                idClienteEmpleador = value;
            }
        }

        public string NombreCliente
        {
            get
            {
                return nombreCliente;
            }

            set
            {
                nombreCliente = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Ciudad
        {
            get
            {
                return ciudad;
            }

            set
            {
                ciudad = value;
            }
        }

        public string Provincia
        {
            get
            {
                return provincia;
            }

            set
            {
                provincia = value;
            }
        }

        public int CodigoPostal
        {
            get
            {
                return codigoPostal;
            }

            set
            {
                codigoPostal = value;
            }
        }
    }
}
