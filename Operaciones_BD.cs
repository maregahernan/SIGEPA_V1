using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace SIGEPA
{
    public class Operaciones_BD
    {
        SqlConnection conexion;
        SqlCommand comando;
        DataTable dtPaciente;
        SqlDataAdapter adaptador;

        public Operaciones_BD()
        {

            conexion = new SqlConnection(@"Server=NWKS0275\HMMSQL;DataBase=JR_Pacientes;Trusted_Connection=true;");
        
        }

        public DataTable CargarPaciente()
        {
            comando = new SqlCommand();
            comando.Connection  = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_LLena_Grilla";

            adaptador = new SqlDataAdapter();
            dtPaciente = new DataTable();

            conexion.Open();

            adaptador.SelectCommand = comando;
            adaptador.Fill(dtPaciente);

            conexion.Close();
            return dtPaciente;
        }
        public void AgregarPaciente(string nombre, string obraSocial, int cantSes, DateTime fechaComi, DateTime fechaFin)
        {
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_AgregarPaciente";

            

            conexion.Open();

            comando.Parameters.AddWithValue("Nombre_Apellido",nombre);
            comando.Parameters.AddWithValue("Obra_Social", obraSocial);
            comando.Parameters.AddWithValue("Cant_de_Seciones",cantSes);
            comando.Parameters.AddWithValue("Fecha_Comienzo",fechaComi);
            comando.Parameters.AddWithValue("Fecha_Fin", fechaFin);

            comando.ExecuteNonQuery();
 
            conexion.Close();
            
        }

        public DataTable CargarPacienteModEli(string NombreyApellido)
        {
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_Carga_Paciente";

            comando.Parameters.AddWithValue("pNombre_Apellido", NombreyApellido);


            adaptador = new SqlDataAdapter();
            dtPaciente = new DataTable();

            conexion.Open();

            adaptador.SelectCommand = comando;
            adaptador.Fill(dtPaciente);

            conexion.Close();
            return dtPaciente;
        }

        public void modificarPaciente(string nombre, string obraSocial, int cantSes, DateTime fechaComi, DateTime fechaFin)
        {
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_ModificarPaciente";



            conexion.Open();

            comando.Parameters.AddWithValue("Nombre_Apellido", nombre);
            comando.Parameters.AddWithValue("Obra_Social", obraSocial);
            comando.Parameters.AddWithValue("Cant_de_Seciones", cantSes);
            comando.Parameters.AddWithValue("Fecha_Comienzo", fechaComi);
            comando.Parameters.AddWithValue("Fecha_Fin", fechaFin);

            comando.ExecuteNonQuery();

            conexion.Close();

        }

        public void eliminarPaciente(string nombre)
        {
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_EliminarPaciente";



            conexion.Open();

            comando.Parameters.AddWithValue("Nombre_Apellido", nombre);
        
            comando.ExecuteNonQuery();

            conexion.Close();

        }

    }


}