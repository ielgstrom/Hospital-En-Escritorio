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
    partial class FormListPatientsOfDoctor : Form
    {
        List<Medico> listaDeMedicos;
        public FormListPatientsOfDoctor(List<Medico> _listaMedicos)
        {
            listaDeMedicos = _listaMedicos;
            InitializeComponent();
            for (int u = 0; u < listaDeMedicos.Count; u++)
            {

                comboBoxDoctors.Items.Add($"{listaDeMedicos[u].getNombre()} de {listaDeMedicos[u].getEspecialidad()}");
            }
        }


        private void comboBoxDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ListaADevolevr = "";
            for (int k = 0; k < listaDeMedicos[comboBoxDoctors.SelectedIndex].pacientesAsignados().Count; k++)
            {
                ListaADevolevr += $"{listaDeMedicos[comboBoxDoctors.SelectedIndex].pacientesAsignados()[k].getNombre()} con {listaDeMedicos[comboBoxDoctors.SelectedIndex].pacientesAsignados()[k].getEdad()} años\n";

            }
            if (ListaADevolevr != "") richtxtPacientesMed.Text = ListaADevolevr;
            else richtxtPacientesMed.Text = "No existen Pacientes para este medico";
        }

        private void btnCancelarSeePatients_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
