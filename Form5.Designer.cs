namespace Sistema_Vac
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label vacunador_idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label especialidadLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.registro_de_vacunacionDataSet = new Sistema_Vac.Registro_de_vacunacionDataSet();
            this.vacunadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacunadorTableAdapter = new Sistema_Vac.Registro_de_vacunacionDataSetTableAdapters.VacunadorTableAdapter();
            this.tableAdapterManager = new Sistema_Vac.Registro_de_vacunacionDataSetTableAdapters.TableAdapterManager();
            this.vacunadorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vacunadorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vacunadorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacunador_idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.especialidadTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.retrocederToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            vacunador_idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            especialidadLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registro_de_vacunacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunadorBindingNavigator)).BeginInit();
            this.vacunadorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vacunadorDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vacunador_idLabel
            // 
            vacunador_idLabel.AutoSize = true;
            vacunador_idLabel.Location = new System.Drawing.Point(175, 166);
            vacunador_idLabel.Name = "vacunador_idLabel";
            vacunador_idLabel.Size = new System.Drawing.Size(72, 13);
            vacunador_idLabel.TabIndex = 2;
            vacunador_idLabel.Text = "vacunador id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(175, 192);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(359, 166);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(46, 13);
            apellidoLabel.TabIndex = 6;
            apellidoLabel.Text = "apellido:";
            // 
            // especialidadLabel
            // 
            especialidadLabel.AutoSize = true;
            especialidadLabel.Location = new System.Drawing.Point(359, 192);
            especialidadLabel.Name = "especialidadLabel";
            especialidadLabel.Size = new System.Drawing.Size(69, 13);
            especialidadLabel.TabIndex = 8;
            especialidadLabel.Text = "especialidad:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(360, 218);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(48, 13);
            telefonoLabel.TabIndex = 10;
            telefonoLabel.Text = "telefono:";
            // 
            // registro_de_vacunacionDataSet
            // 
            this.registro_de_vacunacionDataSet.DataSetName = "Registro_de_vacunacionDataSet";
            this.registro_de_vacunacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacunadorBindingSource
            // 
            this.vacunadorBindingSource.DataMember = "Vacunador";
            this.vacunadorBindingSource.DataSource = this.registro_de_vacunacionDataSet;
            // 
            // vacunadorTableAdapter
            // 
            this.vacunadorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PacienteTableAdapter = null;
            this.tableAdapterManager.RegistroVacunacionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sistema_Vac.Registro_de_vacunacionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacunadorTableAdapter = this.vacunadorTableAdapter;
            this.tableAdapterManager.VacunasTableAdapter = null;
            // 
            // vacunadorBindingNavigator
            // 
            this.vacunadorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vacunadorBindingNavigator.BindingSource = this.vacunadorBindingSource;
            this.vacunadorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vacunadorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vacunadorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.vacunadorBindingNavigatorSaveItem});
            this.vacunadorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vacunadorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vacunadorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vacunadorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vacunadorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vacunadorBindingNavigator.Name = "vacunadorBindingNavigator";
            this.vacunadorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vacunadorBindingNavigator.Size = new System.Drawing.Size(941, 25);
            this.vacunadorBindingNavigator.TabIndex = 0;
            this.vacunadorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // vacunadorBindingNavigatorSaveItem
            // 
            this.vacunadorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vacunadorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vacunadorBindingNavigatorSaveItem.Image")));
            this.vacunadorBindingNavigatorSaveItem.Name = "vacunadorBindingNavigatorSaveItem";
            this.vacunadorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vacunadorBindingNavigatorSaveItem.Text = "Guardar datos";
            this.vacunadorBindingNavigatorSaveItem.Click += new System.EventHandler(this.vacunadorBindingNavigatorSaveItem_Click);
            // 
            // vacunadorDataGridView
            // 
            this.vacunadorDataGridView.AutoGenerateColumns = false;
            this.vacunadorDataGridView.BackgroundColor = System.Drawing.Color.Green;
            this.vacunadorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vacunadorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.vacunadorDataGridView.DataSource = this.vacunadorBindingSource;
            this.vacunadorDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vacunadorDataGridView.Location = new System.Drawing.Point(178, 241);
            this.vacunadorDataGridView.Name = "vacunadorDataGridView";
            this.vacunadorDataGridView.Size = new System.Drawing.Size(535, 220);
            this.vacunadorDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "vacunador_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "vacunador_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "apellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "especialidad";
            this.dataGridViewTextBoxColumn4.HeaderText = "especialidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn5.HeaderText = "telefono";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // vacunador_idTextBox
            // 
            this.vacunador_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacunadorBindingSource, "vacunador_id", true));
            this.vacunador_idTextBox.Location = new System.Drawing.Point(253, 163);
            this.vacunador_idTextBox.Name = "vacunador_idTextBox";
            this.vacunador_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.vacunador_idTextBox.TabIndex = 3;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacunadorBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(253, 189);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 5;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacunadorBindingSource, "apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(437, 163);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidoTextBox.TabIndex = 7;
            // 
            // especialidadTextBox
            // 
            this.especialidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacunadorBindingSource, "especialidad", true));
            this.especialidadTextBox.Location = new System.Drawing.Point(437, 189);
            this.especialidadTextBox.Name = "especialidadTextBox";
            this.especialidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.especialidadTextBox.TabIndex = 9;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacunadorBindingSource, "telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(437, 215);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lime;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retrocederToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 25);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(941, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // retrocederToolStripMenuItem
            // 
            this.retrocederToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.retrocederToolStripMenuItem.Name = "retrocederToolStripMenuItem";
            this.retrocederToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.retrocederToolStripMenuItem.Text = "Retroceder";
            this.retrocederToolStripMenuItem.Click += new System.EventHandler(this.retrocederToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Green;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(374, 52);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 64);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Vacuandor";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_Vac.Properties.Resources.OIF1;
            this.ClientSize = new System.Drawing.Size(941, 512);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(vacunador_idLabel);
            this.Controls.Add(this.vacunador_idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(especialidadLabel);
            this.Controls.Add(this.especialidadTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.vacunadorDataGridView);
            this.Controls.Add(this.vacunadorBindingNavigator);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registro_de_vacunacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunadorBindingNavigator)).EndInit();
            this.vacunadorBindingNavigator.ResumeLayout(false);
            this.vacunadorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vacunadorDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Registro_de_vacunacionDataSet registro_de_vacunacionDataSet;
        private System.Windows.Forms.BindingSource vacunadorBindingSource;
        private Registro_de_vacunacionDataSetTableAdapters.VacunadorTableAdapter vacunadorTableAdapter;
        private Registro_de_vacunacionDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vacunadorBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton vacunadorBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView vacunadorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox vacunador_idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox especialidadTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem retrocederToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}