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

        public void EliminarEspecialidad(int idEspecilidad, int idsolicitante)
        {
            SqlConnection conexion = new SqlConnection(this.cadenaConexion);

            SqlTransaction transaccion = null;

            SqlCommand cmdInsertarMedico = new SqlCommand();
            cmdInsertarMedico.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertarMedico.CommandText = "EliminaEspecialidad";

            cmdInsertarMedico.CommandTimeout = 0;
            cmdInsertarMedico.Connection = conexion;

            cmdInsertarMedico.Parameters.Add(new SqlParameter("@idEspecilidad", idEspecilidad));
            cmdInsertarMedico.Parameters.Add(new SqlParameter("@idSolicitante", idsolicitante));

            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                cmdInsertarMedico.Transaction = transaccion;
                cmdInsertarMedico.ExecuteNonQuery();
                transaccion.Commit();
            }
            catch (Exception ex)
            {
                // si algo fallo deshacemos todo
                transaccion.Rollback();
                throw ex;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }
        }

        public EspecialidadSolicitud InsertarEspecialidad(EspecialidadSolicitud especialidadSolicitud)
        {
            SqlConnection conexion = new SqlConnection(this.cadenaConexion);

            SqlTransaction transaccion = null;

            SqlCommand cmdInsertarMedico = new SqlCommand();
            cmdInsertarMedico.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertarMedico.CommandText = "InsertarEspecialidadS";

            cmdInsertarMedico.CommandTimeout = 0;
            cmdInsertarMedico.Connection = conexion;

            cmdInsertarMedico.Parameters.Add(new SqlParameter("@idSolicitante", especialidadSolicitud.Solicitante));
            cmdInsertarMedico.Parameters.Add(new SqlParameter("@codNivelEstudio", especialidadSolicitud.NivelEstudio.CodNivelEstudio));
            cmdInsertarMedico.Parameters.Add(new SqlParameter("@codAreaEspecialidad", especialidadSolicitud.AreaEspecialidad.CodAareaEspecialidad));
            cmdInsertarMedico.Parameters.Add(new SqlParameter("@anoInicio", especialidadSolicitud.AnoInicio));
            cmdInsertarMedico.Parameters.Add(new SqlParameter("@anoFin", especialidadSolicitud.AnoFinalizacion));
            cmdInsertarMedico.Parameters.Add(new SqlParameter("@codInstitucion", especialidadSolicitud.InstitucionEstudio.CodInstitucion));
            cmdInsertarMedico.Parameters.Add(new SqlParameter("@nombreTitulo", especialidadSolicitud.NombreTituloObtenido));

            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                cmdInsertarMedico.Transaction = transaccion;
                cmdInsertarMedico.ExecuteNonQuery();
                transaccion.Commit();
            }
            catch (Exception ex)
            {
                // si algo fallo deshacemos todo
                transaccion.Rollback();
                throw ex;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }



            return especialidadSolicitud;

        }
    }
}
