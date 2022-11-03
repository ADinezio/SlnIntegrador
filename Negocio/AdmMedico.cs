using Entidades.Models.Derivados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class AdmMedico
    {
        List<Medico> medicos;
        public  List<Medico> Listar()
        {
            medicos = new List<Medico>();
            medicos.Add(new Medico("Clinico","11AA332",12,"Carlos","Palazo","La Pamapa 2234","2235662534","carlitosCapo@gmai.com"));
            medicos.Add(new Medico("Pediatra","12BA4545",54,"Arturo","Duro","Las Heras 1123","223455478","arturito@gmail.com"));
            medicos.Add(new Medico("Traumatologo", "22CC456", 99, "Pepe", "Grillo", "Castelli 156", "223433378", "grillopepe@gmail.com"));
            medicos.Add(new Medico("Clinico", "82ZZ1545", 32, "Martina", "Pepa", "Peña 2254", "228856478", "martinadepepa@gmail.com"));
            medicos.Add(new Medico("Cardiologo", "66TA4545", 2, "Magali", "Alta", "Alvarado 458", "225597478", "magalta@gmail.com"));

            return medicos;
        }

        public List<Medico> Listar(string especialidad)
        {
            List<Medico> medicoEspecialidad = new List<Medico>();

            foreach (var item in medicos)
            {
                if(item.Especialidad == especialidad)
                {
                    medicoEspecialidad.Add(item);
                }
            }
            return medicoEspecialidad;
        }

        public int Insertar(Medico medico)
        {
            return 0;
        }

        public bool Eliminar(int id)    // Esta funcion en realidad retorna int
        {
            bool flag = false;

            foreach(var item in medicos)
            {
                if(item.Id == id)
                {
                    flag=medicos.Remove(item);
                }
            }

            return flag;
        }
        public Medico TraerUno(int id)
        {
            Medico medicoId = null;

            foreach (var item in medicos)
            {
                if (item.Id == id)
                {
                    medicoId = item;
                }
            }
            return medicoId;
        }

    }
}
