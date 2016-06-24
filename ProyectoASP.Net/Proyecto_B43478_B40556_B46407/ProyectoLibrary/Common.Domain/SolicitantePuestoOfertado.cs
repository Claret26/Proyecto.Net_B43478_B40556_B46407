using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.Common.Domain
{
    public class SolicitantePuestoOfertado
    {
        private SolicitanteTrabajo solicitanteTrabajo;
        private PuestoOfertado puestoOfertado;
        private Boolean activo;
        

        public SolicitantePuestoOfertado()
        {
            this.solicitanteTrabajo = new SolicitanteTrabajo();
            this.puestoOfertado = new PuestoOfertado();
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

        public bool Activo
        {
            get
            {
                return activo;
            }

            set
            {
                activo = value;
            }
        }
    }
}
