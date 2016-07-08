using ProyectoLibrary.Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibrary.DataAccess
{
    public class PuestoOfertadoData
    {
        private String cadenaConexion;
        private List<PuestoOfertado> listaPuestos;
        private List<CategoriaPuesto> categorias;

        public PuestoOfertadoData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        public List<CategoriaPuesto> GetCantidadPuestosPorCategoria()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdPuestoCategoria = new SqlCommand("SELECT Categoria_Puesto.nombre_categoria, sum(Puesto_Ofertado.numero_vacantes) AS cantidad " +
                                                            "FROM Categoria_Puesto, Puesto_Ofertado " +
                                                            "WHERE Categoria_Puesto.cod_categoria = Puesto_Ofertado.cod_categoria " +
                                                            "GROUP BY Categoria_Puesto.nombre_categoria", conexion);
            conexion.Open();
            SqlDataReader drPuestosCategoria = cmdPuestoCategoria.ExecuteReader();
            this.categorias = new List<CategoriaPuesto>();

            while (drPuestosCategoria.Read())
            {
                CategoriaPuesto categoria = new CategoriaPuesto();
                categoria.NombreCategoria = drPuestosCategoria["nombre_categoria"].ToString();
                categoria.CantidadPuestos = Int32.Parse(drPuestosCategoria["cantidad"].ToString());
                this.categorias.Add(categoria);
            }
            conexion.Close();

            return this.categorias;
        }

        public List<CategoriaPuesto> GetOfertadosCategoria()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdPuestoCategoria = new SqlCommand("SELECT nombre_categoria, count(Categoria_Puesto.nombre_categoria) AS cantidad " +
                                                            "FROM Categoria_Puesto, Puesto_Ofertado, Solicitante_PuestoOfertado " +
                                                            "WHERE Categoria_Puesto.cod_categoria = Puesto_Ofertado.cod_categoria and Puesto_Ofertado.clave_puesto=Solicitante_PuestoOfertado.clave_puesto " +
                                                            "GROUP BY Categoria_Puesto.nombre_categoria", conexion);
            conexion.Open();
            SqlDataReader drPuestosCategoria = cmdPuestoCategoria.ExecuteReader();
            this.categorias = new List<CategoriaPuesto>();

            while (drPuestosCategoria.Read())
            {
                CategoriaPuesto categoria = new CategoriaPuesto();
                categoria.NombreCategoria = drPuestosCategoria["nombre_categoria"].ToString();
                categoria.CantidadPuestos = Int32.Parse(drPuestosCategoria["cantidad"].ToString());
                this.categorias.Add(categoria);
            }
            conexion.Close();

            return this.categorias;
        }

        public List<PuestoOfertado> GetPuestosPorCompania(int idCliente)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdPuestosCompania = new SqlCommand("Select clave_puesto, descripcion_puesto, experiencia_requerida, abierto, numero_vacantes, dias_laborar, hora_entrada, hora_salida, sueldo, provincia, ciudad, id_cliente_empleador, cod_categoria FROM Puesto_Ofertado where id_cliente_empleador=" + idCliente, conexion);
            conexion.Open();
            SqlDataReader drPuestos = cmdPuestosCompania.ExecuteReader();
            this.listaPuestos = new List<PuestoOfertado>();

            while (drPuestos.Read())
            {
                PuestoOfertado puesto = new PuestoOfertado();
                puesto.ClavePuesto = int.Parse(drPuestos["clave_puesto"].ToString());
                puesto.DescripcionPuesto = drPuestos["descripcion_puesto"].ToString();
                puesto.ExperienciaRequerida = drPuestos["experiencia_requerida"].ToString();
                puesto.Abierto = int.Parse(drPuestos["abierto"].ToString());
                puesto.NumeroVacantes = int.Parse(drPuestos["numero_vacantes"].ToString());
                puesto.DiasLaborar = drPuestos["dias_laborar"].ToString();
                puesto.HoraEntrada = drPuestos["hora_entrada"].ToString();
                puesto.HoraSalida = drPuestos["hora_salida"].ToString();
                puesto.Sueldo = float.Parse(drPuestos["sueldo"].ToString());
                puesto.Provincia = drPuestos["provincia"].ToString();
                puesto.Ciudad = drPuestos["ciudad"].ToString();
                puesto.ClienteEmpleador.IdClienteEmpleador = int.Parse(drPuestos["id_cliente_empleador"].ToString());
                puesto.CategoriaPuesto.CodCategoria = int.Parse(drPuestos["cod_categoria"].ToString());
                listaPuestos.Add(puesto);
            }
            conexion.Close();

            return listaPuestos;
        }

        public List<PuestoOfertado> GetPuestos()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdPuestosCompania = new SqlCommand("Select Puesto_Ofertado.clave_puesto, Puesto_Ofertado.descripcion_puesto, Puesto_Ofertado.experiencia_requerida, Puesto_Ofertado.abierto, Puesto_Ofertado.numero_vacantes, Puesto_Ofertado.dias_laborar, Puesto_Ofertado.hora_entrada, Puesto_Ofertado.hora_salida, Puesto_Ofertado.sueldo, Puesto_Ofertado.provincia, Puesto_Ofertado.ciudad, Puesto_Ofertado.id_cliente_empleador, Puesto_Ofertado.cod_categoria, Cliente_Empleador.nombre_compania FROM Puesto_Ofertado, Cliente_Empleador WHERE Puesto_Ofertado.id_cliente_empleador=Cliente_Empleador.id_cliente_empleador", conexion);
            conexion.Open();
            SqlDataReader drPuestos = cmdPuestosCompania.ExecuteReader();
            this.listaPuestos = new List<PuestoOfertado>();

            while (drPuestos.Read())
            {
                PuestoOfertado puesto = new PuestoOfertado();
                puesto.ClavePuesto = int.Parse(drPuestos["clave_puesto"].ToString());
                puesto.DescripcionPuesto = drPuestos["descripcion_puesto"].ToString();
                puesto.ExperienciaRequerida = drPuestos["experiencia_requerida"].ToString();
                puesto.Abierto = int.Parse(drPuestos["abierto"].ToString());
                puesto.NumeroVacantes = int.Parse(drPuestos["numero_vacantes"].ToString());
                puesto.DiasLaborar = drPuestos["dias_laborar"].ToString();
                puesto.HoraEntrada = drPuestos["hora_entrada"].ToString();
                puesto.HoraSalida = drPuestos["hora_salida"].ToString();
                puesto.Sueldo = float.Parse(drPuestos["sueldo"].ToString());
                puesto.Provincia = drPuestos["provincia"].ToString();
                puesto.Ciudad = drPuestos["ciudad"].ToString();
                puesto.ClienteEmpleador.IdClienteEmpleador = int.Parse(drPuestos["id_cliente_empleador"].ToString());
                puesto.ClienteEmpleador.NombreCompania = drPuestos["nombre_compania"].ToString();
                puesto.CategoriaPuesto.CodCategoria = int.Parse(drPuestos["cod_categoria"].ToString());
                listaPuestos.Add(puesto);
            }
            conexion.Close();

            return listaPuestos;
        }

        public List<CategoriaPuesto> GetCategoriasPuestos()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdCategoriasPuestos = new SqlCommand("SELECT cod_categoria, nombre_categoria FROM Categoria_Puesto", conexion);
            conexion.Open();
            SqlDataReader drCategoriasPuestos = cmdCategoriasPuestos.ExecuteReader();
            this.categorias = new List<CategoriaPuesto>();

            while (drCategoriasPuestos.Read())
            {
                CategoriaPuesto categoriaPuesto = new CategoriaPuesto();
                categoriaPuesto.CodCategoria = int.Parse(drCategoriasPuestos["cod_categoria"].ToString());
                categoriaPuesto.NombreCategoria = drCategoriasPuestos["nombre_categoria"].ToString();
                categorias.Add(categoriaPuesto);
            }
            conexion.Close();

            return categorias;
        }

        public PuestoOfertado GetPuestoPorId(int codPuesto)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdPuestosCompania = new SqlCommand("Select clave_puesto, descripcion_puesto, experiencia_requerida, abierto, numero_vacantes, dias_laborar, hora_entrada, hora_salida, sueldo, provincia, ciudad, id_cliente_empleador, cod_categoria FROM Puesto_Ofertado where clave_puesto=" + codPuesto, conexion);
            conexion.Open();
            SqlDataReader drPuestos = cmdPuestosCompania.ExecuteReader();
            PuestoOfertado puesto = new PuestoOfertado();

            while (drPuestos.Read())
            {
                puesto.ClavePuesto = int.Parse(drPuestos["clave_puesto"].ToString());
                puesto.DescripcionPuesto = drPuestos["descripcion_puesto"].ToString();
                puesto.ExperienciaRequerida = drPuestos["experiencia_requerida"].ToString();
                puesto.Abierto = int.Parse(drPuestos["abierto"].ToString());
                puesto.NumeroVacantes = int.Parse(drPuestos["numero_vacantes"].ToString());
                puesto.DiasLaborar = drPuestos["dias_laborar"].ToString();
                puesto.HoraEntrada = drPuestos["hora_entrada"].ToString();
                puesto.HoraSalida = drPuestos["hora_salida"].ToString();
                puesto.Sueldo = float.Parse(drPuestos["sueldo"].ToString());
                puesto.Provincia = drPuestos["provincia"].ToString();
                puesto.Ciudad = drPuestos["ciudad"].ToString();
                puesto.ClienteEmpleador.IdClienteEmpleador = int.Parse(drPuestos["id_cliente_empleador"].ToString());
                puesto.CategoriaPuesto.CodCategoria = int.Parse(drPuestos["cod_categoria"].ToString());

            }
            conexion.Close();

            return puesto;
        }

        public PuestoOfertado GetPuestoPorNombreYCompania(String nombrePuesto, String empresa)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdPuestosCompania = new SqlCommand("Select Puesto_Ofertado.clave_puesto, Puesto_Ofertado.descripcion_puesto, Puesto_Ofertado.experiencia_requerida, Puesto_Ofertado.abierto, Puesto_Ofertado.numero_vacantes, Puesto_Ofertado.dias_laborar, Puesto_Ofertado.hora_entrada, Puesto_Ofertado.hora_salida, Puesto_Ofertado.sueldo, Puesto_Ofertado.provincia, Puesto_Ofertado.ciudad, Puesto_Ofertado.id_cliente_empleador, Puesto_Ofertado.cod_categoria FROM Puesto_Ofertado, Cliente_Empleador where Puesto_Ofertado.id_cliente_empleador=Cliente_Empleador.id_cliente_empleador and Puesto_Ofertado.descripcion_puesto='" + nombrePuesto + "' and Cliente_Empleador.nombre_compania='"+empresa+"'", conexion);
            conexion.Open();
            SqlDataReader drPuestos = cmdPuestosCompania.ExecuteReader();
            PuestoOfertado puesto = new PuestoOfertado();

            while (drPuestos.Read())
            {
                puesto.ClavePuesto = int.Parse(drPuestos["clave_puesto"].ToString());
                puesto.DescripcionPuesto = drPuestos["descripcion_puesto"].ToString();
                puesto.ExperienciaRequerida = drPuestos["experiencia_requerida"].ToString();
                puesto.Abierto = int.Parse(drPuestos["abierto"].ToString());
                puesto.NumeroVacantes = int.Parse(drPuestos["numero_vacantes"].ToString());
                puesto.DiasLaborar = drPuestos["dias_laborar"].ToString();
                puesto.HoraEntrada = drPuestos["hora_entrada"].ToString();
                puesto.HoraSalida = drPuestos["hora_salida"].ToString();
                puesto.Sueldo = float.Parse(drPuestos["sueldo"].ToString());
                puesto.Provincia = drPuestos["provincia"].ToString();
                puesto.Ciudad = drPuestos["ciudad"].ToString();
                puesto.ClienteEmpleador.IdClienteEmpleador = int.Parse(drPuestos["id_cliente_empleador"].ToString());
                puesto.CategoriaPuesto.CodCategoria = int.Parse(drPuestos["cod_categoria"].ToString());

            }
            conexion.Close();

            return puesto;
        }

        public PuestoOfertado InsertarPuestoOfertado(PuestoOfertado puestoOfertado)
        {
            SqlConnection conexion = new SqlConnection(this.cadenaConexion);

            SqlTransaction transaccion = null;

            SqlCommand cmdInsertarPuesto = new SqlCommand();
            cmdInsertarPuesto.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertarPuesto.CommandText = "InsertarPuesto";

            cmdInsertarPuesto.CommandTimeout = 0;
            cmdInsertarPuesto.Connection = conexion;

            SqlParameter parClavePuesto = new SqlParameter("@clave", System.Data.SqlDbType.Int);
            parClavePuesto.Direction = System.Data.ParameterDirection.Output;

            cmdInsertarPuesto.Parameters.Add(parClavePuesto);
            cmdInsertarPuesto.Parameters.Add(new SqlParameter("@descripcion", puestoOfertado.DescripcionPuesto));
            cmdInsertarPuesto.Parameters.Add(new SqlParameter("@experiencia", puestoOfertado.ExperienciaRequerida));
            cmdInsertarPuesto.Parameters.Add(new SqlParameter("@abierto", puestoOfertado.Abierto));
            cmdInsertarPuesto.Parameters.Add(new SqlParameter("@vacantes", puestoOfertado.NumeroVacantes));
            cmdInsertarPuesto.Parameters.Add(new SqlParameter("@dias", puestoOfertado.DiasLaborar));
            cmdInsertarPuesto.Parameters.Add(new SqlParameter("@entrada", puestoOfertado.HoraEntrada));
            cmdInsertarPuesto.Parameters.Add(new SqlParameter("@salida", puestoOfertado.HoraSalida));
            cmdInsertarPuesto.Parameters.Add(new SqlParameter("@sueldo", puestoOfertado.Sueldo));
            cmdInsertarPuesto.Parameters.Add(new SqlParameter("@provincia", puestoOfertado.Provincia));
            cmdInsertarPuesto.Parameters.Add(new SqlParameter("@Ciudad", puestoOfertado.Ciudad));
            cmdInsertarPuesto.Parameters.Add(new SqlParameter("@cliente", puestoOfertado.ClienteEmpleador.IdClienteEmpleador));
            cmdInsertarPuesto.Parameters.Add(new SqlParameter("@categoria", puestoOfertado.CategoriaPuesto.CodCategoria));

            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                cmdInsertarPuesto.Transaction = transaccion;
                cmdInsertarPuesto.ExecuteNonQuery();
                puestoOfertado.ClavePuesto = Int32.Parse(cmdInsertarPuesto.Parameters["@clave"].Value.ToString());
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
            return puestoOfertado;
        }
    }
}
