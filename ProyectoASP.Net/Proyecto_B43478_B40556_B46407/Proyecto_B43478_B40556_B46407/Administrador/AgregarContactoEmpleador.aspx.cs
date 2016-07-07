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
    public partial class AgregarContactoEmpleador : System.Web.UI.Page
    {
        private ClienteEmpleador clienteEmpleador = new ClienteEmpleador();

        protected void Page_Load(object sender, EventArgs e)
        {

            this.clienteEmpleador.NombreCompania = Request.QueryString["empresa"];
            this.clienteEmpleador.Direccion = Request.QueryString["direccion"];
            this.clienteEmpleador.Ciudad = Request.QueryString["ciudad"];
            this.clienteEmpleador.CodigoPostal = Int32.Parse(Request.QueryString["codigo"]);
            this.clienteEmpleador.Provincia = Request.QueryString["provincia"];

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            ContactoEmpleador contactoEmpleador = new ContactoEmpleador();
            contactoEmpleador.ClienteEmpleador = this.clienteEmpleador;
            contactoEmpleador.NombreConstacto = tbNombre.Text;
            contactoEmpleador.Designacion = tbAsignacion.Text;
            contactoEmpleador.Email = tbCorreo.Text;
            contactoEmpleador.Extencion = Int32.Parse(tbExt.Text);
            contactoEmpleador.Fax = Int32.Parse(tbFax.Text);
            contactoEmpleador.Telefono = Int32.Parse(tbTelefono.Text);

            contactoEmpleador.NombreUsuario = tbUsuario.Text;
            contactoEmpleador.ClaveAcceso = tbContrasena.Text;

            ClienteEmpleadorData clienteEmpleadorData = new ClienteEmpleadorData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);
            clienteEmpleadorData.InsertarClienteEmpleador(contactoEmpleador);
        }
    }
}