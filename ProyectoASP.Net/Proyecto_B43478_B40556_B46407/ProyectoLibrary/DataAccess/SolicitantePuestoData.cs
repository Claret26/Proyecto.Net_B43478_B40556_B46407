using ProyectoLibrary.Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.DataAccess
{
    public class SolicitantePuestoData
    {
        private String cadenaConexion;

        public SolicitantePuestoData(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }
        public SolicitantePuestoOfertado InsertarSolicitantePuesto(SolicitantePuestoOfertado solicitantePuesto)
        {
            SqlConnection conexion = new SqlConnection(this.cadenaConexion);

            SqlTransaction transaccion = null;

            SqlCommand cmdInsertarPuesto = new SqlCommand();
            cmdInsertarPuesto.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertarPuesto.CommandText = "InsertarSolicitantePuesto";

            cmdInsertarPuesto.CommandTimeout = 0;
            cmdInsertarPuesto.Connection = conexion;

            cmdInsertarPuesto.Parameters.Add(new SqlParameter("@id_solicitante", solicitantePuesto.SolicitanteTrabajo.IdSolicitante));
            cmdInsertarPuesto.Parameters.Add(new SqlParameter("@clave_puesto", solicitantePuesto.PuestoOfertado.ClavePuesto));
            cmdInsertarPuesto.Parameters.Add(new SqlParameter("@activo", solicitantePuesto.Activo));

            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                cmdInsertarPuesto.Transaction = transaccion;
                cmdInsertarPuesto.ExecuteNonQuery();
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
            return solicitantePuesto;
        }
    }
}
