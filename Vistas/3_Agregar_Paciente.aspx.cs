using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIGEPA.Vistas
{
    public partial class _3_Agregar_Paciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarPaciente();
            ClientScript.RegisterStartupScript(this.GetType(), "RegistroOK", "registro_OK()", true);


        }

        public void volverInicio()
        {
            Response.Redirect("1_Inicio.aspx");
        }
        public void agregarPaciente()
        {
            Operaciones_BD agregar = new Operaciones_BD();

            string nombre       = TextNyA.Text;
            string obraSocial   = TextObraSocial.Text;
            int cantSesiones    = Convert.ToUInt16(TextCantidaSesiones.Text);
            DateTime FechaCom   = Convert.ToDateTime(FechaComi.Text);
            DateTime Fechafin   = Convert.ToDateTime(FechaFin.Text);


            agregar.AgregarPaciente(nombre,obraSocial,cantSesiones,FechaCom,Fechafin);
           

        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            volverInicio();
        }
    }
}