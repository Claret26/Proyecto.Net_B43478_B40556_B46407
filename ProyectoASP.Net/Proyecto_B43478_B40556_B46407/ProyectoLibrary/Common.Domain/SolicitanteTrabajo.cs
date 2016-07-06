using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.Common.Domain
{
    public class SolicitanteTrabajo
    {
        private int idSolicitante;
        private String nombre;
        private String apellidos;
        private String direccion;
        private String ciudad;
        private String provincia;
        private int numeroCelular;
        private int telefonoCasa;
        private String email;
        private DateTime fechaNacimiento;
        private String genero;
        private String estadoCivil;
        private String archivoCurriculo;
        private String nombreUsuario;
        private String clave;
        private Boolean solicitanteActivo;
        private Boolean experienciaLaboral;
        private List<EspecialidadSolicitud> listaEspecialidadesSolicitante;

        public SolicitanteTrabajo(int idSolicitante, String nombre, String apellidos, String direccion,
           String ciudad, String provincia, int numeroCelular, int telefonoCasa, String email, DateTime fechaNacimiento,
           String genero, String estadoCivil, String archivoCurriculo, String nombreUsuraio, String clave, Boolean solicitanteActivo, Boolean experienciaLaboral)
        {
            this.idSolicitante = idSolicitante;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.ciudad = ciudad;
            this.provincia = provincia;
            this.numeroCelular = numeroCelular;
            this.telefonoCasa = telefonoCasa;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
            this.genero = genero;
            this.estadoCivil = estadoCivil;
            this.archivoCurriculo = archivoCurriculo;
            this.NombreUsuario = nombreUsuraio;
            this.clave = clave;
            this.solicitanteActivo = solicitanteActivo;
            this.experienciaLaboral = experienciaLaboral;
        }
        public SolicitanteTrabajo()
        {

        }

        public int IdSolicitante
        {
            get
            {
                return idSolicitante;
            }

            set
            {
                idSolicitante = value;
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

        public string ArchivoCurriculo
        {
            get
            {
                return archivoCurriculo;
            }

            set
            {
                archivoCurriculo = value;
            }
        }

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
            }
        }

        public bool SolicitanteActivo
        {
            get
            {
                return solicitanteActivo;
            }

            set
            {
                solicitanteActivo = value;
            }
        }

        public bool ExperienciaLaboral
        {
            get
            {
                return experienciaLaboral;
            }

            set
            {
                experienciaLaboral = value;
            }
        }

        public List<EspecialidadSolicitud> ListaEspecialidadesSolicitante
        {
            get
            {
                return listaEspecialidadesSolicitante;
            }

            set
            {
                listaEspecialidadesSolicitante = value;
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
    }
}
