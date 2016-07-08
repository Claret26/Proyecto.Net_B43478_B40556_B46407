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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                String empresa = Request.QueryString["empresa"];
                String puesto = Request.QueryString["puesto"];

                SolicitanteData solicitanteData = new SolicitanteData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);

                SolicitanteTrabajo solicitante = solicitanteData.GetSolicitantePorUsuario(HttpContext.Current.User.Identity.Name);

                labelEmpresa.Text = "Empresa: " + empresa;
                labelPuesto.Text = "Puesto: " + puesto;
                labelPostulante.Text = "Postulante: " + solicitante.Nombre + " " + solicitante.Apellidos;
                labelTel.Text = "Teléfono: " + solicitante.NumeroCelular;
                labelMail.Text = "Correo: " + solicitante.Email;
            }

        }
    }
}