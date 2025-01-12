using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Vac
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            

        }

        private void AbrirFormulario<T>() where T : Form, new()
        {
            using (var formulario = new T())
            {
                formulario.ShowDialog();
            }
            this.Hide();
        }

        private void tarjetaDeVacunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form3>();
        }

        private void personalDeVacunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form5>();
        }

        private void vacunasDisponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form4>();
        }

        private void reporteDeVacunacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form6>();
        }

    }
}
