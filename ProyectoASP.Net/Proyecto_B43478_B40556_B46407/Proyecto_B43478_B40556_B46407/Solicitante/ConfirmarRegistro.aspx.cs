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
    public partial class ConfirmarRegistro : System.Web.UI.Page
    {
        String cadena = WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString;
        SolicitanteData solicitanteData;
        private SolicitanteTrabajo solicitante;
        private List<EspecialidadSolicitud> listaEspecialidades;
        private List<ExperienciaLaboral> listaExperiencias;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConfirmaRegistro_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (rblConfirmaRegistro.SelectedItem.Value.Equals("Si"))
                {
                    solicitante = (SolicitanteTrabajo)(HttpContext.Current.Session["solicitante"]);
                    listaEspecialidades = (List<EspecialidadSolicitud>)(HttpContext.Current.Session["listaEspecialidades"]);
                    solicitante.ListaEspecialidadesSolicitante = listaEspecialidades;
                    solicitanteData = new SolicitanteData(cadena);
                    solicitanteData.InsertarSolicitante(solicitante);
                }
                else
                {
                    Response.Redirect("~/Principal.aspx");
                }
                
            }
            
        }
    }
}