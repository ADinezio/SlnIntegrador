using Entidades.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models.Derivados
{
    public class Paciente:Persona
    {
        #region constructor
        public Paciente(string nroHistoriaClinica,int id, string nombre, string apellido, string domicilio, string telefono, string email) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            NroHistoriaClinica = nroHistoriaClinica;
        }

        #endregion

        #region propiedades
        public string NroHistoriaClinica { get; set; }

        #endregion


    }
}
