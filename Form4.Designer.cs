namespace Sistema_Vac
{
    partial class Form4
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
            System.Windows.Forms.Label vacuna_idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label fabricanteLabel;
            System.Windows.Forms.Label dosis_requeridasLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.registro_de_vacunacionDataSet = new Sistema_Vac.Registro_de_vacunacionDataSet();
            this.vacunasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacunasTableAdapter = new Sistema_Vac.Registro_de_vacunacionDataSetTableAdapters.VacunasTableAdapter();
            this.tableAdapterManager = new Sistema_Vac.Registro_de_vacunacionDataSetTableAdapters.TableAdapterManager();
            this.vacunasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vacunasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vacunasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacuna_idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.fabricanteTextBox = new System.Windows.Forms.TextBox();
            this.dosis_requeridasTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.retrocederToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            vacuna_idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            fabricanteLabel = new System.Windows.Forms.Label();
            dosis_requeridasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.registro_de_vacunacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunasBindingNavigator)).BeginInit();
            this.vacunasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vacunasDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vacuna_idLabel
            // 
            vacuna_idLabel.AutoSize = true;
            vacuna_idLabel.Location = new System.Drawing.Point(239, 107);
            vacuna_idLabel.Name = "vacuna_idLabel";
            vacuna_idLabel.Size = new System.Drawing.Size(57, 13);
            vacuna_idLabel.TabIndex = 2;
            vacuna_idLabel.Text = "vacuna id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(239, 133);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "nombre:";
            // 
            // fabricanteLabel
            // 
            fabricanteLabel.AutoSize = true;
            fabricanteLabel.Location = new System.Drawing.Point(437, 111);
            fabricanteLabel.Name = "fabricanteLabel";
            fabricanteLabel.Size = new System.Drawing.Size(57, 13);
            fabricanteLabel.TabIndex = 6;
            fabricanteLabel.Text = "fabricante:";
            // 
            // dosis_requeridasLabel
            // 
            dosis_requeridasLabel.AutoSize = true;
            dosis_requeridasLabel.Location = new System.Drawing.Point(437, 137);
            dosis_requeridasLabel.Name = "dosis_requeridasLabel";
            dosis_requeridasLabel.Size = new System.Drawing.Size(86, 13);
            dosis_requeridasLabel.TabIndex = 8;
            dosis_requeridasLabel.Text = "dosis requeridas:";
            // 
            // registro_de_vacunacionDataSet
            // 
            this.registro_de_vacunacionDataSet.DataSetName = "Registro_de_vacunacionDataSet";
            this.registro_de_vacunacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacunasBindingSource
            // 
            this.vacunasBindingSource.DataMember = "Vacunas";
            this.vacunasBindingSource.DataSource = this.registro_de_vacunacionDataSet;
            // 
            // vacunasTableAdapter
            // 
            this.vacunasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PacienteTableAdapter = null;
            this.tableAdapterManager.RegistroVacunacionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sistema_Vac.Registro_de_vacunacionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacunadorTableAdapter = null;
            this.tableAdapterManager.VacunasTableAdapter = this.vacunasTableAdapter;
            // 
            // vacunasBindingNavigator
            // 
            this.vacunasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vacunasBindingNavigator.BindingSource = this.vacunasBindingSource;
            this.vacunasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vacunasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vacunasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vacunasBindingNavigatorSaveItem});
            this.vacunasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vacunasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vacunasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vacunasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vacunasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vacunasBindingNavigator.Name = "vacunasBindingNavigator";
            this.vacunasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vacunasBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.vacunasBindingNavigator.TabIndex = 0;
            this.vacunasBindingNavigator.Text = "bindingNavigator1";
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
            // vacunasBindingNavigatorSaveItem
            // 
            this.vacunasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vacunasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vacunasBindingNavigatorSaveItem.Image")));
            this.vacunasBindingNavigatorSaveItem.Name = "vacunasBindingNavigatorSaveItem";
            this.vacunasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vacunasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.vacunasBindingNavigatorSaveItem.Click += new System.EventHandler(this.vacunasBindingNavigatorSaveItem_Click);
            // 
            // vacunasDataGridView
            // 
            this.vacunasDataGridView.AutoGenerateColumns = false;
            this.vacunasDataGridView.BackgroundColor = System.Drawing.Color.DarkGreen;
            this.vacunasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vacunasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.vacunasDataGridView.DataSource = this.vacunasBindingSource;
            this.vacunasDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vacunasDataGridView.Location = new System.Drawing.Point(242, 174);
            this.vacunasDataGridView.Name = "vacunasDataGridView";
            this.vacunasDataGridView.Size = new System.Drawing.Size(443, 220);
            this.vacunasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "vacuna_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "vacuna_id";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fabricante";
            this.dataGridViewTextBoxColumn3.HeaderText = "fabricante";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dosis_requeridas";
            this.dataGridViewTextBoxColumn4.HeaderText = "dosis_requeridas";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // vacuna_idTextBox
            // 
            this.vacuna_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacunasBindingSource, "vacuna_id", true));
            this.vacuna_idTextBox.Location = new System.Drawing.Point(331, 104);
            this.vacuna_idTextBox.Name = "vacuna_idTextBox";
            this.vacuna_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.vacuna_idTextBox.TabIndex = 3;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacunasBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(331, 130);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 5;
            // 
            // fabricanteTextBox
            // 
            this.fabricanteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacunasBindingSource, "fabricante", true));
            this.fabricanteTextBox.Location = new System.Drawing.Point(529, 108);
            this.fabricanteTextBox.Name = "fabricanteTextBox";
            this.fabricanteTextBox.Size = new System.Drawing.Size(100, 20);
            this.fabricanteTextBox.TabIndex = 7;
            // 
            // dosis_requeridasTextBox
            // 
            this.dosis_requeridasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacunasBindingSource, "dosis_requeridas", true));
            this.dosis_requeridasTextBox.Location = new System.Drawing.Point(529, 134);
            this.dosis_requeridasTextBox.Name = "dosis_requeridasTextBox";
            this.dosis_requeridasTextBox.Size = new System.Drawing.Size(100, 20);
            this.dosis_requeridasTextBox.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Green;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retrocederToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 25);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // retrocederToolStripMenuItem
            // 
            this.retrocederToolStripMenuItem.BackColor = System.Drawing.Color.LimeGreen;
            this.retrocederToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrocederToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.retrocederToolStripMenuItem.Name = "retrocederToolStripMenuItem";
            this.retrocederToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.retrocederToolStripMenuItem.Text = "Retroceder";
            this.retrocederToolStripMenuItem.Click += new System.EventHandler(this.retrocederToolStripMenuItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_Vac.Properties.Resources.OIF1;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(vacuna_idLabel);
            this.Controls.Add(this.vacuna_idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(fabricanteLabel);
            this.Controls.Add(this.fabricanteTextBox);
            this.Controls.Add(dosis_requeridasLabel);
            this.Controls.Add(this.dosis_requeridasTextBox);
            this.Controls.Add(this.vacunasDataGridView);
            this.Controls.Add(this.vacunasBindingNavigator);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registro_de_vacunacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunasBindingNavigator)).EndInit();
            this.vacunasBindingNavigator.ResumeLayout(false);
            this.vacunasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vacunasDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Registro_de_vacunacionDataSet registro_de_vacunacionDataSet;
        private System.Windows.Forms.BindingSource vacunasBindingSource;
        private Registro_de_vacunacionDataSetTableAdapters.VacunasTableAdapter vacunasTableAdapter;
        private Registro_de_vacunacionDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vacunasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vacunasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView vacunasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox vacuna_idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox fabricanteTextBox;
        private System.Windows.Forms.TextBox dosis_requeridasTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem retrocederToolStripMenuItem;
    }
}