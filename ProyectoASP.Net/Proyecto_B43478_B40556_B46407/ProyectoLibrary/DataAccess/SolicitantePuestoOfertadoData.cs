using ProyectoLibrary.Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.DataAccess
{
    public class SolicitantePuestoOfertadoData
    {
        private String cadenaConexion;
        private List<SolicitanteTrabajo> listaSolicitantes;
        private List<SolicitantePuestoOfertado> listaSolicitantePuestos;

        public SolicitantePuestoOfertadoData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        public List<SolicitanteTrabajo> GetPersonasInterasadasPorPuesto(int codPuesto)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdSolicitantes = new SqlCommand("select Solicitante_Trabajo.* from Solicitante_Trabajo inner join Solicitante_PuestoOfertado on Solicitante_Trabajo.id_solicitante = Solicitante_PuestoOfertado.id_solicitante where Solicitante_PuestoOfertado.clave_puesto =" + codPuesto, conexion);
            conexion.Open();
            SqlDataReader drSolicitante = cmdSolicitantes.ExecuteReader();
            this.listaSolicitantes = new List<SolicitanteTrabajo>();

            while (drSolicitante.Read())
            {
                SolicitanteTrabajo solicitante = new SolicitanteTrabajo();
                solicitante.IdSolicitante = int.Parse(drSolicitante["id_solicitante"].ToString());
                solicitante.Nombre = drSolicitante["nombre"].ToString();
                solicitante.Apellidos = drSolicitante["apellidos"].ToString();
                solicitante.Direccion = drSolicitante["direccion"].ToString();
                solicitante.Ciudad = drSolicitante["ciudad"].ToString();
                solicitante.Provincia = drSolicitante["provincia"].ToString();
                solicitante.NumeroCelular = int.Parse(drSolicitante["numero_celular"].ToString());
                solicitante.TelefonoCasa = int.Parse(drSolicitante["telefono_casa"].ToString());
                solicitante.Email = drSolicitante["email"].ToString();
                solicitante.FechaNacimiento = DateTime.Parse(drSolicitante["fecha_nacimiento"].ToString());
                solicitante.Genero = drSolicitante["genero"].ToString();
                solicitante.EstadoCivil = drSolicitante["estado_civil"].ToString();
                solicitante.ArchivoCurriculo = drSolicitante["archivo_curriculo"].ToString();
                solicitante.NombreUsuario = drSolicitante["nombre_usuario"].ToString();
                solicitante.Clave = drSolicitante["clave"].ToString();
                // solicitante.SolicitanteActivo = bool.Parse(drSolicitante["solicitante_activo"].ToString());
                // solicitante.ExperienciaLaboral = bool.Parse(drSolicitante["experiencia_laboral"].ToString());
                listaSolicitantes.Add(solicitante);
            }
            conexion.Close();
            return listaSolicitantes;
        }

        public List<SolicitantePuestoOfertado> GetSolicitudesPuestosOfertados()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdSolicitudes = new SqlCommand("select * from Solicitante_PuestoOfertado", conexion);
            conexion.Open();
            SqlDataReader drSolicitudes = cmdSolicitudes.ExecuteReader();
            this.listaSolicitantePuestos = new List<SolicitantePuestoOfertado>();

            while (drSolicitudes.Read())
            {
                SolicitantePuestoOfertado solicitantePuesto = new SolicitantePuestoOfertado();
                solicitantePuesto.PuestoOfertado.ClavePuesto = int.Parse(drSolicitudes["clave_puesto"].ToString());
                solicitantePuesto.SolicitanteTrabajo.IdSolicitante = int.Parse(drSolicitudes["id_solicitante"].ToString());
                listaSolicitantePuestos.Add(solicitantePuesto);
            }
            conexion.Close();
            return listaSolicitantePuestos;
        }

        public SolicitanteTrabajo GetSolicitantePorId(int idSoli)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdsoli = new SqlCommand(" select * from Solicitante_Trabajo  where id_solicitante = " + idSoli, conexion);
            conexion.Open();
            SqlDataReader drSoli = cmdsoli.ExecuteReader();
            SolicitanteTrabajo solicitante = new SolicitanteTrabajo();
            while (drSoli.Read())
            {
                solicitante.Nombre = drSoli["nombre"].ToString();
                /* solicitante.Apellidos = drSolicitante["apellidos"].ToString();
                  solicitante.Direccion = drSolicitante["direccion"].ToString();;*/
            }
            conexion.Close();

            return solicitante;
        }

        public String GetDescripcionPuesto(int codPuesto)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdPuestos = new SqlCommand("select descripcion_puesto from Puesto_Ofertado where clave_puesto = " + codPuesto, conexion);
            conexion.Open();
            SqlDataReader drPuestos = cmdPuestos.ExecuteReader();
            PuestoOfertado puesto = new PuestoOfertado();
            while (drPuestos.Read())
            {
                puesto.DescripcionPuesto = drPuestos["descripcion_puesto"].ToString();
            }
            conexion.Close();

            return puesto.DescripcionPuesto;
        }
    }
}
