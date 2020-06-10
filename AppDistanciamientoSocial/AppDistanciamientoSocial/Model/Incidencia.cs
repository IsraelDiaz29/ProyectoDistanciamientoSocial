using System;
using System.Collections.Generic;
using System.Text;

namespace AppDistanciamientoSocial.Model
{
    public class Incidencia
    {
        public int idIncidencia { get; set; }
        public DateTime strFecha { get; set; }
        public Decimal strDistanciaAproximada { get; set; }
        public int idEmpleadoInvadido { get; set; }
        public int idEmpleadoInvasor { get; set; }
        public String strTiempo { get; set; }
    }
}
