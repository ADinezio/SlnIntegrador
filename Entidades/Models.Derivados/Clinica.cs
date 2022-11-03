using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models.Derivados
{
    public class Clinica
    {
        #region contructores
        public Clinica(int id,string nombre,string direccion, string telefono,string email)
        {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
        }
        #endregion


        #region propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        #endregion
    }
}
