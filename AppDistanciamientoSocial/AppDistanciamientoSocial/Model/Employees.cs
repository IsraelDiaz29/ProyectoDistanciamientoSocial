using System;
using System.Collections.Generic;
using System.Text;

namespace AppDistanciamientoSocial.Model
{

    public class Employees
    {
        public Employee[] employees { get; set; }
    }
    public class Employee
    {
        public int idEmployee { get; set; }
        public string strNombre { get; set; }
        public string strAPaterno { get; set; }
        public string strAMaterno { get; set; }
        public int idEmpresa  { get; set; }

    }
}
