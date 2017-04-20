using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turno
    {
        private string Persona;

        public string Persona1
        {
            get { return Persona; }
            set { Persona = value; }
        }
        private DateTime FechaRegistro;

        public DateTime FechaRegistro1
        {
            get { return FechaRegistro; }
            set { FechaRegistro = value; }
        }
        private DateTime FechaTurno;

        public DateTime FechaTurno1
        {
            get { return FechaTurno; }
            set { FechaTurno = value; }
        }
        private string MotivoTurno;

        public string MotivoTurno1
        {
            get { return MotivoTurno; }
            set { MotivoTurno = value; }
        }
        private string TareasTurno;

        public string TareasTurno1
        {
            get { return TareasTurno; }
            set { TareasTurno = value; }
        }
    }
}
