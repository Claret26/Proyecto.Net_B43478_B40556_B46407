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
    public partial class EntrevistasProgramadas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                EntrevistasData entrevistasData =
                    new EntrevistasData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);
                List<EntrevistaProgramada> entrevistas = entrevistasData.GetEntrevistas();


                DataTable date = new DataTable("Entrevista_Programada");
                date.Columns.Add("id_entrevista");
                date.Columns.Add("fecha_entrevista");
                date.Columns.Add("hora_entrevista");
                date.Columns.Add("id_trabajo");
                date.Columns.Add("tipo_entrevista");
                date.Columns.Add("id_solicitante");

                foreach (EntrevistaProgramada entreAux in entrevistas)
                {
                    DataRow dr = date.NewRow();
                    dr["id_entrevista"] = entreAux.IdEntrevista;
                    dr["fecha_entrevista"] = entreAux.FechaEntrevista;
                    dr["hora_entrevista"] = entreAux.HoraEntrevista;
                    dr["id_trabajo"] = entrevistasData.GetDescripcionPuesto(entreAux.PuestoOfertado.ClavePuesto);
                    dr["tipo_entrevista"] = entreAux.TipoeEntrevista;
                    dr["id_solicitante"] = entreAux.SolicitanteTrabajo.IdSolicitante;

                    date.Rows.Add(dr);
                }

                GridView1.DataSource = date;
                GridView1.DataBind();

                lb_lugar.Visible = false;
                lb_puesto.Visible = false;
                lb_solicitante.Visible = false;
                lb_tipo.Visible = false;
                Label1.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onMouseOver", "this.style.cursor = 'pointer' ");
                e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventRefere­nce(GridView1, "select$" + e.Row.RowIndex.ToString()));
            }
        }

        protected void btn_consultar_Click(object sender, EventArgs e)
        {
            lb_lugar.Visible = true;
            lb_puesto.Visible = true;
            lb_solicitante.Visible = true;
            lb_tipo.Visible = true;
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            GridViewRow row = GridView1.SelectedRow;
            int codigoEntre = Int32.Parse(row.Cells[0].Text);
            int codSoli = Int32.Parse(row.Cells[5].Text);
            String puesto = row.Cells[3].Text;
            String tipo = row.Cells[4].Text;
            SolicitanteData sd = new SolicitanteData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);
            SolicitanteTrabajo soli = new SolicitanteTrabajo();
            soli = sd.GetSolicutantePorIdSolicidatente(codSoli);
            lb_solicitante.Text = soli.Nombre;
            lb_puesto.Text = puesto;
            lb_tipo.Text = tipo;
            EntrevistasData ed = new EntrevistasData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);
            EntrevistaProgramada ep = new EntrevistaProgramada();
            ep = ed.GetEntrevistaPorEntrevista(codigoEntre);
            lb_lugar.Text = ep.Lugar;
        }
    }
}