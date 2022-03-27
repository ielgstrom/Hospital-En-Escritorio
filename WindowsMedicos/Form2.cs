using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsMedicos
{
    partial class Form2 : Form
    {
        List<Medico> listaMedicos;
        List<Paciente> listaPacientes = new List<Paciente> ();
        public Form2(List<Medico> listaMedicoss,  List<Paciente> listaPacientes)
        {
            listaMedicos = listaMedicoss;
            InitializeComponent();
        }

      

        private void btnAñadirMedico_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreMedico.Text;
            int edad = Int32.Parse(txtEdadMedico.Text);
            string especialidad = txtEspecialidad.Text;
            Console.WriteLine(especialidad);
            listaMedicos.Add(new Medico(edad, especialidad, nombre));
            this.Close();
            Console.Write("Creado Success");
        }

        private void btnCancelarMedico_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
