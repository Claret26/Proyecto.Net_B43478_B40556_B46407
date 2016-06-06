using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.Common.Domain
{
    public class ContactoEmpleador
    {
        private int idContacto;
        private String nombreConstacto;
        private String designacion;
        private int telefono;
        private int extencion;
        private int fax;
        private String email;
        private ClienteEmpleador clienteEmpleador;
        private String nombreUsuario;
        private String claveAcceso;

        public ContactoEmpleador(int idContacto, String nombreConstacto, String designacion, int telefono,
           int extencion, int fax, String email, ClienteEmpleador clienteEmpleador, String nombreUsuario, String claveAcceso)
        {

        }
        
        public ContactoEmpleador()
        {

        }
        public int IdContacto
        {
            get
            {
                return idContacto;
            }

            set
            {
                idContacto = value;
            }
        }

        public string NombreConstacto
        {
            get
            {
                return nombreConstacto;
            }

            set
            {
                nombreConstacto = value;
            }
        }

        public string Designacion
        {
            get
            {
                return designacion;
            }

            set
            {
                designacion = value;
            }
        }

        public int Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public int Extencion
        {
            get
            {
                return extencion;
            }

            set
            {
                extencion = value;
            }
        }

        public int Fax
        {
            get
            {
                return fax;
            }

            set
            {
                fax = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public ClienteEmpleador ClienteEmpleador
        {
            get
            {
                return clienteEmpleador;
            }

            set
            {
                clienteEmpleador = value;
            }
        }

        public string NombreUsuario
        {
            get
            {
                return nombreUsuario;
            }

            set
            {
                nombreUsuario = value;
            }
        }

        public string ClaveAcceso
        {
            get
            {
                return claveAcceso;
            }

            set
            {
                claveAcceso = value;
            }
        }
    }
}
