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
            ClienteEmpleador clienteEmpleador = new ClienteEmpleador();
            clienteEmpleador.IdClienteEmpleador = Int32.Parse(tbCedula.Text);
            clienteEmpleador.NombreCompania = tbCompania.Text;
            clienteEmpleador.Direccion = tbDireccion.Text;
            clienteEmpleador.Ciudad = tbCanton.Text;
            clienteEmpleador.Provincia = tbProvincia.Text;
            clienteEmpleador.CodigoPostal = Int32.Parse(tbCodigo.Text);

            ContactoEmpleador contactoEmpleador = new ContactoEmpleador();
            contactoEmpleador.ClienteEmpleador = clienteEmpleador;
            contactoEmpleador.NombreConstacto = tbNombre.Text;
            contactoEmpleador.Designacion = tbAsignacion.Text;
            contactoEmpleador.Email = tbCorreo.Text;
            contactoEmpleador.Extencion = Int32.Parse(tbExt.Text);
            contactoEmpleador.Fax = Int32.Parse(tbFax.Text);
            contactoEmpleador.Telefono = Int32.Parse(tbTelefono.Text);

            contactoEmpleador.NombreUsuario = "Prueba";
            contactoEmpleador.ClaveAcceso = "Prueba";

            ClienteEmpleadorData clienteEmpleadorData = new ClienteEmpleadorData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);
            clienteEmpleadorData.InsertarClienteEmpleador(clienteEmpleador, contactoEmpleador);

            Email correo = new Email();
            String cuerpo = "Te damos la bienvenida a Proyecto Bolsa de Empleo. Acontinuación encontrará sus datos:\n" + "Usuario: " + contactoEmpleador.NombreUsuario + "\n" + "Clave de Acceso: " + contactoEmpleador.ClaveAcceso;
            correo.enviarMensaje("lenguajesbolsaempleo@gmail.com", "bolsaEmpleo..", tbCorreo.Text, cuerpo);
        }
    }
}