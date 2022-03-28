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
     partial class FormDeleteUser : Form
    {
        List<Paciente> listaDePacientes;
        List<Medico> listaDeMedicos;
        public FormDeleteUser(List<Paciente>_listPacientes, List<Medico> _listaMedicos)
        {
            listaDePacientes = _listPacientes;
            listaDeMedicos = _listaMedicos;
            InitializeComponent();
            for (int u = 0; u < listaDePacientes.Count; u++)
            {
               comboBoxPacientes.Items.Add($"{listaDePacientes[u].getNombre()} de {listaDePacientes[u].getEdad()} años");
            }
        }

        private void btnCancelarEliminarPaciente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            for (int o=0; o<listaDeMedicos.Count; o++)
            {
                listaDeMedicos[o].eliminarElPaciente(listaDePacientes[comboBoxPacientes.SelectedIndex]);
            }
            listaDePacientes.Remove(listaDePacientes[comboBoxPacientes.SelectedIndex]);
            this.Close();
        }
    }
}
