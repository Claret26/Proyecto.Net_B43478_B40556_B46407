using ProyectoLibrary.Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.DataAccess
{
    public class ExperienciaLaboralData
    {
        private String cadenaConexion;

        public ExperienciaLaboralData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        public void InsertaExperiencia(List<ExperienciaLaboral> listaExperiencias)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdExperiencia = new SqlCommand();
            SqlTransaction transaccion = null;

            cmdExperiencia.Connection = conexion;
            cmdExperiencia.CommandType = System.Data.CommandType.Text;
            cmdExperiencia.CommandTimeout = 0;

            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();

                cmdExperiencia.Transaction = transaccion;
                cmdExperiencia.CommandText = "InsertaExperiencia";
                cmdExperiencia.CommandType = System.Data.CommandType.StoredProcedure;

                foreach (ExperienciaLaboral experiencia in listaExperiencias)
                {
                    cmdExperiencia.Parameters.Clear();
                    SqlParameter parIdExperiencia = new SqlParameter("@id_experiencia", System.Data.SqlDbType.Int);
                    parIdExperiencia.Direction = System.Data.ParameterDirection.Output;
                    cmdExperiencia.Parameters.Add(parIdExperiencia);
                    cmdExperiencia.Parameters.Add(new SqlParameter("@empresa", experiencia.Empresa));
                    cmdExperiencia.Parameters.Add(new SqlParameter("@puesto", experiencia.Puesto));
                    cmdExperiencia.Parameters.Add(new SqlParameter("@fecha_ingreso", experiencia.FechaIngreso));
                    cmdExperiencia.Parameters.Add(new SqlParameter("@fecha_termino", experiencia.FechaTermino));
                    cmdExperiencia.Parameters.Add(new SqlParameter("@descripcion_funciones", experiencia.DescripcionFunciones));
                    cmdExperiencia.Parameters.Add(new SqlParameter("@id_solicitante", experiencia.SolicitanteTrabajo.IdSolicitante));
                    cmdExperiencia.ExecuteNonQuery();
                }

                transaccion.Commit();
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}