using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.Common.Domain
{
    public class Rol
    {
        private int idRol;
        private String nombre;

        public Rol()
        {

        }

        public Rol(String nombre)
        {
            this.Nombre = nombre;
        }

        public int IdRol
        {
            get
            {
                return idRol;
            }

            set
            {
                idRol = value;
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
    }
}
