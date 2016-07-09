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
    public partial class Entrevistas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {

                SolicitanteData solicitanteData =
                      new SolicitanteData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);


                 SolicitanteTrabajo solicitante = solicitanteData.GetSolicutantePorNombreUsuario(HttpContext.Current.User.Identity.Name);

                 int idSolicitante = solicitante.IdSolicitante;

                EntrevistasData entrevistaData =
                new EntrevistasData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);

                List<EntrevistaProgramada> entrevistas = entrevistaData.GetEntrevistasPorUsuario(idSolicitante);

                //Para pornerle nombre a las columnas 

                /*  DataTable dt = new DataTable("Entrevista_Programada");
                  dt.Columns.Add("Fecha");
                  dt.Columns.Add("Hora");
                  dt.Columns.Add("Tipo");

                  foreach (EntrevistaProgramada libroAux in entrevistas)
                  {
                      DataRow dr = dt.NewRow();
                      dr["fecha_entrevista"] = libroAux.FechaEntrevista;
                      dr["hora_entrevista"] = libroAux.HoraEntrevista;
                      dr["tipo_entrevista"] = libroAux.HoraEntrevista;


                      dt.Rows.Add(dr);
                  }
                  */
                /*puedo omitir el paso anterior y toma los nombres de la base de datos por medio de lista 
                y en lugar de dt pondria la lista para que funcione
                acordar ir a las propiedades y cambiar el evento(rayito )por pageLoad*/

                GridView1.DataSource = entrevistas;
                GridView1.DataBind();


            }//if
        }
    }
}