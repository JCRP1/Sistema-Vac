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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void registroVacunacionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.registroVacunacionBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.registro_de_vacunacionDataSet);
                MessageBox.Show("Los datos de registro de vacunación se guardaron correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar los datos en la tabla 'RegistroVacunacion'
                this.registroVacunacionTableAdapter.Fill(this.registro_de_vacunacionDataSet.RegistroVacunacion);
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

        private void button1_Click(object sender, EventArgs e)
        {
            EnviarNotificacionReaccionVacuna();
        }

        private void EnviarNotificacionReaccionVacuna()
        {
            // Simula el envío de una notificación en caso de reacción a la vacuna
            MessageBox.Show("Se ha reportado una reacción a la vacuna. Se enviará una notificación al personal de salud.",
                "Notificación de Reacción a Vacuna", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textoBusqueda = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                BuscarInformacion(textoBusqueda);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un texto para realizar la búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BuscarInformacion(string textoBusqueda)
        {
            try
            {
                // Limpiar la selección actual
                registroVacunacionDataGridView.ClearSelection();

                bool resultadoEncontrado = false;

                // Recorrer todas las filas del DataGridView
                foreach (DataGridViewRow fila in registroVacunacionDataGridView.Rows)
                {
                    // Recorrer todas las celdas de la fila actual
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        if (celda.Value != null && celda.Value.ToString().IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            // Seleccionar la fila que contiene la coincidencia
                            fila.Selected = true;
                            registroVacunacionDataGridView.CurrentCell = celda;
                            registroVacunacionDataGridView.FirstDisplayedScrollingRowIndex = fila.Index;
                            resultadoEncontrado = true;
                            return;
                        }
                    }
                }

                if (!resultadoEncontrado)
                {
                    MessageBox.Show("No se encontraron resultados para la búsqueda.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
