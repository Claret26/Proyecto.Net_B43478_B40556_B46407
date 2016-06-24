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
        private List<SolicitantePuestoOfertado> listaEntrevistas;

        public EntrevistasData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        public List<SolicitantePuestoOfertado> GetEntrevistasPorPuesto(int codPuesto)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdPuestosCompania = new SqlCommand("Select id_solicitante FROM Solicitante_PuestoOfertado where clave_puesto=" + codPuesto, conexion);
            conexion.Open();
            SqlDataReader drPuestos = cmdPuestosCompania.ExecuteReader();
            this.listaEntrevistas = new List<SolicitantePuestoOfertado>();

            while (drPuestos.Read())
            {
                SolicitantePuestoOfertado solicPuesto = new SolicitantePuestoOfertado();
                solicPuesto.SolicitanteTrabajo.IdSolicitante = int.Parse(drPuestos["id_solicitante"].ToString());
                //Cambiar variable de activo y crear metodo para traer los datos del solicitante
                listaEntrevistas.Add(solicPuesto);

            }
            conexion.Close();

            return listaEntrevistas;
        }
    }
}
