using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using System.Data;

namespace Presentacion
{
    public partial class WebPersonas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarPersona();
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarPersona();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void GuardarPersona()
        {
            Personas persona = new Personas();

            persona.Nombre1 = txtNombre.Text;
            persona.Apellido1 = txtApellido.Text;
            persona.Direccion1 = txtDireccion.Text;
            persona.Telefono1 = int.Parse(txtTelefono.Text);

            PersonaNego personaNego = new PersonaNego();
            personaNego.GuardarPersona(persona);
        }

        private void MostrarPersona()
        {
            PersonaNego personaNego = new PersonaNego();
            gdvGrilla.DataSource = personaNego.MostrarGrilla();
            gdvGrilla.DataBind();
        }
    }
}