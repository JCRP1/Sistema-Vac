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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void vacunadorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.vacunadorBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.registro_de_vacunacionDataSet);
                MessageBox.Show("Los datos del vacunador se guardaron correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar los datos en la tabla 'Vacunador'
                this.vacunadorTableAdapter.Fill(this.registro_de_vacunacionDataSet.Vacunador);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void retrocederToolStripMenuItem_Click(object sender, EventArgs e)
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
