using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.Common.Domain
{
    public class EspecialidadSolicitud
    {
        private int idEspecialidad;
        private int solicitante;/**/
        private NivelEstudio nivelEstudio;
        private AreaEspecialidad areaEspecialidad;
        private int anoInicio;
        private int anoFinalizacion;
        private InstitucionEstudio institucionEstudio;
        private String nombreTituloObtenido;

        public EspecialidadSolicitud()
        {
            this.nivelEstudio = new NivelEstudio();
            this.areaEspecialidad = new AreaEspecialidad();
            this.institucionEstudio = new InstitucionEstudio();
        }

        public NivelEstudio NivelEstudio
        {
            get
            {
                return nivelEstudio;
            }

            set
            {
                nivelEstudio = value;
            }
        }

        public AreaEspecialidad AreaEspecialidad
        {
            get
            {
                return areaEspecialidad;
            }

            set
            {
                areaEspecialidad = value;
            }
        }

        public int AnoInicio
        {
            get
            {
                return anoInicio;
            }

            set
            {
                anoInicio = value;
            }
        }

        public int AnoFinalizacion
        {
            get
            {
                return anoFinalizacion;
            }

            set
            {
                anoFinalizacion = value;
            }
        }

        public InstitucionEstudio InstitucionEstudio
        {
            get
            {
                return institucionEstudio;
            }

            set
            {
                institucionEstudio = value;
            }
        }

        public string NombreTituloObtenido
        {
            get
            {
                return nombreTituloObtenido;
            }

            set
            {
                nombreTituloObtenido = value;
            }
        }

        public int Solicitante
        {
            get
            {
                return solicitante;
            }

            set
            {
                solicitante = value;
            }
        }

        public int IdEspecialidad
        {
            get
            {
                return idEspecialidad;
            }

            set
            {
                idEspecialidad = value;
            }
        }
    }
}
