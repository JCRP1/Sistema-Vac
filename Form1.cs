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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int intentos = 3;
        private readonly Dictionary<string, int> usuarios = new Dictionary<string, int>
        {
        { "Jean", 1234 }
        };

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text.Trim();
            if (!int.TryParse(textBox2.Text, out int contrasena))
            {
                MessageBox.Show("La contraseña debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
                return;
            }

            if (usuarios.ContainsKey(usuario) && usuarios[usuario] == contrasena)
            {
                Form2 nuevaVentana = new Form2();
                nuevaVentana.Show();
                return;
            }

            intentos--;
            if (intentos > 0)
            {
                MessageBox.Show($"Credenciales incorrectas. Te quedan {intentos} intento(s).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Has agotado tus intentos. La aplicación se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

    }
}

