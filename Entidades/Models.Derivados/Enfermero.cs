using Entidades.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models.Derivados
{
    public class Enfermero:Persona
    {
        #region constructor
        public Enfermero(string cuil,int id, string nombre, string apellido, string domicilio, string telefono, string email) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            Cuil = cuil;
        }
        #endregion

        #region propiedades
        public string Cuil { get; set; }
        #endregion
    }
}
