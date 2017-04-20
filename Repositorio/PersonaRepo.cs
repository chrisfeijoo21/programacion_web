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
    public class PersonaRepo
    {
        public void GuardarPersona(Personas persona)
        {
            string cadenaConexion = "Data Source = HOME-PC\\SQLChristian; initial catalog = BaseWebPrueba; integrated security = true";
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            String query = "insert into Personas values ('" + persona.Nombre1 + "','" + persona.Apellido1 + "','" + persona.Direccion1 + "'," + persona.Telefono1 + ")";
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.ExecuteNonQuery();

            conexion.Close();
            
        }

        public DataTable MostrarGrilla()
        {
            DataTable dt = new DataTable();
            string cadenaConexion = "Data Source = HOME-PC\\SQLChristian; initial catalog = BaseWebPrueba; integrated security = true";
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            String query = "select * from Personas";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            conexion.Close();
            return dt;
        }
    }
}
