using ProyectoLibrary.Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.DataAccess
{
    public class ClienteEmpleadorData
    {

        private String cadenaConexion;
        private List<ClienteEmpleador> listaClientes;

        public ClienteEmpleadorData(String cadenaConexion)
        {

            this.cadenaConexion = cadenaConexion;
        }

        private void InsertarContacto(ContactoEmpleador contactoEmpleador, SqlTransaction transaccion, SqlConnection conexion)
        {

            SqlCommand cmdInsertarContactoEmpleador = new SqlCommand();
            cmdInsertarContactoEmpleador.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertarContactoEmpleador.CommandText = "InsertarContactoCliente";

            cmdInsertarContactoEmpleador.CommandTimeout = 0;
            cmdInsertarContactoEmpleador.Connection = conexion;

            SqlParameter parIdContacto = new SqlParameter("@id_contacto", System.Data.SqlDbType.Int);
            parIdContacto.Direction = System.Data.ParameterDirection.Output;

            cmdInsertarContactoEmpleador.Parameters.Add(parIdContacto);
            cmdInsertarContactoEmpleador.Parameters.Add(new SqlParameter("@nombre_contacto", contactoEmpleador.NombreConstacto));
            cmdInsertarContactoEmpleador.Parameters.Add(new SqlParameter("@designacion", contactoEmpleador.Designacion));
            cmdInsertarContactoEmpleador.Parameters.Add(new SqlParameter("@telefono", contactoEmpleador.Telefono));
            cmdInsertarContactoEmpleador.Parameters.Add(new SqlParameter("@extension", contactoEmpleador.Extencion));
            cmdInsertarContactoEmpleador.Parameters.Add(new SqlParameter("@fax", contactoEmpleador.Fax));
            cmdInsertarContactoEmpleador.Parameters.Add(new SqlParameter("@email", contactoEmpleador.Email));
            cmdInsertarContactoEmpleador.Parameters.Add(new SqlParameter("@id_cliente_empleador", contactoEmpleador.ClienteEmpleador.IdClienteEmpleador));
            cmdInsertarContactoEmpleador.Parameters.Add(new SqlParameter("@nombre_usuario", contactoEmpleador.NombreUsuario));
            cmdInsertarContactoEmpleador.Parameters.Add(new SqlParameter("@clave_acceso", contactoEmpleador.ClaveAcceso));

            cmdInsertarContactoEmpleador.Transaction = transaccion;
            cmdInsertarContactoEmpleador.ExecuteNonQuery();

            contactoEmpleador.IdContacto = Int32.Parse(cmdInsertarContactoEmpleador.Parameters["@id_contacto"].Value.ToString());
        }

        public ClienteEmpleador InsertarClienteEmpleador(ClienteEmpleador clienteEmpleador, ContactoEmpleador contactoEmpleador)
        {
            SqlConnection conexion = new SqlConnection(this.cadenaConexion);

            SqlTransaction transaccion = null;

            SqlCommand cmdInsertarClienteEmpleador = new SqlCommand();
            cmdInsertarClienteEmpleador.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertarClienteEmpleador.CommandText = "InsertarClienteEmpleador";

            cmdInsertarClienteEmpleador.CommandTimeout = 0;
            cmdInsertarClienteEmpleador.Connection = conexion;

            cmdInsertarClienteEmpleador.Parameters.Add(new SqlParameter("@id_cliente_empleador", clienteEmpleador.IdClienteEmpleador));
            cmdInsertarClienteEmpleador.Parameters.Add(new SqlParameter("@nombre_compania", clienteEmpleador.NombreCompania));
            cmdInsertarClienteEmpleador.Parameters.Add(new SqlParameter("@direccion", clienteEmpleador.Direccion));
            cmdInsertarClienteEmpleador.Parameters.Add(new SqlParameter("@ciudad", clienteEmpleador.Ciudad));
            cmdInsertarClienteEmpleador.Parameters.Add(new SqlParameter("@provincia", clienteEmpleador.Provincia));
            cmdInsertarClienteEmpleador.Parameters.Add(new SqlParameter("@codigo_postal", clienteEmpleador.CodigoPostal));

            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                cmdInsertarClienteEmpleador.Transaction = transaccion;
                cmdInsertarClienteEmpleador.ExecuteNonQuery();
                InsertarContacto(contactoEmpleador, transaccion, conexion);
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
            return clienteEmpleador;
        }

        public List<ClienteEmpleador> GetClientesEmpleadores()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdClientes = new SqlCommand("SELECT id_cliente_empleador, nombre_compania, direccion, ciudad, provincia, codigo_postal from Cliente_Empleador", conexion);
            conexion.Open();
            SqlDataReader drClientes = cmdClientes.ExecuteReader();
            this.listaClientes = new List<ClienteEmpleador>();

            while (drClientes.Read())
            {
                ClienteEmpleador clienteEmp = new ClienteEmpleador();
                clienteEmp.IdClienteEmpleador = int.Parse(drClientes["id_cliente_empleador"].ToString());
                clienteEmp.NombreCompania = drClientes["nombre_compania"].ToString();
                clienteEmp.Direccion = drClientes["direccion"].ToString();
                clienteEmp.Ciudad = drClientes["ciudad"].ToString();
                clienteEmp.Provincia = drClientes["provincia"].ToString();
                clienteEmp.CodigoPostal = int.Parse(drClientes["codigo_postal"].ToString());

                listaClientes.Add(clienteEmp);
            }//while
            conexion.Close();

            return listaClientes;
        }

        public ClienteEmpleador GetClientePorID(int idCliente)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdClientes = new SqlCommand("SELECT id_cliente_empleador, nombre_compania, direccion, ciudad, provincia, codigo_postal from Cliente_Empleador where id_cliente="+idCliente, conexion);
            conexion.Open();
            SqlDataReader drClientes = cmdClientes.ExecuteReader();
            ClienteEmpleador clienteEmp = new ClienteEmpleador();

            while (drClientes.Read())
            {
                clienteEmp.IdClienteEmpleador = int.Parse(drClientes["id_cliente_empleador"].ToString());
                clienteEmp.NombreCompania = drClientes["nombre_compania"].ToString();
                clienteEmp.Direccion = drClientes["direccion"].ToString();
                clienteEmp.Ciudad = drClientes["ciudad"].ToString();
                clienteEmp.Provincia = drClientes["provincia"].ToString();
                clienteEmp.CodigoPostal = int.Parse(drClientes["codigo_postal"].ToString());

            }//while
            conexion.Close();

            return clienteEmp;
        }
    }
}
