using Entidades.Ayudantes;
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
        public Paciente(DateTime fechaNacimiento ,string nroHistoriaClinica,int id, string nombre, string apellido, string domicilio, string telefono, string email) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            FechaNacimiento = fechaNacimiento;
            NroHistoriaClinica = nroHistoriaClinica;
            Edad = UtilidadesFechas.CalcularEdad(FechaNacimiento.Year);
        }

        #endregion

        #region propiedades
        public DateTime FechaNacimiento { get; set; }
        public string NroHistoriaClinica { get; set; }

        private int Edad;

        public int edad
        {
            get { return Edad; }
          
        }


        #endregion



       
        

    }
}
