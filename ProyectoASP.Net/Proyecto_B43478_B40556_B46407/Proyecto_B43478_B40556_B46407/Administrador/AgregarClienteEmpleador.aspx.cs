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
    public partial class AgregarClienteEmpleador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarContactoEmpleador.aspx?empresa=" + tbCompania.Text +
                                                            "&direccion=" + tbDireccion.Text +
                                                            "&provincia=" + tbProvincia.Text +
                                                            "&ciudad=" + tbCiudad.Text +
                                                            "&codigo=" + tbCodigo.Text);
        }
    }
}