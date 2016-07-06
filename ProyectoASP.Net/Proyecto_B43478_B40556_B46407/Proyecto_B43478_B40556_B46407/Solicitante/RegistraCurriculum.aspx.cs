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
    public partial class RegistraCurriculum : System.Web.UI.Page
    {
        String cadena = WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString;
        SolicitanteTrabajo solicitante;
        UsuarioData usuarioData;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                tbCedulaSolicitante.Focus();
            }
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                solicitante = new SolicitanteTrabajo();
                usuarioData = new UsuarioData(cadena);
                solicitante.IdSolicitante = int.Parse(tbCedulaSolicitante.Text);
                solicitante.Nombre = tbNombreSolicitante.Text;
                solicitante.Apellidos = tbApellidosSolicitantes.Text;
                solicitante.FechaNacimiento = Convert.ToDateTime(tbFechaNacimiento.Text);
                solicitante.Genero = rblGenero.SelectedItem.Value;
                solicitante.EstadoCivil = ddlEstadoCivil.SelectedItem.Value;
                solicitante.Provincia = ddlProvincias.SelectedItem.Value;
                solicitante.Ciudad = tbCiudad.Text;
                solicitante.Direccion = txtDireccion.Value;
                solicitante.NumeroCelular = int.Parse(tbCelularSolicitante.Text);
                solicitante.TelefonoCasa = int.Parse(tbTelefonoCasa.Text);
                solicitante.NombreUsuario = HttpContext.Current.User.Identity.Name;
                Usuario usuario = usuarioData.GetUsuarioPorNombre(solicitante.NombreUsuario);
                solicitante.Clave = usuario.Contrasena;
                solicitante.Email = usuario.Email;
                HttpContext.Current.Session.Add("solicitante", solicitante);

                Server.Transfer("Estudios.aspx");
            }
            else
            {
                tbCedulaSolicitante.Focus();
            }
        }
    }
}