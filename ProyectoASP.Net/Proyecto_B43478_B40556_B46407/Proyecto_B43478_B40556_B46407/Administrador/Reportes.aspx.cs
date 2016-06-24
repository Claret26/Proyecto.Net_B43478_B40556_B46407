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
    public partial class Reportes : System.Web.UI.Page
    {
        private String chain = WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString;
        private ClienteEmpleadorData clienteEmpData;
        private PuestoOfertadoData puestoOferData;
        private List<ClienteEmpleador> listaClientes;
        private List<PuestoOfertado> listaPuestos;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                clienteEmpData = new ClienteEmpleadorData(chain);
                puestoOferData = new PuestoOfertadoData(chain);
                listaClientes = clienteEmpData.GetClientesEmpleadores();
                listaPuestos = puestoOferData.GetPuestos();

                ddlCompanias.DataSource = listaClientes;
                ddlCompanias.DataTextField = "nombreCompania";
                ddlCompanias.DataValueField = "idClienteEmpleador";
                ddlCompanias.DataBind();

                ddlPuestosDeTrabajo.DataSource = listaPuestos;
                ddlPuestosDeTrabajo.DataTextField = "descripcionPuesto";
                ddlPuestosDeTrabajo.DataValueField = "clavePuesto";
                ddlPuestosDeTrabajo.DataBind();
            }
        }

        protected void ddlPuestosDeTrabajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBuscarPorPuesto.Visible = true;
        }

        protected void ddlCompanias_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBuscarPorCompania.Visible = true;
        }

        protected void btnBuscarPorCompania_Click(object sender, EventArgs e)
        {
            String codCliente = ddlCompanias.SelectedItem.Value;
            Response.Redirect("ReportesCompania.aspx?codCliente="+codCliente);
        }

        protected void btnBuscarPorPuesto_Click(object sender, EventArgs e)
        {
            String codPuesto = ddlPuestosDeTrabajo.SelectedItem.Value;
            Response.Redirect("ReportesPuesto.aspx?codPuesto="+codPuesto);
        }
    }
}