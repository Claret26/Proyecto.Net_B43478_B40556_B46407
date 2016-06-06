using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.Common.Domain
{
    public class NivelEstudio
    {
        private int codNivelEstudio;
        private String descripcionNivelEstudio;

        public NivelEstudio(int codNivelEstudio, String descripcionNivelEstudio)
        {
            this.codNivelEstudio = codNivelEstudio;
            this.descripcionNivelEstudio = descripcionNivelEstudio;
        }
        public NivelEstudio()
        {

        }

        public int CodNivelEstudio
        {
            get
            {
                return codNivelEstudio;
            }

            set
            {
                codNivelEstudio = value;
            }
        }

        public string DescripcionNivelEstudio
        {
            get
            {
                return descripcionNivelEstudio;
            }

            set
            {
                descripcionNivelEstudio = value;
            }
        }
    }
}
