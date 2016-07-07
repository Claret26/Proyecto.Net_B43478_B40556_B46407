using ProyectoLibrary.Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.DataAccess
{
    public class SolicitanteData
    {
        private String cadenaConexion;


        public SolicitanteData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        public SolicitanteTrabajo InsertarSolicitante(SolicitanteTrabajo solicitante)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdUsuarios = new SqlCommand();
            SqlCommand cmdEspecialidades = new SqlCommand();
            SqlCommand cmdInstituciones = new SqlCommand();
            SqlTransaction transaccion = null;

            cmdUsuarios.Connection = conexion;
            cmdEspecialidades.Connection = conexion;
            cmdInstituciones.Connection = conexion;
            cmdUsuarios.CommandType = System.Data.CommandType.Text;
            cmdEspecialidades.CommandType = System.Data.CommandType.Text;
            cmdInstituciones.CommandType = System.Data.CommandType.Text;
            cmdUsuarios.CommandTimeout = 0;
            cmdInstituciones.CommandTimeout = 0;
            cmdEspecialidades.CommandTimeout = 0;

            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();

                cmdUsuarios.Transaction = transaccion;
                cmdInstituciones.Transaction = transaccion;
                cmdEspecialidades.Transaction = transaccion;

                cmdUsuarios.CommandText = "InsertaSolicitante";
                cmdUsuarios.CommandType = System.Data.CommandType.StoredProcedure;

                cmdUsuarios.Parameters.Add(new SqlParameter("id_solicitante", solicitante.IdSolicitante));
                cmdUsuarios.Parameters.Add(new SqlParameter("@nombre", solicitante.Nombre));
                cmdUsuarios.Parameters.Add(new SqlParameter("@apellidos", solicitante.Apellidos));
                cmdUsuarios.Parameters.Add(new SqlParameter("@direccion", solicitante.Direccion));
                cmdUsuarios.Parameters.Add(new SqlParameter("@ciudad", solicitante.Ciudad));
                cmdUsuarios.Parameters.Add(new SqlParameter("@provincia", solicitante.Provincia));
                cmdUsuarios.Parameters.Add(new SqlParameter("@numero_celular", solicitante.NumeroCelular));
                cmdUsuarios.Parameters.Add(new SqlParameter("@telefono_casa", solicitante.TelefonoCasa));
                cmdUsuarios.Parameters.Add(new SqlParameter("@email", solicitante.Email));
                cmdUsuarios.Parameters.Add(new SqlParameter("@fecha_nacimiento", solicitante.FechaNacimiento));
                cmdUsuarios.Parameters.Add(new SqlParameter("@genero", solicitante.Genero));
                cmdUsuarios.Parameters.Add(new SqlParameter("@estado_civil", solicitante.EstadoCivil));
                cmdUsuarios.Parameters.Add(new SqlParameter("@nombre_usuario", solicitante.NombreUsuario));
                cmdUsuarios.Parameters.Add(new SqlParameter("@clave", solicitante.Clave));
                cmdUsuarios.Parameters.Add(new SqlParameter("@solicitante_activo", "A"));
                cmdUsuarios.Parameters.Add(new SqlParameter("@experiencia_laboral", solicitante.ExperienciaLaboral));
                cmdUsuarios.ExecuteNonQuery();


                cmdEspecialidades.CommandText = "InsertaEspecialidad";
                cmdEspecialidades.CommandType = System.Data.CommandType.StoredProcedure;
                cmdInstituciones.CommandText = "InsertaInstitucionEstudio";
                cmdInstituciones.CommandType = System.Data.CommandType.StoredProcedure;

                foreach (EspecialidadSolicitud especialidad in solicitante.ListaEspecialidadesSolicitante)
                {
                    cmdEspecialidades.Parameters.Clear();
                    cmdInstituciones.Parameters.Clear();

                    if (especialidad.InstitucionEstudio.CodInstitucion == 0)
                    {
                        SqlParameter parCodInstitucion = new SqlParameter("@cod_institucion", System.Data.SqlDbType.Int);
                        parCodInstitucion.Direction = System.Data.ParameterDirection.Output;
                        cmdInstituciones.Parameters.Add(parCodInstitucion);
                        cmdInstituciones.Parameters.Add(new SqlParameter("@nombre_institucion", especialidad.InstitucionEstudio.NombreInstitucion));
                        cmdInstituciones.ExecuteNonQuery();
                        especialidad.InstitucionEstudio.CodInstitucion = int.Parse(cmdInstituciones.Parameters["@cod_institucion"].Value.ToString());
                    }
                    
                    cmdEspecialidades.Parameters.Add(new SqlParameter("@id_solicitante", solicitante.IdSolicitante));
                    cmdEspecialidades.Parameters.Add(new SqlParameter("@cod_nivel_estudio", especialidad.NivelEstudio.CodNivelEstudio));
                    cmdEspecialidades.Parameters.Add(new SqlParameter("@cod_area_especialidad", especialidad.AreaEspecialidad.CodAareaEspecialidad));
                    cmdEspecialidades.Parameters.Add(new SqlParameter("@ano_inicio", especialidad.AnoInicio));
                    cmdEspecialidades.Parameters.Add(new SqlParameter("@ano_finalizacion", especialidad.AnoFinalizacion));
                    cmdEspecialidades.Parameters.Add(new SqlParameter("@cod_institucion", especialidad.InstitucionEstudio.CodInstitucion));
                    cmdEspecialidades.Parameters.Add(new SqlParameter("@nombre_titulo_obtenido", especialidad.NombreTituloObtenido));
                    cmdEspecialidades.ExecuteNonQuery();
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
            return solicitante;
        }

        public SolicitanteTrabajo GetSolicitantePorID(int idSolicitante)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdSolicitantes = new SqlCommand("Select nombre, apellidos, direccion, ciudad, provincia, numero_celular, telefono_casa, email, fecha_nacimiento FROM Solicitante_Trabajo where id_solicitante="+idSolicitante, conexion);
            conexion.Open();
            SqlDataReader drSolicitantes = cmdSolicitantes.ExecuteReader();
            SolicitanteTrabajo solicitante = new SolicitanteTrabajo();

            while (drSolicitantes.Read())
            {
                solicitante.IdSolicitante = idSolicitante;
                solicitante.Nombre = drSolicitantes["nombre"].ToString();
                solicitante.Apellidos = drSolicitantes["apellidos"].ToString();
                solicitante.Direccion = drSolicitantes["direccion"].ToString();
                solicitante.Ciudad = drSolicitantes["ciudad"].ToString();
                solicitante.Provincia = drSolicitantes["provincia"].ToString();
                solicitante.NumeroCelular = int.Parse(drSolicitantes["numero_celular"].ToString());
                solicitante.TelefonoCasa = int.Parse(drSolicitantes["telefono_casa"].ToString());
                solicitante.FechaNacimiento = Convert.ToDateTime(drSolicitantes["fecha_nacimiento"].ToString());

            }
            conexion.Close();

            return solicitante;
        }
    }
}
