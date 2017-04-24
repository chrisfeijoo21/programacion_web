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
            if (IsPostBack == false)
            {
                llenarDropDownList();
            }
        }

        protected void btnBuscarPersona_Click(object sender, EventArgs e)
        {
            BuscarPersona();
        }

        public void llenarDropDownList()
        {
            ddlPersonas.DataSource = TurnoNego.DropDownPersonas();
            ddlPersonas.DataValueField = "idPersona";
            ddlPersonas.DataTextField = "Nombre";
            ddlPersonas.DataBind();
            ddlPersonas.Items.Insert(0, new ListItem("Elija una opcion..", "0"));
        }

        public void BuscarPersona()
        {
            TurnoNego turnoNego = new TurnoNego();
            gdvGrillaCambio.DataSource = turnoNego.BuscarPersona();
            gdvGrillaCambio.DataBind();

        }

        protected void btnGuardarTurno_Click(object sender, EventArgs e)
        {
            GuardarTurno();
        }

        public void GuardarTurno()
        {
            Turno turno = new Turno();

            turno.Persona1 = Convert.ToString(ddlPersonas.SelectedValue.ToString());
            turno.FechaTurno1 = Convert.ToDateTime(dtp_FechaTurno.Value.ToString());
            turno.FechaRegistro1 = Convert.ToDateTime(dtp_FechaRegistro.Value.ToString());
            turno.MotivoTurno1 = txtMotivoTurno.Text;
            turno.TareasTurno1 = txtTareas.Text;

            TurnoNego turnoNego = new TurnoNego();
            turnoNego.GuardarTurno(turno);
        }
    }
}