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
    public class TurnoNego
    {
        TurnoRepo turnoRepo = new TurnoRepo();

       public DataTable BuscarPersona()
        {
            return turnoRepo.BuscarPersona();
        }

        public void GuardarTurno(Turno turno)
       {
           turnoRepo.GuardarTurno(turno);
       }

        public static DataSet DropDownPersonas()
        {
            return TurnoRepo.DropDownPersonas();
        }
    }
}
