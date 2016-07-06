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
    public partial class Estudios : System.Web.UI.Page
    {
        List<AreaEspecialidad> listaAreas;
        List<NivelEstudio> listaNiveles;
        List<EspecialidadSolicitud> listaEspecialidades;
        List<InstitucionEstudio> listaInstituciones;
        EspecialidadData especialidadData;
        NivelEstudioData nivelData;
        InstitucionData institucionData;
        String cadena = WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                especialidadData = new EspecialidadData(cadena);
                nivelData = new NivelEstudioData(cadena);
                institucionData = new InstitucionData(cadena);
                listaAreas = especialidadData.GetEspecialidades();
                listaNiveles = nivelData.GetNivelesEstudio();
                listaInstituciones = institucionData.GetInstituciones();

                ddlEspecialidades.DataSource = listaAreas;
                ddlEspecialidades.DataValueField = "CodAareaEspecialidad";
                ddlEspecialidades.DataTextField = "DescripcionAreaEspecialidad";
                ddlEspecialidades.DataBind();

                ddlNivelesDeEstudio.DataSource = listaNiveles;
                ddlNivelesDeEstudio.DataValueField = "CodNivelEstudio";
                ddlNivelesDeEstudio.DataTextField = "DescripcionNivelEstudio";
                ddlNivelesDeEstudio.DataBind();

                ddlInstituciones.DataSource = listaInstituciones;
                ddlInstituciones.DataValueField = "CodInstitucion";
                ddlInstituciones.DataTextField = "NombreInstitucion";
                ddlInstituciones.DataBind();
                ddlInstituciones.Items.Add(new ListItem("Otro", "Otro"));

                listaEspecialidades = new List<EspecialidadSolicitud>();
                HttpContext.Current.Session.Add("listaEspecialidades", listaEspecialidades);
            }
        }

        protected void ddlNivelesDeEstudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ddlNivelesDeEstudio.SelectedItem.Value)
            {
                case "5":
                    lblEspecialidad.Visible = true;
                    ddlEspecialidades.Visible = true;
                    break;
                case "6":
                    lblEspecialidad.Visible = true;
                    ddlEspecialidades.Visible = true;
                    break;
            }
            tbInstitucion.Focus();
        }

        protected void btnAgregarEstudio_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                listaEspecialidades = (List<EspecialidadSolicitud>)(HttpContext.Current.Session["listaEspecialidades"]);
                EspecialidadSolicitud especialidad = new EspecialidadSolicitud();

                especialidad.NivelEstudio.DescripcionNivelEstudio = ddlNivelesDeEstudio.SelectedItem.Text;
                especialidad.NivelEstudio.CodNivelEstudio = int.Parse(ddlNivelesDeEstudio.SelectedItem.Value);
                especialidad.AreaEspecialidad.DescripcionAreaEspecialidad = ddlEspecialidades.SelectedItem.Text;
                especialidad.AreaEspecialidad.CodAareaEspecialidad = int.Parse(ddlEspecialidades.SelectedItem.Value);
                especialidad.NombreTituloObtenido = tbTituloObtenido.Text;
                especialidad.AnoInicio = int.Parse(tbAnoInicio.Text);
                especialidad.AnoFinalizacion = int.Parse(tbAnoFinalizacion.Text);

                if (ddlInstituciones.SelectedItem.Value.Equals("Otro"))
                {
                    especialidad.InstitucionEstudio.NombreInstitucion = tbInstitucion.Text;
                }
                else
                {
                    especialidad.InstitucionEstudio.NombreInstitucion = ddlInstituciones.SelectedItem.Text;
                    especialidad.InstitucionEstudio.CodInstitucion = int.Parse(ddlInstituciones.SelectedItem.Value);
                }
                

                listaEspecialidades.Add(especialidad);

                HttpContext.Current.Session.Add("listaEspecialidades", listaEspecialidades);

                lblEstudios.Visible = true;
                gvEstudios.DataSource = listaEspecialidades;
                gvEstudios.DataBind();
            }
            
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            Server.Transfer("Experiencia.aspx");
        }

        protected void ddlInstituciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlInstituciones.SelectedItem.Value.Equals("Otro"))
            {
                tbInstitucion.Visible = true;
                rfvInstitucion.Enabled = true;
            }
            else
            {
                tbInstitucion.Visible = false;
                rfvInstitucion.Enabled = true;
            }
        }
    }
}