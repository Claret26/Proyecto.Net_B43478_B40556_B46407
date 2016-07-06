using ProyectoLibrary.Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.DataAccess
{
    public class NivelEstudioData
    {
        private String cadenaConexion;
        private List<NivelEstudio> listaNiveles;

        public NivelEstudioData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        public List<NivelEstudio> GetNivelesEstudio()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdNiveles = new SqlCommand("Select cod_nivel_estudio, descripcion_nivel_estudio FROM Nivel_Estudio", conexion);
            conexion.Open();
            SqlDataReader drNiveles = cmdNiveles.ExecuteReader();
            this.listaNiveles = new List<NivelEstudio>();

            while (drNiveles.Read())
            {
                NivelEstudio nivel = new NivelEstudio();
                nivel.CodNivelEstudio = int.Parse(drNiveles["cod_nivel_estudio"].ToString());
                nivel.DescripcionNivelEstudio = drNiveles["descripcion_nivel_estudio"].ToString();
                listaNiveles.Add(nivel);
            }
            conexion.Close();

            return listaNiveles;
        }
    }
}
