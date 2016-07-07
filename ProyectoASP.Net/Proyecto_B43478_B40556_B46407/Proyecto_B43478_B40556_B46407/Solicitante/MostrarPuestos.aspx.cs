using ProyectoLibrary.Common.Domain;
using ProyectoLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_B43478_B40556_B46407.EmpresaEmpleadora
{
    public partial class MostrarPuestos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                labelCategoria.Text = "Categoría: " + Request.QueryString["categoria"];

                int codCategoria = Int32.Parse(Request.QueryString["codCategoria"]);
                String palabra = Request.QueryString["palabra"];

                PuestoOfertadoData puestoOfertadoData = new PuestoOfertadoData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);
                List<PuestoOfertado> puestos = puestoOfertadoData.GetPuestos();

                List<PuestoOfertado> puestosSolicitados = new List<PuestoOfertado>();

                if (codCategoria != -1 && palabra != "")
                {
                    foreach (PuestoOfertado puestoActual in puestos)
                    {
                        if ((puestoActual.CategoriaPuesto.CodCategoria == codCategoria) && (puestoActual.DescripcionPuesto.IndexOf(palabra) != -1))
                        {
                            puestosSolicitados.Add(puestoActual);
                        }
                    }

                }
                else if (codCategoria != -1)
                {
                    foreach (PuestoOfertado puestoActual in puestos)
                    {
                        if (puestoActual.CategoriaPuesto.CodCategoria == codCategoria)
                        {
                            puestosSolicitados.Add(puestoActual);
                        }
                    }
                }
                else if (palabra != "")
                {
                    foreach (PuestoOfertado puestoActual in puestos)
                    {
                        if (puestoActual.DescripcionPuesto.IndexOf(palabra) != -1)
                        {
                            puestosSolicitados.Add(puestoActual);
                        }
                    }
                }
                labelCantidad.Text = "Cantidad de puestos: " + puestosSolicitados.Count;
                tabla(puestosSolicitados, gvPuestos);
            }

        }
        private void tabla(List<PuestoOfertado> puestos, GridView grid)
        {
            DataTable dt = new DataTable();
            DataRow Row;
            dt.Columns.Add(new DataColumn("Puesto", System.Type.GetType("System.String")));
            dt.Columns.Add(new DataColumn("Empresa", System.Type.GetType("System.String")));
            dt.Columns.Add(new DataColumn("Plazas", System.Type.GetType("System.String")));

            foreach (PuestoOfertado puestoActual in puestos)
            {

                Row = dt.NewRow();
                Row["Puesto"] = puestoActual.DescripcionPuesto;
                Row["Empresa"] = puestoActual.ClienteEmpleador.NombreCompania;
                Row["Plazas"] = puestoActual.NumeroVacantes;
                dt.Rows.Add(Row);
            }

            grid.DataSource = dt;
            grid.DataBind();
        }
    }
}