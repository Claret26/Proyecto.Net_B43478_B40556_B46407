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
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {

                SolicitanteData solicitanteData =
                     new SolicitanteData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);


                SolicitanteTrabajo solicitante = solicitanteData.GetSolicutantePorNombreUsuario(HttpContext.Current.User.Identity.Name);

                lb_nombre.Text = solicitante.Nombre;
                lb_apellidos.Text = solicitante.Apellidos;
                lb_direcion.Text = solicitante.Direccion;
                lb_celular.Text = solicitante.NumeroCelular+"";
                lb_casa.Text = solicitante.TelefonoCasa+"";
                lb_fechaNacimiento.Text = solicitante.FechaNacimiento+"";

                /*solicitante.idSolicitante*/

                List<EspecialidadSolicitud> especialidades = solicitanteData.GetEspecialidadesPorUsuario(solicitante.IdSolicitante);
                foreach (EspecialidadSolicitud espeActual in especialidades)
                {
                    ListItem Item = new ListItem();
                    Item.Value = espeActual.IdEspecialidad + "";
                    Item.Text = espeActual.NombreTituloObtenido;
                    ddl_titulosExistentes.Items.Add(Item);
                }

                EspecialidadData ed =
                    new EspecialidadData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);

                List<AreaEspecialidad> especialidadesLista = ed.GetEspecialidades();
                foreach (AreaEspecialidad espActual in especialidadesLista)
                {
                    ListItem Item = new ListItem();
                    Item.Value = espActual.CodAareaEspecialidad + "";
                    Item.Text = espActual.DescripcionAreaEspecialidad;
                    ddl_areaEspecialidad.Items.Add(Item);
                }

                InstitucionData id =
                    new InstitucionData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);
                List<InstitucionEstudio> instirucionesLista = id.GetInstituciones();
                foreach (InstitucionEstudio insActual in instirucionesLista)
                {
                    ListItem Item = new ListItem();
                    Item.Value = insActual.CodInstitucion + "";
                    Item.Text = insActual.NombreInstitucion;
                    ddl_InstitucionEstudio.Items.Add(Item);
                }

                NivelEstudioData ne =
                    new NivelEstudioData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);
                List<NivelEstudio> nivelLista = ne.GetNivelesEstudio();
                foreach (NivelEstudio nivelActual in nivelLista)
                {
                    ListItem Item = new ListItem();
                    Item.Value = nivelActual.CodNivelEstudio + "";
                    Item.Text = nivelActual.DescripcionNivelEstudio;
                    ddl_nivelEstudio.Items.Add(Item);
                }
            }//if
        }

       

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            SolicitanteData solicitanteData =
                    new SolicitanteData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);

            SolicitanteTrabajo solicitante = solicitanteData.GetSolicutantePorNombreUsuario(HttpContext.Current.User.Identity.Name);

            EspecialidadData espeData =
                new EspecialidadData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);

            espeData.EliminarEspecialidad(Int32.Parse(ddl_titulosExistentes.SelectedItem.Value) , solicitante.IdSolicitante);
        }

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            SolicitanteData solicitanteData =
                   new SolicitanteData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);

            SolicitanteTrabajo solicitante = solicitanteData.GetSolicutantePorNombreUsuario(HttpContext.Current.User.Identity.Name);

            EspecialidadData esd =
                 new EspecialidadData(WebConfigurationManager.ConnectionStrings["BuscandoEmpleo"].ConnectionString);

            EspecialidadSolicitud es = new EspecialidadSolicitud();
            es.Solicitante = solicitante.IdSolicitante;
            es.AreaEspecialidad.CodAareaEspecialidad = Int32.Parse(ddl_areaEspecialidad.SelectedItem.Value);
            es.InstitucionEstudio.CodInstitucion = Int32.Parse(ddl_InstitucionEstudio.SelectedItem.Value);
            es.NivelEstudio.CodNivelEstudio = Int32.Parse(ddl_nivelEstudio.SelectedItem.Value);
            es.AnoInicio = Int32.Parse(TextBox1.Text);
            es.AnoFinalizacion = Int32.Parse(TextBox2.Text);
            es.NombreTituloObtenido = TextBox3.Text;
            esd.InsertarEspecialidad(es);
        }
    }
}