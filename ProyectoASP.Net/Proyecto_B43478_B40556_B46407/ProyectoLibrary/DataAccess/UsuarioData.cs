using ProyectoLibrary.Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.DataAccess
{
    public class UsuarioData
    {
        private String cadenaConexion;

        public UsuarioData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        public Usuario FindUser(String nombreUsuario, String contrasena)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdUser = new SqlCommand("ValidaUsuarios");

            cmdUser.CommandType = System.Data.CommandType.StoredProcedure;
            cmdUser.Parameters.Add(new SqlParameter("@usuario", nombreUsuario));
            cmdUser.Parameters.Add(new SqlParameter("@contrasena", contrasena));
            cmdUser.Connection = conexion;

            conexion.Open();
            SqlDataReader drUser = cmdUser.ExecuteReader();
            drUser.Read();
            Usuario usuario = new Usuario();
            usuario.IdUsuario = Int32.Parse(drUser["id_usuario"].ToString());

            conexion.Close();
            return usuario;
        }

        public Usuario GetUsuario(int idUsuario)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdUsuarios = new SqlCommand("SELECT nombre_usuario, rol from Usuarios where id_usuario=" + idUsuario, conexion);
            conexion.Open();
            SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
            Usuario usuario = new Usuario();
            while (drUsuarios.Read())
            {
                usuario.NombreUsuario = drUsuarios["nombre_usuario"].ToString();
                usuario.Rol = drUsuarios["rol"].ToString();
            }

            return usuario;
        }

        public Usuario GetUsuarioPorNombre(String nombreUsuario)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdUsuarios = new SqlCommand("SELECT nombre_usuario, rol, email, contrasena from Usuarios where nombre_usuario='" + nombreUsuario + "'", conexion);
            conexion.Open();
            SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
            Usuario usuario = new Usuario();
            while (drUsuarios.Read())
            {
                usuario.NombreUsuario = drUsuarios["nombre_usuario"].ToString();
                usuario.Rol = drUsuarios["rol"].ToString();
                usuario.Contrasena = drUsuarios["contrasena"].ToString();
                usuario.Email = drUsuarios["email"].ToString();
            }
            conexion.Close();

            return usuario;
        }

        public Boolean ComprobarUsuarioExistente(String nombreUsuarioSolicitante)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdUsuarios = new SqlCommand("SELECT nombre_usuario, rol from Usuarios where nombre_usuario= '" + nombreUsuarioSolicitante + "'", conexion);
            conexion.Open();
            SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();

            if (drUsuarios.Read())
            {
                return false;
            }
            else {
                return true;
            }
        }

        public Usuario InsertarUsuario(Usuario usuario)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdUsuarios = new SqlCommand();
            SqlTransaction transaccion = null;

            cmdUsuarios.Connection = conexion;
            cmdUsuarios.CommandType = System.Data.CommandType.Text;
            cmdUsuarios.CommandTimeout = 0;

            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();

                cmdUsuarios.Transaction = transaccion;
                cmdUsuarios.CommandText = "InsertaUsuario";
                cmdUsuarios.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter parCodUsuario = new SqlParameter("@id_usuario", System.Data.SqlDbType.Int);
                parCodUsuario.Direction = System.Data.ParameterDirection.Output;
                cmdUsuarios.Parameters.Add(parCodUsuario);
                cmdUsuarios.Parameters.Add(new SqlParameter("@nombre_usuario", usuario.NombreUsuario));
                cmdUsuarios.Parameters.Add(new SqlParameter("@contrasena", usuario.Contrasena));
                cmdUsuarios.Parameters.Add(new SqlParameter("@rol", usuario.Rol));
                cmdUsuarios.Parameters.Add(new SqlParameter("@cuenta_activa", "A"));
                cmdUsuarios.Parameters.Add(new SqlParameter("@email", usuario.Email));
                cmdUsuarios.ExecuteNonQuery();

                usuario.IdUsuario = int.Parse(cmdUsuarios.Parameters["@id_usuario"].Value.ToString());

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

            return usuario;
        }
    }
}
