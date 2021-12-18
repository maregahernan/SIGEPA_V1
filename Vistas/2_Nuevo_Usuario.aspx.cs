using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SIGEPA.Vistas
{
    public partial class _2_Nuevo_Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string patron = "Jose";



        protected void BtnIngresarNuevoUsuario(Object sender, EventArgs e)
        {
            string user = TextBoxUser.Text;
            string pass = TextBoxPass.Text;
            if ((user != "") && (pass != ""))
            {
                string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection sqlConectar = new SqlConnection(conectar);
                SqlCommand cmd = new SqlCommand("SP_AgregarUsuario", sqlConectar)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Connection.Open();
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = TextBoxUser.Text;
                cmd.Parameters.Add("@contraseña", SqlDbType.VarChar, 50).Value = TextBoxPass.Text;
                cmd.Parameters.Add("@patron", SqlDbType.VarChar, 50).Value = patron;
                SqlDataReader dr = cmd.ExecuteReader();

                lblError.Text = "Usuario Registrado";
                cmd.Connection.Close();
            }
            else
            {
                lblError.Text = "Debe completar los datos solicitados";

            }


        }
        protected void BtnVolver(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}