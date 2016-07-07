using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_B43478_B40556_B46407
{
    public partial class AdministratorPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            user.InnerText = HttpContext.Current.User.Identity.Name;
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("IniciarSesion.aspx");
        }
    }
}