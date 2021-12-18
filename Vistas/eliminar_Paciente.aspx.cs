using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;



namespace SIGEPA.Vistas
{
    public partial class eliminar_Paciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string NyA = Request.QueryString["pNombre_Apellido"];
                CargarPaciente(NyA);
            }

        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("1_Inicio.aspx");
        }

        protected void btnEliminiar_Click(object sender, EventArgs e)
        {
            EliPaciente();
            Response.Redirect("1_Inicio.aspx");
        }

        public void CargarPaciente(string NombreyApellido)
        {
            Operaciones_BD cargaPaciente = new Operaciones_BD();
            DataTable dtPaciente = new DataTable();

            dtPaciente = cargaPaciente.CargarPacienteModEli(NombreyApellido);

            lblNyA.Text          = dtPaciente.Rows[0]["Nombre_Apellido"].ToString();
            lblObraSocial.Text   = dtPaciente.Rows[0]["Obra_Social"].ToString();
            lblCantSesiones.Text = dtPaciente.Rows[0]["Cant_de_Seciones"].ToString();
            lblComiTra.Text      = dtPaciente.Rows[0]["Fecha_Comienzo"].ToString().Substring(0, 10);
            lblFinTra.Text       = dtPaciente.Rows[0]["Fecha_Fin"].ToString().Substring(0, 10);
        }
        public void EliPaciente()
        {
            string Nya = lblNyA.Text;
            Operaciones_BD eli = new Operaciones_BD();
            eli.eliminarPaciente(Nya);
        }
    }
}