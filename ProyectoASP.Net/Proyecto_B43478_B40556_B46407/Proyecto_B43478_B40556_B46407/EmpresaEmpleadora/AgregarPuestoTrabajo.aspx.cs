using ProyectoLibrary.Common.Domain;
using ProyectoLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_B43478_B40556_B46407.EmpresaEmpleadora
{
    public partial class AgregarPuestoTrabajo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)
            {
                PuestoOfertadoData puestoOfertadoData = new PuestoOfertadoData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);
                List<CategoriaPuesto> categorias = puestoOfertadoData.GetCategoriasPuestos();

                ddlCategorias.DataSource = categorias;
                ddlCategorias.DataTextField = "NombreCategoria";
                ddlCategorias.DataValueField = "CodCategoria";
                ddlCategorias.DataBind();
            }

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            CategoriaPuesto categoriaPuesto = new CategoriaPuesto();
            categoriaPuesto.CodCategoria = Int32.Parse(ddlCategorias.SelectedValue);
            categoriaPuesto.NombreCategoria = ddlCategorias.SelectedItem.Text;

            ClienteEmpleadorData clienteData = new ClienteEmpleadorData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);
            String usuario = HttpContext.Current.User.Identity.Name;
            ClienteEmpleador clienteEmplador = new ClienteEmpleador();
            clienteEmplador = clienteData.GetClientePorUsuario(usuario);

            PuestoOfertado puestoOfertado = new PuestoOfertado();
            puestoOfertado.CategoriaPuesto = categoriaPuesto;
            puestoOfertado.ClienteEmpleador = clienteEmplador;
            puestoOfertado.Abierto = 0;
            puestoOfertado.Ciudad = tbCiudad.Text;
            puestoOfertado.DescripcionPuesto = tbDescripcion.Text;
            puestoOfertado.DiasLaborar = tbDias.Text;
            puestoOfertado.ExperienciaRequerida = tbexperiencia.Text;
            puestoOfertado.HoraSalida = tbSalida.Text;
            puestoOfertado.HoraEntrada = tbHora.Text;
            puestoOfertado.NumeroVacantes = Int32.Parse(tbVacantes.Text);
            puestoOfertado.Provincia = tbProvincia.Text;
            puestoOfertado.Sueldo = float.Parse(tbSalario.Text);

            PuestoOfertadoData puestoOfertadoData = new PuestoOfertadoData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);
            puestoOfertadoData.InsertarPuestoOfertado(puestoOfertado);
        }
    }
}