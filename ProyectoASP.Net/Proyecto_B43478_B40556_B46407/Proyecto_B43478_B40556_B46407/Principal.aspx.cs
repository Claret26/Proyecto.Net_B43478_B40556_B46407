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

namespace Proyecto_B43478_B40556_B46407
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                PuestoOfertadoData puestoOfertadoData = new PuestoOfertadoData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);
                List<CategoriaPuesto> categorias = puestoOfertadoData.GetCategoriasPuestos();
                CategoriaPuesto categoriaNula = new CategoriaPuesto();
                categoriaNula.NombreCategoria = "Sin Categoría";
                categoriaNula.CodCategoria = -1;
                categorias.Add(categoriaNula);

                ddlCategorias.DataSource = categorias;
                ddlCategorias.DataTextField = "NombreCategoria";
                ddlCategorias.DataValueField = "CodCategoria";
                ddlCategorias.DataBind();

                ddlCategorias.SelectedIndex = ddlCategorias.Items.Count - 1;

                tabla(puestoOfertadoData.GetCantidadPuestosPorCategoria(), gvPuestos);
                tabla(puestoOfertadoData.GetOfertadosCategoria(), gvOfertados);
            }

        }

        private void tabla(List<CategoriaPuesto> puestosCategoria, GridView grid)
        {
            DataTable dt = new DataTable();
            DataRow Row;
            dt.Columns.Add(new DataColumn("Puesto", System.Type.GetType("System.String")));
            dt.Columns.Add(new DataColumn("Cantidad", System.Type.GetType("System.String")));

            foreach (CategoriaPuesto categoriaActual in puestosCategoria)
            {

                Row = dt.NewRow();
                Row["Puesto"] = categoriaActual.NombreCategoria;
                Row["Cantidad"] = categoriaActual.CantidadPuestos;
                dt.Rows.Add(Row);
            }

            grid.DataSource = dt;
            grid.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Solicitante/MostrarPuestos.aspx?codCategoria=" + ddlCategorias.SelectedValue +
                                                                   "&categoria=" + ddlCategorias.SelectedItem.Text +
                                                                   "&palabra=" + tbPalabra.Text);
        }
    }
}