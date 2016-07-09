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
    public partial class DatosSolicitante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                String Valor = Request.QueryString["Valor"];
                SolicitanteData soliData =
                     new SolicitanteData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);
                //idS = 16;
                SolicitanteTrabajo solicitanteTrabajo = soliData.GetSolicutantePorIdSolicidatente(Int32.Parse(Valor));
                lbl_nombre.Text = solicitanteTrabajo.Nombre;
                List<EspecialidadSolicitud> especialidadesLista = soliData.GetEspecialidadesPorUsuario(Int32.Parse(Valor));

                //como llenar el DropDownList al agregar varios ListItem
                foreach (EspecialidadSolicitud espeActual in especialidadesLista)
                {//recordar ejemplo de que muestro el nombre pero mando el carne
                    ListItem Item = new ListItem();
                    Item.Value = espeActual.IdEspecialidad + "";
                    Item.Text = espeActual.NombreTituloObtenido;
                    ddl_titulos.Items.Add(Item);
                }



                List<ExperienciaLaboral> experienciaLista = soliData.GetExperienciaLaboralSolicitante(Int32.Parse(Valor));
               

                DataTable dat = new DataTable("Experiencia_Laboral");
                dat.Columns.Add("empresa");
                dat.Columns.Add("puesto");
                dat.Columns.Add("fecha_ingreso");
                dat.Columns.Add("fecha_termino");

                foreach (ExperienciaLaboral libroAux in experienciaLista)
                {
                    DataRow dr = dat.NewRow();
                    dr["empresa"] = libroAux.Empresa;
                    dr["Puesto"] = libroAux.Puesto;
                    dr["fecha_ingreso"] = libroAux.FechaIngreso;
                    dr["fecha_termino"] = libroAux.FechaTermino;

                    dat.Rows.Add(dr);
                }

                /*puedo omitir el paso anterior y toma los nombres de la base de datos por medio de lista 
                y en lugar de dt pondria la lista para que funcione
                acordar ir a las propiedades y cambiar el evento(rayito )por pageLoad*/
                GridView1.DataSource = dat;
                GridView1.DataBind();

            }//if
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String Valor = Request.QueryString["Valor"];
            String idSoli = Valor;
            Response.Redirect("CreaEntrevista.aspx?Valor=" + idSoli);
            Response.Write("<script type='text/javascript'>window.open('CreaEntrevista.aspx','cal','width=700,height=250,left=270,top=180');</script>");

        }
    }
}