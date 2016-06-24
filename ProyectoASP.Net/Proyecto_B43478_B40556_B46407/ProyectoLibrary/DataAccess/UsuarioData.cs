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
    }
}
