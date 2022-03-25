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
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var m = new Form2(listaMedicos, listaPacientes);
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ShowDialog($"{listaMedicos[0].getNombre()}");
        }
    }
}
