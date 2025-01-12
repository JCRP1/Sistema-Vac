namespace Sistema_Vac
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tarjetaDeVacunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalDeVacunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacunasDisponiblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVacunacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lime;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarjetaDeVacunaToolStripMenuItem,
            this.personalDeVacunasToolStripMenuItem,
            this.vacunasDisponiblesToolStripMenuItem,
            this.reporteDeVacunacionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 27);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tarjetaDeVacunaToolStripMenuItem
            // 
            this.tarjetaDeVacunaToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.tarjetaDeVacunaToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.tarjetaDeVacunaToolStripMenuItem.Image = global::Sistema_Vac.Properties.Resources.th__1_;
            this.tarjetaDeVacunaToolStripMenuItem.Name = "tarjetaDeVacunaToolStripMenuItem";
            this.tarjetaDeVacunaToolStripMenuItem.Size = new System.Drawing.Size(156, 23);
            this.tarjetaDeVacunaToolStripMenuItem.Text = "Tarjeta de vacuna";
            this.tarjetaDeVacunaToolStripMenuItem.Click += new System.EventHandler(this.tarjetaDeVacunaToolStripMenuItem_Click);
            // 
            // personalDeVacunasToolStripMenuItem
            // 
            this.personalDeVacunasToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.personalDeVacunasToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.personalDeVacunasToolStripMenuItem.Image = global::Sistema_Vac.Properties.Resources.OIP;
            this.personalDeVacunasToolStripMenuItem.Name = "personalDeVacunasToolStripMenuItem";
            this.personalDeVacunasToolStripMenuItem.Size = new System.Drawing.Size(173, 23);
            this.personalDeVacunasToolStripMenuItem.Text = "Personal de vacunas";
            this.personalDeVacunasToolStripMenuItem.Click += new System.EventHandler(this.personalDeVacunasToolStripMenuItem_Click);
            // 
            // vacunasDisponiblesToolStripMenuItem
            // 
            this.vacunasDisponiblesToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.vacunasDisponiblesToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.vacunasDisponiblesToolStripMenuItem.Image = global::Sistema_Vac.Properties.Resources.OIP__1_;
            this.vacunasDisponiblesToolStripMenuItem.Name = "vacunasDisponiblesToolStripMenuItem";
            this.vacunasDisponiblesToolStripMenuItem.Size = new System.Drawing.Size(171, 23);
            this.vacunasDisponiblesToolStripMenuItem.Text = "Vacunas disponibles";
            this.vacunasDisponiblesToolStripMenuItem.Click += new System.EventHandler(this.vacunasDisponiblesToolStripMenuItem_Click);
            // 
            // reporteDeVacunacionToolStripMenuItem
            // 
            this.reporteDeVacunacionToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.reporteDeVacunacionToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.reporteDeVacunacionToolStripMenuItem.Image = global::Sistema_Vac.Properties.Resources.th__3_;
            this.reporteDeVacunacionToolStripMenuItem.Name = "reporteDeVacunacionToolStripMenuItem";
            this.reporteDeVacunacionToolStripMenuItem.Size = new System.Drawing.Size(192, 23);
            this.reporteDeVacunacionToolStripMenuItem.Text = "Reporte de Vacunacion";
            this.reporteDeVacunacionToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVacunacionToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Bodoni MT Condensed", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(357, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 93);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vac Tec";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_Vac.Properties.Resources.OIF;
            this.ClientSize = new System.Drawing.Size(949, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tarjetaDeVacunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalDeVacunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacunasDisponiblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVacunacionToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}