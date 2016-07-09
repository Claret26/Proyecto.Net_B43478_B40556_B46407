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
    public partial class CreaEntrevista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                String Valor = Request.QueryString["Valor"];
                int id = Int32.Parse(Valor);
                SolicitanteData soliData =
                     new SolicitanteData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);
                SolicitanteTrabajo solicitanteTrabajo = soliData.GetSolicutantePorIdSolicidatente(id);
                Label1.Text = solicitanteTrabajo.Nombre;

                List<PuestoOfertado> listaPuestos = soliData.GetPuestosSolicitadosPoSolicitante(id);
                foreach (PuestoOfertado puesActual in listaPuestos)
                {
                    ListItem Item = new ListItem();
                    Item.Value = puesActual.ClavePuesto + "";
                    Item.Text = puesActual.DescripcionPuesto;
                    ddl_puestos.Items.Add(Item);
                }


            }
        }

        protected void btn_crear_Click(object sender, EventArgs e)
        {
            EntrevistasData entrevistaData =
               new EntrevistasData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);

            String Valor = Request.QueryString["Valor"];
            int id = Int32.Parse(Valor);
            EntrevistaProgramada entrevistaP = new EntrevistaProgramada();
            entrevistaP.HoraEntrevista = tb_hora.Text;
            entrevistaP.FechaEntrevista = DateTime.Parse(tb_fecha.Text);
            entrevistaP.TipoeEntrevista = ddl_tipo.SelectedItem.Value;
            entrevistaP.IdSolitante = id;
            entrevistaP.PuestoOfertado.ClavePuesto = Int32.Parse(ddl_puestos.SelectedItem.Value);
            entrevistaP.Empleado.IdEmpleado = 1;
            entrevistaP.Lugar = tb_lugar.Text;

            entrevistaData.InsertarEntrevista(entrevistaP);
        }
    }
}