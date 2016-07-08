using ProyectoLibrary.Common.Domain;
using ProyectoLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_B43478_B40556_B46407.Solicitante
{
    public partial class Concursar : System.Web.UI.Page
    {
        private SolicitanteData solicitanteData;
        private PuestoOfertado puestoOfertado;
        private String empresa;
        private String puesto;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                empresa = Request.QueryString["empresa"];
                puesto = Request.QueryString["puesto"];

                solicitanteData = new SolicitanteData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);

                SolicitanteTrabajo solicitante = solicitanteData.GetSolicitantePorUsuario(HttpContext.Current.User.Identity.Name);

                labelEmpresa.Text = "Empresa: " + empresa;
                labelPuesto.Text = "Puesto: " + puesto;
                labelPostulante.Text = "Postulante: " + solicitante.Nombre + " " + solicitante.Apellidos;
                labelTel.Text = "Teléfono: " + solicitante.NumeroCelular;
                labelMail.Text = "Correo: " + solicitante.Email;
            }

        }

        protected void btnConcursar_Click(object sender, EventArgs e)
        {
            empresa = Request.QueryString["empresa"];
            puesto = Request.QueryString["puesto"];

            solicitanteData = new SolicitanteData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);

            SolicitanteTrabajo solicitante = solicitanteData.GetSolicitantePorUsuario(HttpContext.Current.User.Identity.Name);
            PuestoOfertadoData puestoOfertadoData = new PuestoOfertadoData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);
            this.puestoOfertado = puestoOfertadoData.GetPuestoPorNombreYCompania(this.puesto, this.empresa);

            SolicitantePuestoOfertado solicitantePuestoOfertado = new SolicitantePuestoOfertado();
            solicitantePuestoOfertado.Activo = true;
            solicitantePuestoOfertado.SolicitanteTrabajo = solicitante;
            solicitantePuestoOfertado.PuestoOfertado = puestoOfertado;

            SolicitantePuestoData solicitantePuestoData = new SolicitantePuestoData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);
            solicitantePuestoData.InsertarSolicitantePuesto(solicitantePuestoOfertado);
        }
    }
}