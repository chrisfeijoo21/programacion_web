using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Repositorio;
using System.Data;


namespace Negocio
{
    public class PersonaNego
    {
        PersonaRepo personaRepo = new PersonaRepo();

        public void GuardarPersona(Personas persona)
        {
            personaRepo.GuardarPersona(persona);
        }

        public DataTable MostrarGrilla()
        {
            return personaRepo.MostrarGrilla();
        }
    }
}
