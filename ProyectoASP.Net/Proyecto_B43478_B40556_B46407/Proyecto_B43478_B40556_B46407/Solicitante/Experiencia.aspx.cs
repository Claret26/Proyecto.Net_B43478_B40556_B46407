using ProyectoLibrary.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_B43478_B40556_B46407.Solicitante
{
    public partial class Experiencia : System.Web.UI.Page
    {
        List<ExperienciaLaboral> listaExperiencia;
        SolicitanteTrabajo solicitante;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                this.listaExperiencia = new List<ExperienciaLaboral>();
                HttpContext.Current.Session.Add("listaExperiencia", listaExperiencia);
            }
        }

        protected void btnAgregarExperiencia_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                listaExperiencia = (List<ExperienciaLaboral>)(HttpContext.Current.Session["listaExperiencia"]);
                solicitante = (SolicitanteTrabajo)(HttpContext.Current.Session["solicitante"]);
                ExperienciaLaboral experiencia = new ExperienciaLaboral();
                experiencia.Puesto = tbPuesto.Text;
                experiencia.Empresa = tbEmpresa.Text;
                experiencia.FechaIngreso = Convert.ToDateTime(tbFechaInicio.Text);
                experiencia.FechaTermino = Convert.ToDateTime(tbFechaFin.Text);
                experiencia.DescripcionFunciones = txtFunciones.Value;
                experiencia.SolicitanteTrabajo = solicitante;
                listaExperiencia.Add(experiencia);
                HttpContext.Current.Session.Add("listaExperiencia", listaExperiencia);
                gvExperiencia.DataSource = listaExperiencia;
                gvExperiencia.DataBind();
            }
            
        }

        protected void rblExperiencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rblExperiencia.SelectedItem.Value.Equals("Si"))
            {
                lblPuesto.Visible = true;
                tbPuesto.Visible = true;
                lblEmpresa.Visible = true;
                tbEmpresa.Visible = true;
                lblAnoInicio.Visible = true;
                tbFechaInicio.Visible = true;
                lblAnoFin.Visible = true;
                tbFechaFin.Visible = true;
                lblFunciones.Visible = true;
                txtFunciones.Visible = true;
                btnAgregarExperiencia.Visible = true;
            }
            else {
                lblPuesto.Visible = false;
                tbPuesto.Visible = false;
                lblEmpresa.Visible = false;
                tbEmpresa.Visible = false;
                lblAnoInicio.Visible = false;
                tbFechaInicio.Visible = false;
                lblAnoFin.Visible = false;
                tbFechaFin.Visible = false;
                lblFunciones.Visible = false;
                txtFunciones.Visible = false;
                btnAgregarExperiencia.Visible = false;
            } 
        }
    }
}