using System;

namespace Sistema_Vac
{
    partial class Form6
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
            System.Windows.Forms.Label registro_idLabel;
            System.Windows.Forms.Label paciente_idLabel;
            System.Windows.Forms.Label vacuna_idLabel;
            System.Windows.Forms.Label vacunador_idLabel;
            System.Windows.Forms.Label fecha_vacunacionLabel;
            System.Windows.Forms.Label dosis_aplicadaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.registro_de_vacunacionDataSet = new Sistema_Vac.Registro_de_vacunacionDataSet();
            this.registroVacunacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registroVacunacionTableAdapter = new Sistema_Vac.Registro_de_vacunacionDataSetTableAdapters.RegistroVacunacionTableAdapter();
            this.tableAdapterManager = new Sistema_Vac.Registro_de_vacunacionDataSetTableAdapters.TableAdapterManager();
            this.registroVacunacionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.registroVacunacionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.registroVacunacionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registro_idTextBox = new System.Windows.Forms.TextBox();
            this.paciente_idTextBox = new System.Windows.Forms.TextBox();
            this.vacuna_idTextBox = new System.Windows.Forms.TextBox();
            this.vacunador_idTextBox = new System.Windows.Forms.TextBox();
            this.fecha_vacunacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dosis_aplicadaTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.retrocederToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            registro_idLabel = new System.Windows.Forms.Label();
            paciente_idLabel = new System.Windows.Forms.Label();
            vacuna_idLabel = new System.Windows.Forms.Label();
            vacunador_idLabel = new System.Windows.Forms.Label();
            fecha_vacunacionLabel = new System.Windows.Forms.Label();
            dosis_aplicadaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registro_de_vacunacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroVacunacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroVacunacionBindingNavigator)).BeginInit();
            this.registroVacunacionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registroVacunacionDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registro_idLabel
            // 
            registro_idLabel.AutoSize = true;
            registro_idLabel.Location = new System.Drawing.Point(107, 169);
            registro_idLabel.Name = "registro_idLabel";
            registro_idLabel.Size = new System.Drawing.Size(55, 13);
            registro_idLabel.TabIndex = 2;
            registro_idLabel.Text = "registro id:";
            // 
            // paciente_idLabel
            // 
            paciente_idLabel.AutoSize = true;
            paciente_idLabel.Location = new System.Drawing.Point(107, 195);
            paciente_idLabel.Name = "paciente_idLabel";
            paciente_idLabel.Size = new System.Drawing.Size(62, 13);
            paciente_idLabel.TabIndex = 4;
            paciente_idLabel.Text = "paciente id:";
            // 
            // vacuna_idLabel
            // 
            vacuna_idLabel.AutoSize = true;
            vacuna_idLabel.Location = new System.Drawing.Point(107, 221);
            vacuna_idLabel.Name = "vacuna_idLabel";
            vacuna_idLabel.Size = new System.Drawing.Size(57, 13);
            vacuna_idLabel.TabIndex = 6;
            vacuna_idLabel.Text = "vacuna id:";
            // 
            // vacunador_idLabel
            // 
            vacunador_idLabel.AutoSize = true;
            vacunador_idLabel.Location = new System.Drawing.Point(431, 169);
            vacunador_idLabel.Name = "vacunador_idLabel";
            vacunador_idLabel.Size = new System.Drawing.Size(72, 13);
            vacunador_idLabel.TabIndex = 8;
            vacunador_idLabel.Text = "vacunador id:";
            // 
            // fecha_vacunacionLabel
            // 
            fecha_vacunacionLabel.AutoSize = true;
            fecha_vacunacionLabel.Location = new System.Drawing.Point(431, 196);
            fecha_vacunacionLabel.Name = "fecha_vacunacionLabel";
            fecha_vacunacionLabel.Size = new System.Drawing.Size(96, 13);
            fecha_vacunacionLabel.TabIndex = 10;
            fecha_vacunacionLabel.Text = "fecha vacunacion:";
            // 
            // dosis_aplicadaLabel
            // 
            dosis_aplicadaLabel.AutoSize = true;
            dosis_aplicadaLabel.Location = new System.Drawing.Point(431, 221);
            dosis_aplicadaLabel.Name = "dosis_aplicadaLabel";
            dosis_aplicadaLabel.Size = new System.Drawing.Size(77, 13);
            dosis_aplicadaLabel.TabIndex = 12;
            dosis_aplicadaLabel.Text = "dosis aplicada:";
            // 
            // registro_de_vacunacionDataSet
            // 
            this.registro_de_vacunacionDataSet.DataSetName = "Registro_de_vacunacionDataSet";
            this.registro_de_vacunacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registroVacunacionBindingSource
            // 
            this.registroVacunacionBindingSource.DataMember = "RegistroVacunacion";
            this.registroVacunacionBindingSource.DataSource = this.registro_de_vacunacionDataSet;
            // 
            // registroVacunacionTableAdapter
            // 
            this.registroVacunacionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PacienteTableAdapter = null;
            this.tableAdapterManager.RegistroVacunacionTableAdapter = this.registroVacunacionTableAdapter;
            this.tableAdapterManager.UpdateOrder = Sistema_Vac.Registro_de_vacunacionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacunadorTableAdapter = null;
            this.tableAdapterManager.VacunasTableAdapter = null;
            // 
            // registroVacunacionBindingNavigator
            // 
            this.registroVacunacionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.registroVacunacionBindingNavigator.BindingSource = this.registroVacunacionBindingSource;
            this.registroVacunacionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.registroVacunacionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.registroVacunacionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.registroVacunacionBindingNavigatorSaveItem});
            this.registroVacunacionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.registroVacunacionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.registroVacunacionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.registroVacunacionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.registroVacunacionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.registroVacunacionBindingNavigator.Name = "registroVacunacionBindingNavigator";
            this.registroVacunacionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.registroVacunacionBindingNavigator.Size = new System.Drawing.Size(1120, 25);
            this.registroVacunacionBindingNavigator.TabIndex = 0;
            this.registroVacunacionBindingNavigator.Text = "bindingNavigator1";
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
            // registroVacunacionBindingNavigatorSaveItem
            // 
            this.registroVacunacionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.registroVacunacionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("registroVacunacionBindingNavigatorSaveItem.Image")));
            this.registroVacunacionBindingNavigatorSaveItem.Name = "registroVacunacionBindingNavigatorSaveItem";
            this.registroVacunacionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.registroVacunacionBindingNavigatorSaveItem.Text = "Guardar datos";
            this.registroVacunacionBindingNavigatorSaveItem.Click += new System.EventHandler(this.registroVacunacionBindingNavigatorSaveItem_Click);
            // 
            // registroVacunacionDataGridView
            // 
            this.registroVacunacionDataGridView.AutoGenerateColumns = false;
            this.registroVacunacionDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.registroVacunacionDataGridView.BackgroundColor = System.Drawing.Color.Green;
            this.registroVacunacionDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.registroVacunacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registroVacunacionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.registroVacunacionDataGridView.DataSource = this.registroVacunacionBindingSource;
            this.registroVacunacionDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registroVacunacionDataGridView.Location = new System.Drawing.Point(110, 269);
            this.registroVacunacionDataGridView.Name = "registroVacunacionDataGridView";
            this.registroVacunacionDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.registroVacunacionDataGridView.Size = new System.Drawing.Size(642, 220);
            this.registroVacunacionDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "registro_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "registro_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "paciente_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "paciente_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "vacuna_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "vacuna_id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "vacunador_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "vacunador_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fecha_vacunacion";
            this.dataGridViewTextBoxColumn5.HeaderText = "fecha_vacunacion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dosis_aplicada";
            this.dataGridViewTextBoxColumn6.HeaderText = "dosis_aplicada";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // registro_idTextBox
            // 
            this.registro_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registroVacunacionBindingSource, "registro_id", true));
            this.registro_idTextBox.Location = new System.Drawing.Point(209, 166);
            this.registro_idTextBox.Name = "registro_idTextBox";
            this.registro_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.registro_idTextBox.TabIndex = 3;
            // 
            // paciente_idTextBox
            // 
            this.paciente_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registroVacunacionBindingSource, "paciente_id", true));
            this.paciente_idTextBox.Location = new System.Drawing.Point(209, 192);
            this.paciente_idTextBox.Name = "paciente_idTextBox";
            this.paciente_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.paciente_idTextBox.TabIndex = 5;
            // 
            // vacuna_idTextBox
            // 
            this.vacuna_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registroVacunacionBindingSource, "vacuna_id", true));
            this.vacuna_idTextBox.Location = new System.Drawing.Point(209, 218);
            this.vacuna_idTextBox.Name = "vacuna_idTextBox";
            this.vacuna_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.vacuna_idTextBox.TabIndex = 7;
            // 
            // vacunador_idTextBox
            // 
            this.vacunador_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registroVacunacionBindingSource, "vacunador_id", true));
            this.vacunador_idTextBox.Location = new System.Drawing.Point(533, 166);
            this.vacunador_idTextBox.Name = "vacunador_idTextBox";
            this.vacunador_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.vacunador_idTextBox.TabIndex = 9;
            // 
            // fecha_vacunacionDateTimePicker
            // 
            this.fecha_vacunacionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.registroVacunacionBindingSource, "fecha_vacunacion", true));
            this.fecha_vacunacionDateTimePicker.Location = new System.Drawing.Point(533, 192);
            this.fecha_vacunacionDateTimePicker.Name = "fecha_vacunacionDateTimePicker";
            this.fecha_vacunacionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_vacunacionDateTimePicker.TabIndex = 11;
            // 
            // dosis_aplicadaTextBox
            // 
            this.dosis_aplicadaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registroVacunacionBindingSource, "dosis_aplicada", true));
            this.dosis_aplicadaTextBox.Location = new System.Drawing.Point(533, 218);
            this.dosis_aplicadaTextBox.Name = "dosis_aplicadaTextBox";
            this.dosis_aplicadaTextBox.Size = new System.Drawing.Size(200, 20);
            this.dosis_aplicadaTextBox.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lime;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retrocederToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 25);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1120, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // retrocederToolStripMenuItem
            // 
            this.retrocederToolStripMenuItem.Name = "retrocederToolStripMenuItem";
            this.retrocederToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.retrocederToolStripMenuItem.Text = "Retroceder";
            this.retrocederToolStripMenuItem.Click += new System.EventHandler(this.retrocederToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(783, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 25;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(775, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Bucar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(776, 294);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 20);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(762, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 67);
            this.button1.TabIndex = 22;
            this.button1.Text = "Notificar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Green;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(370, 43);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 102);
            this.textBox2.TabIndex = 26;
            this.textBox2.Text = "Reporte de Vacunacion";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_Vac.Properties.Resources.OIF;
            this.ClientSize = new System.Drawing.Size(1120, 451);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(registro_idLabel);
            this.Controls.Add(this.registro_idTextBox);
            this.Controls.Add(paciente_idLabel);
            this.Controls.Add(this.paciente_idTextBox);
            this.Controls.Add(vacuna_idLabel);
            this.Controls.Add(this.vacuna_idTextBox);
            this.Controls.Add(vacunador_idLabel);
            this.Controls.Add(this.vacunador_idTextBox);
            this.Controls.Add(fecha_vacunacionLabel);
            this.Controls.Add(this.fecha_vacunacionDateTimePicker);
            this.Controls.Add(dosis_aplicadaLabel);
            this.Controls.Add(this.dosis_aplicadaTextBox);
            this.Controls.Add(this.registroVacunacionDataGridView);
            this.Controls.Add(this.registroVacunacionBindingNavigator);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registro_de_vacunacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroVacunacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroVacunacionBindingNavigator)).EndInit();
            this.registroVacunacionBindingNavigator.ResumeLayout(false);
            this.registroVacunacionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registroVacunacionDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Registro_de_vacunacionDataSet registro_de_vacunacionDataSet;
        private System.Windows.Forms.BindingSource registroVacunacionBindingSource;
        private Registro_de_vacunacionDataSetTableAdapters.RegistroVacunacionTableAdapter registroVacunacionTableAdapter;
        private Registro_de_vacunacionDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator registroVacunacionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton registroVacunacionBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView registroVacunacionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox registro_idTextBox;
        private System.Windows.Forms.TextBox paciente_idTextBox;
        private System.Windows.Forms.TextBox vacuna_idTextBox;
        private System.Windows.Forms.TextBox vacunador_idTextBox;
        private System.Windows.Forms.DateTimePicker fecha_vacunacionDateTimePicker;
        private System.Windows.Forms.TextBox dosis_aplicadaTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem retrocederToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
    }
}