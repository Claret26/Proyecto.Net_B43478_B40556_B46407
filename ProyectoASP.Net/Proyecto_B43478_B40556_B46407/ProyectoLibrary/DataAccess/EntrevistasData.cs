using ProyectoLibrary.Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.DataAccess
{
    public class EntrevistasData
    {
        private String cadenaConexion;
        private List<EntrevistaProgramada> listaEntrevistas;
        private SolicitanteData solicitanteData;
        private PuestoOfertadoData puestoOfertadoData;
        private List<EntrevistaProgramada> listaEntrevistasProgramadas;
        private List<EntrevistaProgramada> listaTodasEntrevistas;

        public EntrevistasData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
            solicitanteData = new SolicitanteData(cadenaConexion);
            puestoOfertadoData = new PuestoOfertadoData(cadenaConexion);
        }

        public List<EntrevistaProgramada> GetEntrevistasPorPuesto(int codPuesto)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdEntrevistas = new SqlCommand("Select id_entrevista, tipo_entrevista, fecha_entrevista, hora_entrevista, id_trabajo, id_solicitante, id_empleado FROM Entrevista_Programada where id_trabajo=" + codPuesto, conexion);
            conexion.Open();
            SqlDataReader drEntrevistas = cmdEntrevistas.ExecuteReader();
            this.listaEntrevistas = new List<EntrevistaProgramada>();

            while (drEntrevistas.Read())
            {
                EntrevistaProgramada entrevista = new EntrevistaProgramada();
                entrevista.IdEntrevista = int.Parse(drEntrevistas["id_entrevista"].ToString());
                entrevista.FechaEntrevista = Convert.ToDateTime(drEntrevistas["fecha_entrevista"].ToString());
                entrevista.TipoeEntrevista = drEntrevistas["tipo_entrevista"].ToString();
                entrevista.HoraEntrevista = drEntrevistas["hora_entrevista"].ToString();
                entrevista.SolicitanteTrabajo = solicitanteData.GetSolicitantePorID(int.Parse(drEntrevistas["id_solicitante"].ToString()));
                entrevista.PuestoOfertado = puestoOfertadoData.GetPuestoPorId(int.Parse(drEntrevistas["id_trabajo"].ToString()));
                entrevista.Empleado.IdEmpleado = int.Parse(drEntrevistas["id_empleado"].ToString());

                listaEntrevistas.Add(entrevista);
            }
            conexion.Close();

            return listaEntrevistas;
        }

        public List<EntrevistaProgramada> GetEntrevistasPorUsuario(int idSolicitante)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdEntrevistas = new SqlCommand("select * from Entrevista_Programada where id_solicitante=" + idSolicitante, conexion);
            conexion.Open();
            SqlDataReader drEntrevistas = cmdEntrevistas.ExecuteReader();
            this.listaEntrevistasProgramadas = new List<EntrevistaProgramada>();

            while (drEntrevistas.Read())
            {
                EntrevistaProgramada entrevista = new EntrevistaProgramada();
                entrevista.IdSolitante = idSolicitante;
                entrevista.IdEntrevista = int.Parse(drEntrevistas["id_entrevista"].ToString());
                entrevista.FechaEntrevista = DateTime.Parse(drEntrevistas["fecha_entrevista"].ToString());
                entrevista.HoraEntrevista = drEntrevistas["hora_entrevista"].ToString();
                entrevista.TipoeEntrevista = drEntrevistas["tipo_entrevista"].ToString();
                entrevista.Empleado.IdEmpleado = Int32.Parse(drEntrevistas["id_empleado"].ToString());
                entrevista.PuestoOfertado.ClavePuesto = Int32.Parse(drEntrevistas["id_trabajo"].ToString());
                entrevista.Lugar = drEntrevistas["lugar"].ToString();
                //Cambiar variable de activo y crear metodo para traer los datos del solicitante
                listaEntrevistasProgramadas.Add(entrevista);

            }
            conexion.Close();

            return listaEntrevistasProgramadas;
        }

        public EntrevistaProgramada InsertarEntrevista(EntrevistaProgramada entrevista)
        {
            SqlConnection conexion = new SqlConnection(this.cadenaConexion);

            SqlTransaction transaccion = null;

            SqlCommand cmdInsertar = new SqlCommand();
            cmdInsertar.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertar.CommandText = "InsertarEntrevista";

            cmdInsertar.CommandTimeout = 0;
            cmdInsertar.Connection = conexion;

            cmdInsertar.Parameters.Add(new SqlParameter("@tipo_entrevista", entrevista.TipoeEntrevista));
            cmdInsertar.Parameters.Add(new SqlParameter("@fecha_entrevista", entrevista.FechaEntrevista));
            cmdInsertar.Parameters.Add(new SqlParameter("@hora_entrevista", entrevista.HoraEntrevista));
            cmdInsertar.Parameters.Add(new SqlParameter("@id_trabajo", entrevista.PuestoOfertado.ClavePuesto));
            cmdInsertar.Parameters.Add(new SqlParameter("@id_solicitante", entrevista.IdSolitante));
            cmdInsertar.Parameters.Add(new SqlParameter("@id_empleado", entrevista.Empleado.IdEmpleado));
            cmdInsertar.Parameters.Add(new SqlParameter("@lugar", entrevista.Lugar));

            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                cmdInsertar.Transaction = transaccion;
                cmdInsertar.ExecuteNonQuery();
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

            return entrevista;
        }

        public List<EntrevistaProgramada> GetEntrevistas()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdEntrevista = new SqlCommand("select * from Entrevista_Programada order by id_trabajo", conexion);
            conexion.Open();
            SqlDataReader drEntrevista = cmdEntrevista.ExecuteReader();
            this.listaTodasEntrevistas = new List<EntrevistaProgramada>();

            while (drEntrevista.Read())
            {
                EntrevistaProgramada entrevista = new EntrevistaProgramada();
                entrevista.SolicitanteTrabajo.IdSolicitante = int.Parse(drEntrevista["id_solicitante"].ToString());
                entrevista.IdEntrevista = int.Parse(drEntrevista["id_entrevista"].ToString());
                entrevista.FechaEntrevista = DateTime.Parse(drEntrevista["fecha_entrevista"].ToString());
                entrevista.HoraEntrevista = drEntrevista["hora_entrevista"].ToString();
                entrevista.TipoeEntrevista = drEntrevista["tipo_entrevista"].ToString();
                entrevista.Empleado.IdEmpleado = Int32.Parse(drEntrevista["id_empleado"].ToString());
                entrevista.PuestoOfertado.ClavePuesto = Int32.Parse(drEntrevista["id_trabajo"].ToString());
                //Cambiar variable de activo y crear metodo para traer los datos del solicitante
                listaTodasEntrevistas.Add(entrevista);

            }
            conexion.Close();

            return listaTodasEntrevistas;
        }

        public String GetDescripcionPuesto(int codPuesto)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdPuesto = new SqlCommand("select descripcion_puesto from Puesto_Ofertado where clave_puesto = " + codPuesto, conexion);
            conexion.Open();
            SqlDataReader drPuesto = cmdPuesto.ExecuteReader();
            PuestoOfertado puesto = new PuestoOfertado();
            while (drPuesto.Read())
            {
                puesto.DescripcionPuesto = drPuesto["descripcion_puesto"].ToString();
            }
            conexion.Close();

            return puesto.DescripcionPuesto;
        }

        public EntrevistaProgramada GetEntrevistaPorEntrevista(int idEntrevista)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdentre = new SqlCommand(" select * from Entrevista_Programada where id_entrevista = " + idEntrevista, conexion);
            conexion.Open();
            SqlDataReader drentre = cmdentre.ExecuteReader();
            EntrevistaProgramada entreVista = new EntrevistaProgramada();
            while (drentre.Read())
            {
                entreVista.Lugar = drentre["lugar"].ToString();
            }
            conexion.Close();

            return entreVista;
        }
    }
}
