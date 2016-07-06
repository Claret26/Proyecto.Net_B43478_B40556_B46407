using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.Common.Domain
{
   public class ExperienciaLaboral
    {
        private int idExperiencia;
        private String empresa;
        private String puesto;
        private DateTime fechaIngreso;
        private DateTime fechaTermino;
        private String descripcionFunciones;
        private SolicitanteTrabajo solicitanteTrabajo;

        public ExperienciaLaboral(int idExperiencia, String empresa, String puesto, DateTime fechaIngreso,
            DateTime fechaTermino, String descripcionFunciones, SolicitanteTrabajo solicitanteTrabajo)
        {
            this.idExperiencia = idExperiencia;
            this.empresa = empresa;
            this.puesto = puesto;
            this.fechaIngreso = fechaIngreso;
            this.fechaTermino = fechaTermino;
            this.descripcionFunciones = descripcionFunciones;
            this.solicitanteTrabajo = solicitanteTrabajo;
        }
        public ExperienciaLaboral()
        {

        }

        public int IdExperiencia
        {
            get
            {
                return idExperiencia;
            }

            set
            {
                idExperiencia = value;
            }
        }

        public string Empresa
        {
            get
            {
                return empresa;
            }

            set
            {
                empresa = value;
            }
        }

        public string Puesto
        {
            get
            {
                return puesto;
            }

            set
            {
                puesto = value;
            }
        }

        public DateTime FechaIngreso
        {
            get
            {
                return fechaIngreso;
            }

            set
            {
                fechaIngreso = value;
            }
        }

        public DateTime FechaTermino
        {
            get
            {
                return fechaTermino;
            }

            set
            {
                fechaTermino = value;
            }
        }

        public string DescripcionFunciones
        {
            get
            {
                return descripcionFunciones;
            }

            set
            {
                descripcionFunciones = value;
            }
        }

        public SolicitanteTrabajo SolicitanteTrabajo
        {
            get
            {
                return solicitanteTrabajo;
            }

            set
            {
                solicitanteTrabajo = value;
            }
        }
    }
}
