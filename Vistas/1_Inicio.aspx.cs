using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SIGEPA
{
    public partial class _1_Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridPacientes.DataSource = CargarPacientes();
                GridPacientes.DataBind();
            }
        }
        public DataTable CargarPacientes()
        {
            Operaciones_BD llenaGrilla = new Operaciones_BD();
            return llenaGrilla.CargarPaciente();
        }

        protected void GridPacientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Editar")
            {
                Response.Redirect("modificar_Paciente.aspx?pNombre_Apellido=" + e.CommandArgument);
            }
            else
            {
                Response.Redirect("eliminar_Paciente.aspx?pNombre_Apellido=" + e.CommandArgument);
            }
        }
    }
}