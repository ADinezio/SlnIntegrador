using Entidades.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models.Derivados
{
    public class Director : Medico
    {
        #region constructor
        public Director(string postGrado,string especialidad, string matricula, int id, string nombre, string apellido, string domicilio, string telefono, string email) : base(especialidad, matricula, id, nombre, apellido, domicilio, telefono, email)
        {
            PostGrado = postGrado;
        }
        #endregion

        #region propiedades
        public string PostGrado { get; set; }
        #endregion
    }
}
