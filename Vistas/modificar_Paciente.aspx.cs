using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SIGEPA.Vistas
{
    public partial class modificar_Paciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string NyA = Request.QueryString["pNombre_Apellido"];
                CargarPaciente(NyA);
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            ModiPaciente();
            Response.Redirect("1_Inicio.aspx");
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("1_Inicio.aspx");
        }

        public void CargarPaciente(string NombreyApellido)
        {
            Operaciones_BD cargaPaciente = new Operaciones_BD();
            DataTable dtPaciente = new DataTable();

            dtPaciente = cargaPaciente.CargarPacienteModEli(NombreyApellido);

            lblNyA.Text              = dtPaciente.Rows[0]["Nombre_Apellido"].ToString();
            TextObraSocial.Text      = dtPaciente.Rows[0]["Obra_Social"].ToString();
            TextCantidaSesiones.Text = dtPaciente.Rows[0]["Cant_de_Seciones"].ToString();
            FechaComi.Text           = dtPaciente.Rows[0]["Fecha_Comienzo"].ToString().Substring(0, 10);
            FechaFin.Text            = dtPaciente.Rows[0]["Fecha_Fin"].ToString().Substring(0, 10);
        }
     
        public void ModiPaciente()
        {
            Operaciones_BD Modi = new Operaciones_BD();

            string nombre = lblNyA.Text;
            string obraSocial = TextObraSocial.Text;
            int cantSesiones = Convert.ToUInt16(TextCantidaSesiones.Text);
            DateTime FechaCom = Convert.ToDateTime(FechaComi.Text);
            DateTime Fechafin = Convert.ToDateTime(FechaFin.Text);

            Modi.modificarPaciente(nombre, obraSocial, cantSesiones, FechaCom, Fechafin);

        }
    }
}