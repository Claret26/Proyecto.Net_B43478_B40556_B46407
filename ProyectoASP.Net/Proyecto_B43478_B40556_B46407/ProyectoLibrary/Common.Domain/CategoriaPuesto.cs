using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.Common.Domain
{
    public class CategoriaPuesto
    {
        private int codCategoria;
        private String nombreCategoria;
        public CategoriaPuesto(int codCategoria, String nombreCategoria)
        {
            this.CodCategoria = codCategoria;
            this.NombreCategoria = nombreCategoria;
        }
        public CategoriaPuesto()
        {

        }

        public int CodCategoria
        {
            get
            {
                return codCategoria;
            }

            set
            {
                codCategoria = value;
            }
        }

        public string NombreCategoria
        {
            get
            {
                return nombreCategoria;
            }

            set
            {
                nombreCategoria = value;
            }
        }
    }
}
