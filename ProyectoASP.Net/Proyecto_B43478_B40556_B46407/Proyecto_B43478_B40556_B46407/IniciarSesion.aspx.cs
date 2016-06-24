using ProyectoLibrary.Common.Domain;
using ProyectoLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_B43478_B40556_B46407
{
    public partial class IniciarSesion : System.Web.UI.Page
    {
        String cadena = WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString;
        private UsuarioData usuarioData;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                alertUsuarioIncorrecto.Visible = false;

                if (this.Page.User.Identity.IsAuthenticated)
                {
                    FormsAuthentication.SignOut();
                    Response.Redirect("~/IniciarSesion.aspx");
                }

                if (User.IsInRole("Administrator"))
                {

                }
            }
        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            String nombreUsuario = tbUsuario.Text;
            String contraseña = tbContrasena.Text;
            usuarioData = new UsuarioData(cadena);
            Usuario usuario = usuarioData.FindUser(nombreUsuario, contraseña);

            if (usuario.IdUsuario == -1 || usuario.IdUsuario == -2)
            {
                alertUsuarioIncorrecto.Visible = true;
            }
            else
            {
                Usuario usuarioAux = usuarioData.GetUsuario(usuario.IdUsuario);
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,
                                                                                 nombreUsuario,
                                                                                 DateTime.Now,
                                                                                 DateTime.Now.AddMinutes(2880),
                                                                                 true,
                                                                                 usuarioAux.Rol, FormsAuthentication.FormsCookiePath);
                String hash = FormsAuthentication.Encrypt(ticket);
                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hash);

                if (ticket.IsPersistent)
                {
                    cookie.Expires = ticket.Expiration;
                }

                Response.Cookies.Add(cookie);
                String urlRegreso = Request.QueryString["ReturnUrl"];

                if (urlRegreso == null)
                {
                    urlRegreso = "/";
                }
                Response.Redirect(urlRegreso);

            }//else
        }
    }
}