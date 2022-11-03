using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Ayudantes
{
    public static class UtilidadesFechas
    {

        public static int CalcularEdad(int fechaNacimiento)
        {
            return DateTime.Today.Year - fechaNacimiento;
        }
    }
}
