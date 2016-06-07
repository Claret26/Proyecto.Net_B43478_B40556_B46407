﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.Common.Domain
{
    public class EspecialidadSolicitud
    {
        private SolicitanteTrabajo solictanteTrabajo;
        private NivelEstudio nivelEstudio;
        private AreaEspecialidad areaEspecialidad;
        private int anoInicio;
        private int anoFinalizacion;
        private InstitucionEstudio institucionEstudio;
        private String nombreTituloObtenido;

        public EspecialidadSolicitud()
        {

        }

        public SolicitanteTrabajo SolictanteTrabajo
        {
            get
            {
                return solictanteTrabajo;
            }

            set
            {
                solictanteTrabajo = value;
            }
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
    }
}
