using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.Common.Domain
{
    public class EntrevistaProgramada
    {
        private int idSolitante;
        private int idEntrevista;
        private String tipoeEntrevista;
        private DateTime fechaEntrevista;
        private String horaEntrevista;
        private SolicitanteTrabajo solicitanteTrabajo;
        private Empleado empleado;
        private PuestoOfertado puestoOfertado;
        private String lugar;

        public EntrevistaProgramada()
        {
            this.solicitanteTrabajo = new SolicitanteTrabajo();
            this.puestoOfertado = new PuestoOfertado();
            this.empleado = new Empleado();
        }

        public int IdEntrevista
        {
            get
            {
                return idEntrevista;
            }

            set
            {
                idEntrevista = value;
            }
        }

        public string TipoeEntrevista
        {
            get
            {
                return tipoeEntrevista;
            }

            set
            {
                tipoeEntrevista = value;
            }
        }

        public DateTime FechaEntrevista
        {
            get
            {
                return fechaEntrevista;
            }

            set
            {
                fechaEntrevista = value;
            }
        }

        public string HoraEntrevista
        {
            get
            {
                return horaEntrevista;
            }

            set
            {
                horaEntrevista = value;
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

        public Empleado Empleado
        {
            get
            {
                return empleado;
            }

            set
            {
                empleado = value;
            }
        }

        public PuestoOfertado PuestoOfertado
        {
            get
            {
                return puestoOfertado;
            }

            set
            {
                puestoOfertado = value;
            }
        }

        public string Lugar
        {
            get
            {
                return lugar;
            }

            set
            {
                lugar = value;
            }
        }

        public int IdSolitante
        {
            get
            {
                return idSolitante;
            }

            set
            {
                idSolitante = value;
            }
        }
    }
}
