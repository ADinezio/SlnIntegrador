using Entidades.Models.Derivados;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        List<Medico> listMedico;
        List<Paciente> listPaciente;
        List<Medico> clinico;
        List<Habitacion> listHabitaciones;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearListas_Click(object sender, EventArgs e)
        { 
            listMedico = AdmMedico.Listar();
            listPaciente = AdmPaciente.Listar();
            listHabitaciones = AdmHabitacion.Listar();

            clinico= AdmMedico.Listar("Clinico");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            gridListasMedicos.DataSource = listMedico;
            gridListaPacientes.DataSource = listPaciente;

            lstMedicosClinicos.Items.Add($"Cantidad de medicos clinicos : {clinico.Count()}");
            foreach (var item in clinico)
            {
                lstMedicosClinicos.Items.Add(item.Nombre);
            }

            lstHabitaciones.Items.Add($"Listado de habitaciones");
            foreach (var item in listHabitaciones)
            {
                lstHabitaciones.Items.Add($"Nro : {item.Numero} --> {item.Estado}");
            }
        }

       
    }
}
