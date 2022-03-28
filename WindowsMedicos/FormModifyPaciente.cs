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
     partial class FormModifyPaciente : Form
    {
        List<Medico> listaDeMedicos;
        List<Paciente> listaDePacientes;
        int index;
        public FormModifyPaciente(List<Medico> listaMedicos, List<Paciente> listaPacientes)
        {
            listaDeMedicos = listaMedicos;
            listaDePacientes = listaPacientes;
            InitializeComponent();
        }

        private void FormModifyPaciente_Load(object sender, EventArgs e)
        {
            for (int u = 0; u < listaDePacientes.Count; u++)
            {
                comboBox1.Items.Add($"{listaDePacientes[u].getNombre()} con {listaDePacientes[u].getEdad()} años");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             txtNombreModPaciente.Text = listaDePacientes[comboBox1.SelectedIndex].getNombre();
             txtEdadModPaciente.Text = (listaDePacientes[comboBox1.SelectedIndex].getEdad()).ToString();
            comboBoxModPaciente.Items.Clear();
            for (int u = 0; u < listaDeMedicos.Count; u++)
            {
                comboBoxModPaciente.Items.Add($"{listaDeMedicos[u].getNombre()} de {listaDeMedicos[u].getEspecialidad()}");
            }
            for (int k = 0; k < listaDeMedicos.Count; k++)
            {
                for (int l=0; l < listaDeMedicos[k].pacientesAsignados().Count; l++)
                {
                    if (listaDeMedicos[k].pacientesAsignados()[l] == listaDePacientes[comboBox1.SelectedIndex])
                    {
                      index = k;
                      break;
                    }
                }
            }
            comboBoxModPaciente.SelectedIndex = comboBoxModPaciente.FindString($"{listaDeMedicos[index].getNombre()} de {listaDeMedicos[index].getEspecialidad()}");
        }

        private void btnCancelarModifyPaciente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifyPaciente_Click(object sender, EventArgs e)
        {
            listaDePacientes[comboBox1.SelectedIndex].setNombre(txtNombreModPaciente.Text);
            listaDePacientes[comboBox1.SelectedIndex].setEdad(Int32.Parse(txtEdadModPaciente.Text));
            listaDeMedicos[index].eliminarElPaciente(listaDePacientes[comboBox1.SelectedIndex]);
            listaDeMedicos[comboBoxModPaciente.SelectedIndex].asignarleElPaciente(listaDePacientes[comboBox1.SelectedIndex]);
            this.Close();
        }
    }
}
