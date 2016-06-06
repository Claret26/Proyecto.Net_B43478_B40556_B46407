using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.Common.Domain
{
    public class Empleado
    {
        private int idEmpleado;
        private String nombre;
        private String apellidos;
        private String direccion;
        private String ciudad;
        private String provincia;
        private int numeroCelular;
        private int extencion;
        private int telefonoCasa;
        private String email;
        private DateTime fechaNacimiento;
        private String genero;
        private String estadoCivil;
        private Rol rol;
        public Empleado(int idEmpleado, String nombre, String apellidos, String direccion, String ciudad,
            String provincia, int numeroCelular, int extencion, int telefonoCasa, String email, DateTime fechaNacimiento,
            String genero, String estadoCivil, Rol rol)
        {

        }
        public Empleado()
        {
                
        }

        public int IdEmpleado
        {
            get
            {
                return idEmpleado;
            }

            set
            {
                idEmpleado = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                apellidos = value;
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

        public int NumeroCelular
        {
            get
            {
                return numeroCelular;
            }

            set
            {
                numeroCelular = value;
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

        public int TelefonoCasa
        {
            get
            {
                return telefonoCasa;
            }

            set
            {
                telefonoCasa = value;
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

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }

        public string Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }

        public string EstadoCivil
        {
            get
            {
                return estadoCivil;
            }

            set
            {
                estadoCivil = value;
            }
        }

        public Rol Rol
        {
            get
            {
                return rol;
            }

            set
            {
                rol = value;
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
    }
}
