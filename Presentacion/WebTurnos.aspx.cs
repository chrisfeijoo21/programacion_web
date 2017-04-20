using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;
using System.Data;
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class WebTurnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarCombo();
        }

        protected void btnBuscarPersona_Click(object sender, EventArgs e)
        {
            BuscarPersona();
        }

        public void MostrarCombo()
        {
            string cadenaConexion = "Data Source = HOME-PC\\SQLChristian; initial catalog = BaseWebPrueba; integrated security = true";
            SqlConnection con = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand("Select idpersona, Nombre From Personas", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            ddlPersonas.DataSource = ds;

            ddlPersonas.DataTextField = "Nombre";
            ddlPersonas.DataValueField = "idPersona";
            ddlPersonas.DataBind();
        }

        public void BuscarPersona()
        {
            TurnoNego turnoNego = new TurnoNego();
            gdvGrillaCambio.DataSource = turnoNego.BuscarPersona();
            gdvGrillaCambio.DataBind();

        }
    }
}