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
        }


        private void btnMasPaciente_Click(object sender, EventArgs e)
        {
            var m = new FormNewPersona(listaMedicos, listaPacientes);
            m.ShowDialog();
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var ty = new FormListPatientsOfDoctor(listaMedicos);
            ty.ShowDialog();
        }
    }
}
