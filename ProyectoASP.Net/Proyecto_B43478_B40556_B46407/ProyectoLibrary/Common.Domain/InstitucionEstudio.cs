using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.Common.Domain
{
    public class InstitucionEstudio
    {
        private int codInstitucion;
        private String nombreInstitucion;

        public InstitucionEstudio(int codInstitucion, String nombreInstitucion)
        {
            this.CodInstitucion = codInstitucion;
            this.NombreInstitucion = nombreInstitucion;
        }
        public InstitucionEstudio()
        {

        }

        public int CodInstitucion
        {
            get
            {
                return codInstitucion;
            }

            set
            {
                codInstitucion = value;
            }
        }

        public string NombreInstitucion
        {
            get
            {
                return nombreInstitucion;
            }

            set
            {
                nombreInstitucion = value;
            }
        }
    }
}
