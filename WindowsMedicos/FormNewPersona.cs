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
     partial class FormNewPersona : Form
    {
        private List<Medico> listaMedicos;
        private List<Paciente> listaPacientes;


        public FormNewPersona(List<Medico> _listaMedicos, List<Paciente> _listaPacientes)
        {
            listaMedicos = _listaMedicos;
            listaPacientes = _listaPacientes;
            InitializeComponent();
            for (int u = 0; u < listaMedicos.Count; u++)
            {
                comboBox1.Items.Add($"{listaMedicos[u].getNombre()} de {listaMedicos[u].getEspecialidad()}");
            }

        }

        private void btnCancelarMedico_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAñadirMedico_Click(object sender, EventArgs e)
        {
            string nombre = txtNombrePaciente.Text;
            int edad = Int32.Parse(txtEdadPaciente.Text);
            Paciente nuevoPaciente = new Paciente(edad, DateTime.Now, nombre);
            listaMedicos[comboBox1.SelectedIndex].asignarleElPaciente(nuevoPaciente);
            listaPacientes.Add(nuevoPaciente);
            this.Close();
        }
    }
}
