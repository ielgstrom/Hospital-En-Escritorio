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
    partial class FormInscripcion : Form
    {
        List<Medico> listaMedicos;
        List<Paciente> listaPacientes;
        
        public FormInscripcion(List<Medico> listaMedicoss, List<Paciente>  listaPacientess)
        {
            listaMedicos = listaMedicoss;
            listaPacientes = listaPacientess;
            InitializeComponent();
            
        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var m = new Form2(listaMedicos, listaPacientes);
            m.ShowDialog();
            if (listaMedicos.Count != 0)
            { 
                btnModMedico.Enabled = true;
                btnMasPaciente.Enabled = true;
                butnlistmedicos.Enabled = true;
                button4.Enabled = true;
            }
            else {
                btnModMedico.Enabled = false;
                btnMasPaciente.Enabled = false;
                butnlistmedicos.Enabled = false;
                button4.Enabled = false;
            }
        }


        private void btnMasPaciente_Click(object sender, EventArgs e)
        {
            var m = new FormNewPersona(listaMedicos, listaPacientes);
            m.ShowDialog();
            if (listaPacientes.Count != 0) 
            {
                btnDeleteUser.Enabled = true;
                btnModifyPatient.Enabled = true;
            }
            else 
            { 
                btnModifyPatient.Enabled = false;
                btnDeleteUser.Enabled = false;
            }
        }

        private void butnlistmedicos_Click(object sender, EventArgs e)
        {
            string ListaADevolevr = "";
            for (int k = 0; k < listaMedicos.Count; k++)
            {
                ListaADevolevr += $"{listaMedicos[k].getNombre()} de {listaMedicos[k].getEspecialidad()} con {listaMedicos[k].getEdad()} años\n";

            }
            if (ListaADevolevr != "") MessageBox.Show(ListaADevolevr);
            else MessageBox.Show("No hay medicos");
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            var u = new FormDeleteUser(listaPacientes, listaMedicos);
            u.ShowDialog();
            if (listaPacientes.Count != 0)
            {
                btnDeleteUser.Enabled = true;
                btnModifyPatient.Enabled = true;
            }
            else
            {
                btnModifyPatient.Enabled = false;
                btnDeleteUser.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var ty = new FormListPatientsOfDoctor(listaMedicos);
            ty.ShowDialog();
        }

        private void btnModifyPatient_Click(object sender, EventArgs e)
        {
            var jeje = new FormModifyPaciente(listaMedicos, listaPacientes);
            jeje.ShowDialog();
        }

        private void btnModMedico_Click(object sender, EventArgs e)
        {
            var queEsEsto = new FormModifyDoctor(listaMedicos);
            queEsEsto.ShowDialog();
        }
    }
}
