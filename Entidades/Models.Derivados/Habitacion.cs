using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models.Derivados
{
    public class Habitacion
    {
        #region constructor
        public Habitacion(int id, int numero, bool estado)
        {
            Id = id;
            Numero = numero;
            Estado = estado;
        }
        #endregion

        #region propiedades
        public int Id { get; set; }
        public int Numero { get; set; }
        public bool Estado { get; set; }
        #endregion
    }
}
