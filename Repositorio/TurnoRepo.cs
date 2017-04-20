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
        public DataTable ModificarDatos()
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
    }
}
