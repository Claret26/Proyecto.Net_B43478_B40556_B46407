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
    }
}
