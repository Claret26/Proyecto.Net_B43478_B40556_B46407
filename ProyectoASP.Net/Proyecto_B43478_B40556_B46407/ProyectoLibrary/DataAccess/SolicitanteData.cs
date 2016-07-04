using ProyectoLibrary.Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.DataAccess
{
    public class SolicitanteData
    {
        private String cadenaConexion;


        public SolicitanteData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }
    }
}
