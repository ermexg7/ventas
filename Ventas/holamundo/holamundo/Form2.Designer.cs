namespace holamundo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label direccionLabel1;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label nombreLabel1;
            System.Windows.Forms.Label telefonoLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listadeClientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.listadeClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.listadeClientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listaDeCiudadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.direccionTextBox1 = new System.Windows.Forms.TextBox();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.nombreTextBox1 = new System.Windows.Forms.TextBox();
            this.telefonoTextBox1 = new System.Windows.Forms.TextBox();
            this.listadeClientesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            label1 = new System.Windows.Forms.Label();
            direccionLabel1 = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            nombreLabel1 = new System.Windows.Forms.Label();
            telefonoLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listadeClientesBindingNavigator)).BeginInit();
            this.listadeClientesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadeClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeCiudadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeClientesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(275, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 13);
            label1.TabIndex = 12;
            label1.Text = "Ciudad:";
            // 
            // direccionLabel1
            // 
            direccionLabel1.AutoSize = true;
            direccionLabel1.BackColor = System.Drawing.Color.Transparent;
            direccionLabel1.Location = new System.Drawing.Point(20, 45);
            direccionLabel1.Name = "direccionLabel1";
            direccionLabel1.Size = new System.Drawing.Size(55, 13);
            direccionLabel1.TabIndex = 14;
            direccionLabel1.Text = "Direccion:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.BackColor = System.Drawing.Color.Transparent;
            idLabel1.Location = new System.Drawing.Point(20, 67);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(19, 13);
            idLabel1.TabIndex = 16;
            idLabel1.Text = "Id:";
            // 
            // nombreLabel1
            // 
            nombreLabel1.AutoSize = true;
            nombreLabel1.BackColor = System.Drawing.Color.Transparent;
            nombreLabel1.Location = new System.Drawing.Point(20, 93);
            nombreLabel1.Name = "nombreLabel1";
            nombreLabel1.Size = new System.Drawing.Size(47, 13);
            nombreLabel1.TabIndex = 18;
            nombreLabel1.Text = "Nombre:";
            // 
            // telefonoLabel1
            // 
            telefonoLabel1.AutoSize = true;
            telefonoLabel1.BackColor = System.Drawing.Color.Transparent;
            telefonoLabel1.Location = new System.Drawing.Point(20, 119);
            telefonoLabel1.Name = "telefonoLabel1";
            telefonoLabel1.Size = new System.Drawing.Size(52, 13);
            telefonoLabel1.TabIndex = 20;
            telefonoLabel1.Text = "Telefono:";
            // 
            // listadeClientesBindingNavigator
            // 
            this.listadeClientesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listadeClientesBindingNavigator.BindingSource = this.listadeClientesBindingSource;
            this.listadeClientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listadeClientesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listadeClientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listadeClientesBindingNavigatorSaveItem});
            this.listadeClientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listadeClientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listadeClientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listadeClientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listadeClientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listadeClientesBindingNavigator.Name = "listadeClientesBindingNavigator";
            this.listadeClientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listadeClientesBindingNavigator.Size = new System.Drawing.Size(648, 25);
            this.listadeClientesBindingNavigator.TabIndex = 0;
            this.listadeClientesBindingNavigator.Text = "bindingNavigator1";
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
            // listadeClientesBindingSource
            // 
            this.listadeClientesBindingSource.DataSource = typeof(Ventas.Modelos.Cliente);
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
            // listadeClientesBindingNavigatorSaveItem
            // 
            this.listadeClientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listadeClientesBindingNavigatorSaveItem.Enabled = false;
            this.listadeClientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listadeClientesBindingNavigatorSaveItem.Image")));
            this.listadeClientesBindingNavigatorSaveItem.Name = "listadeClientesBindingNavigatorSaveItem";
            this.listadeClientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listadeClientesBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listadeClientesBindingSource, "CiudadId", true));
            this.comboBox1.DataSource = this.listaDeCiudadBindingSource;
            this.comboBox1.DisplayMember = "Descripcion";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(354, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "Id";
            // 
            // listaDeCiudadBindingSource
            // 
            this.listaDeCiudadBindingSource.DataSource = typeof(Ventas.Modelos.Ciudad);
            // 
            // direccionTextBox1
            // 
            this.direccionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeClientesBindingSource, "Direccion", true));
            this.direccionTextBox1.Location = new System.Drawing.Point(81, 38);
            this.direccionTextBox1.Name = "direccionTextBox1";
            this.direccionTextBox1.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBox1.TabIndex = 15;
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeClientesBindingSource, "Id", true));
            this.idTextBox1.Location = new System.Drawing.Point(81, 64);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(100, 20);
            this.idTextBox1.TabIndex = 17;
            // 
            // nombreTextBox1
            // 
            this.nombreTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeClientesBindingSource, "Nombre", true));
            this.nombreTextBox1.Location = new System.Drawing.Point(81, 90);
            this.nombreTextBox1.Name = "nombreTextBox1";
            this.nombreTextBox1.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox1.TabIndex = 19;
            // 
            // telefonoTextBox1
            // 
            this.telefonoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listadeClientesBindingSource, "Telefono", true));
            this.telefonoTextBox1.Location = new System.Drawing.Point(81, 116);
            this.telefonoTextBox1.Name = "telefonoTextBox1";
            this.telefonoTextBox1.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox1.TabIndex = 21;
            // 
            // listadeClientesDataGridView
            // 
            this.listadeClientesDataGridView.AutoGenerateColumns = false;
            this.listadeClientesDataGridView.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.listadeClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadeClientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6});
            this.listadeClientesDataGridView.DataSource = this.listadeClientesBindingSource;
            this.listadeClientesDataGridView.GridColor = System.Drawing.Color.Coral;
            this.listadeClientesDataGridView.Location = new System.Drawing.Point(23, 178);
            this.listadeClientesDataGridView.Name = "listadeClientesDataGridView";
            this.listadeClientesDataGridView.Size = new System.Drawing.Size(552, 182);
            this.listadeClientesDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CiudadId";
            this.dataGridViewTextBoxColumn6.DataSource = this.listaDeCiudadBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ciudad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "Id";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::holamundo.Properties.Resources.como_se_ayudan_entre_si_el_marketing_y_la_fuerza_de_ventas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 434);
            this.Controls.Add(this.listadeClientesDataGridView);
            this.Controls.Add(direccionLabel1);
            this.Controls.Add(this.direccionTextBox1);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(nombreLabel1);
            this.Controls.Add(this.nombreTextBox1);
            this.Controls.Add(telefonoLabel1);
            this.Controls.Add(this.telefonoTextBox1);
            this.Controls.Add(label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listadeClientesBindingNavigator);
            this.Name = "Form2";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.listadeClientesBindingNavigator)).EndInit();
            this.listadeClientesBindingNavigator.ResumeLayout(false);
            this.listadeClientesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadeClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeCiudadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadeClientesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listadeClientesBindingSource;
        private System.Windows.Forms.BindingNavigator listadeClientesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listadeClientesBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource listaDeCiudadBindingSource;
        private System.Windows.Forms.TextBox direccionTextBox1;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox nombreTextBox1;
        private System.Windows.Forms.TextBox telefonoTextBox1;
        private System.Windows.Forms.DataGridView listadeClientesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
    }
}