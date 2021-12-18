using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace SIGEPA.Vistas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void BtnNuevoUsuario(object sender, EventArgs e)
        {
            Response.Redirect("2_Nuevo_Usuario.aspx");
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        string patron = "Jose";
        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            if ((TextBoxUser.Text == " ") || (TextBoxPass.Text == " "))
            {
                lblError.Text = "Debe completar los datos solicitados";
            }
            string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection sqlConectar = new SqlConnection(conectar);
            SqlCommand cmd = new SqlCommand("SP_ValidarUsuario", sqlConectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Connection.Open();
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = TextBoxUser.Text;
            cmd.Parameters.Add("@contraseña", SqlDbType.VarChar, 50).Value = TextBoxPass.Text;
            cmd.Parameters.Add("@patron", SqlDbType.VarChar, 50).Value = patron;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["UsuarioLogueado"] = TextBoxUser.Text;
                Response.Redirect("1_Inicio.aspx");
            }
            else
            {

                lblError.Text = "Usuario o Password incorrectos.";

            }
            cmd.Connection.Close();
        }
    }
}