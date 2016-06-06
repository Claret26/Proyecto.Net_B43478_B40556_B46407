using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.Common.Domain
{
    public class AreaEspecialidad
    {
        private int codAareaEspecialidad;
        private String descripcionAreaEspecialidad;

        public AreaEspecialidad(int codAareaEspecialidad, String descripcionAreaEspecialidad)
        {
            this.CodAareaEspecialidad = codAareaEspecialidad;
            this.DescripcionAreaEspecialidad = descripcionAreaEspecialidad; 
        }
        public AreaEspecialidad()
        {

        }

        public int CodAareaEspecialidad
        {
            get
            {
                return codAareaEspecialidad;
            }

            set
            {
                codAareaEspecialidad = value;
            }
        }

        public string DescripcionAreaEspecialidad
        {
            get
            {
                return descripcionAreaEspecialidad;
            }

            set
            {
                descripcionAreaEspecialidad = value;
            }
        }
    }
}