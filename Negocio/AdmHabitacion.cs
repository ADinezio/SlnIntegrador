using Entidades.Models.Derivados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AdmHabitacion
    {
        List<Habitacion> habitaciones;

        public List<Habitacion> Listar()
        {
            habitaciones = new List<Habitacion>();
            habitaciones.Add(new Habitacion(1,223,true));
            habitaciones.Add(new Habitacion(2, 504, false));
            habitaciones.Add(new Habitacion(3, 12, false));
            habitaciones.Add(new Habitacion(4, 200, true));
            habitaciones.Add(new Habitacion(5, 325, false));

            return habitaciones;
        }

        public List<Habitacion> Listar(bool estado)
        {
            List<Habitacion> habEstado = new List<Habitacion>();
            foreach(var habitacion in habitaciones)
            {
                if (habitacion.Estado == estado)
                {
                    habEstado.Add(habitacion);
                }  
            }
            return habEstado;
        }

        public int Insertar(Habitacion habitacion)
        {

            return 0;
        }

        public bool Eliminar(int id)        //El tipo de retorno en realidad es int
        {
            bool flag=false;
            foreach(var item in habitaciones)
            {

                if(item.Id == id)
                {
                    flag=habitaciones.Remove(item);
                }
            }
            return flag;
        }
        public Habitacion TraerUno(int numero)
        {
            Habitacion habitacion=null;
            foreach(var item in habitaciones)
            {
                if (item.Numero == numero)
                {
                    habitacion = item;
                }
            }
            return habitacion;
        }
    }
}
