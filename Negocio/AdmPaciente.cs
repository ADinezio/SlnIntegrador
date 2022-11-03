using Entidades.Models.Derivados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmPaciente
    {
        static List<Paciente> pacientes;

        public static List<Paciente> Listar()
        {
            pacientes = new List<Paciente>();
            pacientes.Add(new Paciente(new DateTime(1994,7,8), "66258221", 120, "Juan", "Carlos", "Sarmiento 1325", "4786599", "juancito@gmail.com"));
            pacientes.Add(new Paciente(new DateTime(1995,8,25), "33218221", 121, "Tomas", "Fanta", "Roca 1125", "4986144", "fantajuan@gmail.com"));
            pacientes.Add(new Paciente(new DateTime(2000,1,24), "11123548", 122, "Francisco", "Niebla", "Saavedra 100", "4735595", "francisconiebla@gmail.com"));
            pacientes.Add(new Paciente(new DateTime(1980,5,15), "33345545", 123, "Guido", "Gonzales", "Alem 1200", "2236984532", "guidogon@gmail.com"));
            pacientes.Add(new Paciente(new DateTime(2012,12,1), "66258221", 124, "Patricia", "Perez", "Francia 2143", "2234879362", "perezpatricia@gmail.com"));
            return pacientes;
        }

        public static int Insertar(Paciente paciente)
        {
            return 0;
        }

        public static bool Eliminar(int id)    // En realidad la funcion retorna un int
        {
            bool flag = false;
            foreach (var item in pacientes)
            {
                if(item.Id == id)
                {
                    pacientes.Remove(item);
                }
            }
            return flag;
        }
        public static Paciente TraerUno(string nroHistoriaClinica)
        {
            Paciente pacienteBuscado = null;

            foreach (var item in pacientes)
            {
                if(item.NroHistoriaClinica == nroHistoriaClinica)
                {
                    pacienteBuscado = item;
                }
            }
            return pacienteBuscado;
        }
    }
}
