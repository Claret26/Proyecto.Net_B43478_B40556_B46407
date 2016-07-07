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
    public partial class ReportesCompania : System.Web.UI.Page
    {
        private String chain = WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString;
        private PuestoOfertadoData puestoOferData;
        private ClienteEmpleadorData clienteEmpleadorData;
        private List<PuestoOfertado> listaPuestos;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                String codCliente = Request.QueryString["codCliente"];
                puestoOferData = new PuestoOfertadoData(chain);
                clienteEmpleadorData = new ClienteEmpleadorData(chain);

                listaPuestos = puestoOferData.GetPuestosPorCompania(int.Parse(codCliente));
                ClienteEmpleador clienteEmp = clienteEmpleadorData.GetClientePorID(int.Parse(codCliente));

                lblNombreCompania.Text = clienteEmp.NombreCompania;
                gvPuestos.DataSource = listaPuestos;
                gvPuestos.DataBind();
            }
        }
    }
}