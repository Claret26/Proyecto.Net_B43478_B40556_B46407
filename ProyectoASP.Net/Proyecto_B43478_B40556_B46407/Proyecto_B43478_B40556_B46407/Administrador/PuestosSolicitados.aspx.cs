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

namespace Proyecto_B43478_B40556_B46407.Administrador
{
    public partial class PuestosSolicitados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SolicitantePuestoOfertadoData solicitantePuestoData =
                    new SolicitantePuestoOfertadoData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);
            List<SolicitantePuestoOfertado> solicitantes = solicitantePuestoData.GetSolicitudesPuestosOfertados();

            SolicitanteTrabajo s = new SolicitanteTrabajo();
            PuestoOfertado p = new PuestoOfertado();

            DataTable datat = new DataTable("Solicitante_PuestoOfertado");
            datat.Columns.Add("Id");
            datat.Columns.Add("Solicitante");
            datat.Columns.Add("Puesto");

            foreach (SolicitantePuestoOfertado soliAux in solicitantes)
            {
                DataRow dr = datat.NewRow();
                dr["Id"] = soliAux.SolicitanteTrabajo.IdSolicitante;
                s = solicitantePuestoData.GetSolicitantePorId(soliAux.SolicitanteTrabajo.IdSolicitante);
                dr["Solicitante"] = s.Nombre;
                p.DescripcionPuesto = solicitantePuestoData.GetDescripcionPuesto(soliAux.PuestoOfertado.ClavePuesto);
                dr["Puesto"] = p.DescripcionPuesto;

                datat.Rows.Add(dr);
            }
            GridView1.DataSource = datat;
            GridView1.DataBind();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onMouseOver", "this.style.cursor = 'pointer' ");
                e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventRefere­nce(GridView1, "select$" + e.Row.RowIndex.ToString()));
            }
        }

        protected void btn_ver_Click(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            int codigoSoli = Int32.Parse(row.Cells[0].Text);

            String Valor = codigoSoli + "";
            Response.Redirect("DatosSolicitante.aspx?valor=" + Valor);
            Response.Write("<script type='text/javascript'>window.open('DatosSolicitante.aspx','cal','width=700,height=250,left=270,top=180');</script>");

        }
    }
}