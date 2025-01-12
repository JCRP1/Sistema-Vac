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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pacienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.pacienteBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.registro_de_vacunacionDataSet);
                MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                // Carga los datos en la tabla Paciente
                this.pacienteTableAdapter.Fill(this.registro_de_vacunacionDataSet.Paciente);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form2>();
        }

        private void AbrirFormulario<T>() where T : Form, new()
        {
            using (var formulario = new T())
            {
                formulario.ShowDialog();
            }
            this.Hide();
        }

    }
}
