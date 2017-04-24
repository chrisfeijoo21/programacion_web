using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;
using System.Data.SqlClient;

namespace Repositorio
{
    public class TurnoRepo
    {
        public DataTable BuscarPersona()
        {
            DataTable dt = new DataTable();
            string cadenaConexion = "Data Source = HOME-PC\\SQLChristian; initial catalog = BaseWebPrueba; integrated security = true";
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            String query = "select * from Turnos";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            conexion.Close();
            return dt;
        }

        public void GuardarTurno(Turno turno)
        {
            string cadenaConexion = "Data Source = HOME-PC\\SQLChristian; initial catalog = BaseWebPrueba; integrated security = true";
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            String query = "insert into Turnos values ('" + turno.Persona1 + "','" + turno.FechaRegistro1.ToShortDateString() + "','" + turno.FechaTurno1.ToShortDateString() + "','" + turno.MotivoTurno1 + "' , '" + turno.TareasTurno1 + "')";
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.ExecuteNonQuery();

            conexion.Close();
        }

        public static DataSet DropDownPersonas()
        {
            DataSet ds = new DataSet();
            string cadena = "Data Source = HOME-PC\\SQLChristian; initial catalog = BaseWebPrueba; integrated security = true";
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            string query = "select * from Personas";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(ds);
            conexion.Close();
            return ds;
        }
    }
}
