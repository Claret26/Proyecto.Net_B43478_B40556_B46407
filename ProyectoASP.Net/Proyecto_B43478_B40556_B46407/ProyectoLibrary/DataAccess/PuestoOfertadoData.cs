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

        public PuestoOfertadoData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
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
            SqlCommand cmdPuestosCompania = new SqlCommand("Select clave_puesto, descripcion_puesto, experiencia_requerida, abierto, numero_vacantes, dias_laborar, hora_entrada, hora_salida, sueldo, provincia, ciudad, id_cliente_empleador, cod_categoria FROM Puesto_Ofertado", conexion);
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

        public PuestoOfertado GetPuestoPorId(int codPuesto)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdPuestosCompania = new SqlCommand("Select clave_puesto, descripcion_puesto, experiencia_requerida, abierto, numero_vacantes, dias_laborar, hora_entrada, hora_salida, sueldo, provincia, ciudad, id_cliente_empleador, cod_categoria FROM Puesto_Ofertado where clave_puesto="+codPuesto, conexion);
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

    }
}
