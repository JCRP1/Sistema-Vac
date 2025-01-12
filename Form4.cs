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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void vacunasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.vacunasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.registro_de_vacunacionDataSet);
                MessageBox.Show("Los datos de las vacunas se guardaron correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar los datos en la tabla 'Vacunas'
                this.vacunasTableAdapter.Fill(this.registro_de_vacunacionDataSet.Vacunas);
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
