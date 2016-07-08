using ProyectoLibrary.Common.Domain;
using ProyectoLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_B43478_B40556_B46407
{
    public partial class Registro : System.Web.UI.Page
    {
        String cadena = WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString;
        UsuarioData usuarioData;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                alertContrasenasIncorrectas.Visible = false;

            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
           cvContrasenas.Operator = ValidationCompareOperator.Equal;
           cvContrasenas.Validate();

            if (!Page.IsValid)
            {
                alertContrasenasIncorrectas.Visible = true;
            }
            else
            {
                alertContrasenasIncorrectas.Visible = false;
                usuarioData = new UsuarioData(cadena);
                String nombreUsuario = tbNombreUsuario.Text;
                if (usuarioData.ComprobarUsuarioExistente(nombreUsuario))
                {
                    Usuario usuario = new Usuario();
                    usuario.NombreUsuario = nombreUsuario;
                    usuario.Contrasena = tbPassword.Text;
                    usuario.Email = tbEmail.Text;
                    usuario.Rol = "User";
                    usuarioData.InsertarUsuario(usuario);
                    Response.Redirect("IniciarSesion.aspx");
                }
                else
                {
                    alertContrasenasIncorrectas.InnerText = "Usuario existente";
                    alertContrasenasIncorrectas.Visible = true;
                    tbNombreUsuario.Focus();
                    tbNombreUsuario.ForeColor = System.Drawing.Color.Red;
                    tbNombreUsuario.BorderColor = System.Drawing.Color.Red;
                }
            }

            
        }
    }
}