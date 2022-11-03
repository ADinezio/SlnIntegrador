using Entidades.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models.Derivados
{
    public class Medico:Persona
    {
        

        #region contructores
        public Medico(string especialidad,string matricula,int id, string nombre, string apellido, string domicilio, string telefono, string email) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            Especialidad = especialidad;
            Matricula = matricula;
        }

        
        #endregion


        #region propiedades
        public string Especialidad { get; set; }
        public string Matricula { get; set; }
        #endregion
    }
}
