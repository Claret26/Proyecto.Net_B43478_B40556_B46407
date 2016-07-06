using ProyectoLibrary.Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.DataAccess
{
    public class InstitucionData
    {
        private String cadenaConexion;
        private List<InstitucionEstudio> listaInstituciones;

        public InstitucionData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        public List<InstitucionEstudio> GetInstituciones()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdInstituciones = new SqlCommand("Select cod_institucion, nombre_institucion FROM Institucion_Estudio order by nombre_institucion", conexion);
            conexion.Open();
            SqlDataReader drInstituciones = cmdInstituciones.ExecuteReader();
            this.listaInstituciones = new List<InstitucionEstudio>();

            while (drInstituciones.Read())
            {
                InstitucionEstudio institución = new InstitucionEstudio();
                institución.CodInstitucion = int.Parse(drInstituciones["cod_institucion"].ToString());
                institución.NombreInstitucion = drInstituciones["nombre_institucion"].ToString();
                listaInstituciones.Add(institución);
            }
            conexion.Close();

            return listaInstituciones;
        }
    }
}
