using ProyectoLibrary.Common.Domain;
using ProyectoLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_B43478_B40556_B46407.Administrador
{
    public partial class ReportesPuesto : System.Web.UI.Page
    {
        private String chain = WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString;
        private EntrevistasData entrevistasData;
        private List<SolicitantePuestoOfertado> listaEntrevistas;
        private PuestoOfertadoData puestoData;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                String codPuesto = Request.QueryString["codPuesto"];
                entrevistasData = new EntrevistasData(chain);
                puestoData = new PuestoOfertadoData(chain);
                this.listaEntrevistas = entrevistasData.GetEntrevistasPorPuesto(int.Parse(codPuesto));
                PuestoOfertado puesto = puestoData.GetPuestoPorId(int.Parse(codPuesto));

                lblNombrePuesto.Text = puesto.DescripcionPuesto;
                gvEntrevistas.DataSource = listaEntrevistas;
                gvEntrevistas.DataBind();
            }
        }
    }
}