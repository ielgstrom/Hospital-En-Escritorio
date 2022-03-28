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
     partial class FormModifyDoctor : Form
    {
        List<Medico> listaDeMedicos;
        public FormModifyDoctor(List<Medico> _listaMedicos)
        {
            listaDeMedicos = _listaMedicos;
            InitializeComponent();
        }

        private void FormModifyDoctor_Load(object sender, EventArgs e)
        {
            for (int u = 0; u < listaDeMedicos.Count; u++)
            {

                comboBoxDoctor.Items.Add($"{listaDeMedicos[u].getNombre()} de {listaDeMedicos[u].getEspecialidad()} con {listaDeMedicos[u].getEdad()} años");
            }
        }

        private void btnCancelarModifyPaciente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifyPaciente_Click(object sender, EventArgs e)
        {
            listaDeMedicos[comboBoxDoctor.SelectedIndex].setNombre(txtNombreModMedico.Text);
            listaDeMedicos[comboBoxDoctor.SelectedIndex].setEdad(Int32.Parse(txtEdadModMedico.Text));
            listaDeMedicos[comboBoxDoctor.SelectedIndex].setEspecialidad(txtModEspecMedico.Text);
            this.Close();
        }

        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombreModMedico.Text = listaDeMedicos[comboBoxDoctor.SelectedIndex].getNombre();
            txtEdadModMedico.Text = listaDeMedicos[comboBoxDoctor.SelectedIndex].getEdad().ToString();
            txtModEspecMedico.Text = listaDeMedicos[comboBoxDoctor.SelectedIndex].getEspecialidad();
        }
    }
}
