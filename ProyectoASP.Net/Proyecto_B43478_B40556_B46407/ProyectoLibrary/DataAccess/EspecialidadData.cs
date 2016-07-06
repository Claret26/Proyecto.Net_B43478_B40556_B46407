using ProyectoLibrary.Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.DataAccess
{
    public class EspecialidadData
    {
        private String cadenaConexion;
        private List<EspecialidadSolicitud> listaEspecialidades;
        private List<AreaEspecialidad> listaAreasEspecialidad;

        public EspecialidadData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        public List<AreaEspecialidad> GetEspecialidades()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdEspecialidades = new SqlCommand("Select cod_area_especialidad, descripcion_area_especialidad FROM Area_Especialidad", conexion);
            conexion.Open();
            SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();
            this.listaAreasEspecialidad = new List<AreaEspecialidad>();

            while (drEspecialidades.Read())
            {
                AreaEspecialidad area = new AreaEspecialidad();
                area.CodAareaEspecialidad = int.Parse(drEspecialidades["cod_area_especialidad"].ToString());
                area.DescripcionAreaEspecialidad = drEspecialidades["descripcion_area_especialidad"].ToString();
                listaAreasEspecialidad.Add(area);
            }
            conexion.Close();

            return listaAreasEspecialidad;
        }
    }
}
