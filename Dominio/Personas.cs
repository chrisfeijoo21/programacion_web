using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Personas
    {
        private string Nombre;

        public string Nombre1
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        private string Apellido;

        public string Apellido1
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        private string Direccion;

        public string Direccion1
        {
            get { return Direccion; }
            set { Direccion = value; }
        }
        private int Telefono;

        public int Telefono1
        {
            get { return Telefono; }
            set { Telefono = value; }
        }

        private int idPersona;

        public int IdPersona
        {
            get { return idPersona; }
            set { idPersona = value; }
        }

    }
}
