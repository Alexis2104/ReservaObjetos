namespace appReserva
{
    partial class frmReservas
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
            System.Windows.Forms.Label idEmpresaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservas));
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.tbEmpresaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tbEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdReservaumgDataSet = new appReserva.bdReservaumgDataSet();
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
            this.tbEmpresaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idEmpresaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.tbObjetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbObjetoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReservar = new System.Windows.Forms.Button();
            this.dtmInicio = new System.Windows.Forms.DateTimePicker();
            this.dtmFin = new System.Windows.Forms.DateTimePicker();
            this.tbEmpresaTableAdapter = new appReserva.bdReservaumgDataSetTableAdapters.tbEmpresaTableAdapter();
            this.tableAdapterManager = new appReserva.bdReservaumgDataSetTableAdapters.TableAdapterManager();
            this.tbObjetoTableAdapter = new appReserva.bdReservaumgDataSetTableAdapters.tbObjetoTableAdapter();
            this.bdReservaumgDataSet1 = new appReserva.bdReservaumgDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbReservaTableAdapter = new appReserva.bdReservaumgDataSetTableAdapters.tbReservaTableAdapter();
            this.idCliente = new System.Windows.Forms.ComboBox();
            this.tbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbClienteTableAdapter = new appReserva.bdReservaumgDataSetTableAdapters.tbClienteTableAdapter();
            this.btnEliminarR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            idEmpresaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmpresaBindingNavigator)).BeginInit();
            this.tbEmpresaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdReservaumgDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbObjetoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbObjetoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdReservaumgDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // idEmpresaLabel
            // 
            idEmpresaLabel.AutoSize = true;
            idEmpresaLabel.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idEmpresaLabel.Location = new System.Drawing.Point(91, 77);
            idEmpresaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idEmpresaLabel.Name = "idEmpresaLabel";
            idEmpresaLabel.Size = new System.Drawing.Size(85, 18);
            idEmpresaLabel.TabIndex = 1;
            idEmpresaLabel.Text = "id Empresa:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(91, 100);
            nombreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(65, 18);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // tbEmpresaBindingNavigator
            // 
            this.tbEmpresaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbEmpresaBindingNavigator.BindingSource = this.tbEmpresaBindingSource;
            this.tbEmpresaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbEmpresaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbEmpresaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbEmpresaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbEmpresaBindingNavigatorSaveItem});
            this.tbEmpresaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbEmpresaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbEmpresaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbEmpresaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbEmpresaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbEmpresaBindingNavigator.Name = "tbEmpresaBindingNavigator";
            this.tbEmpresaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbEmpresaBindingNavigator.Size = new System.Drawing.Size(627, 27);
            this.tbEmpresaBindingNavigator.TabIndex = 0;
            this.tbEmpresaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // tbEmpresaBindingSource
            // 
            this.tbEmpresaBindingSource.DataMember = "tbEmpresa";
            this.tbEmpresaBindingSource.DataSource = this.bdReservaumgDataSet;
            // 
            // bdReservaumgDataSet
            // 
            this.bdReservaumgDataSet.DataSetName = "bdReservaumgDataSet";
            this.bdReservaumgDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tbEmpresaBindingNavigatorSaveItem
            // 
            this.tbEmpresaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbEmpresaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbEmpresaBindingNavigatorSaveItem.Image")));
            this.tbEmpresaBindingNavigatorSaveItem.Name = "tbEmpresaBindingNavigatorSaveItem";
            this.tbEmpresaBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tbEmpresaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.tbEmpresaBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbEmpresaBindingNavigatorSaveItem_Click);
            // 
            // idEmpresaTextBox
            // 
            this.idEmpresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbEmpresaBindingSource, "idEmpresa", true));
            this.idEmpresaTextBox.Location = new System.Drawing.Point(176, 77);
            this.idEmpresaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idEmpresaTextBox.Name = "idEmpresaTextBox";
            this.idEmpresaTextBox.Size = new System.Drawing.Size(156, 20);
            this.idEmpresaTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbEmpresaBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(176, 100);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(156, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // tbObjetoBindingSource
            // 
            this.tbObjetoBindingSource.DataMember = "tbEmpresa_tbObjeto";
            this.tbObjetoBindingSource.DataSource = this.tbEmpresaBindingSource;
            // 
            // tbObjetoDataGridView
            // 
            this.tbObjetoDataGridView.AutoGenerateColumns = false;
            this.tbObjetoDataGridView.BackgroundColor = System.Drawing.Color.Thistle;
            this.tbObjetoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbObjetoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tbObjetoDataGridView.DataSource = this.tbObjetoBindingSource;
            this.tbObjetoDataGridView.Location = new System.Drawing.Point(0, 140);
            this.tbObjetoDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbObjetoDataGridView.Name = "tbObjetoDataGridView";
            this.tbObjetoDataGridView.RowHeadersWidth = 51;
            this.tbObjetoDataGridView.RowTemplate.Height = 24;
            this.tbObjetoDataGridView.Size = new System.Drawing.Size(429, 179);
            this.tbObjetoDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idObjeto";
            this.dataGridViewTextBoxColumn1.HeaderText = "idObjeto";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idEmpresa";
            this.dataGridViewTextBoxColumn3.HeaderText = "idEmpresa";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // btnReservar
            // 
            this.btnReservar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(452, 314);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(162, 36);
            this.btnReservar.TabIndex = 6;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // dtmInicio
            // 
            this.dtmInicio.CustomFormat = "dd/MM/yy H:mm";
            this.dtmInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmInicio.Location = new System.Drawing.Point(444, 148);
            this.dtmInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtmInicio.Name = "dtmInicio";
            this.dtmInicio.ShowUpDown = true;
            this.dtmInicio.Size = new System.Drawing.Size(170, 20);
            this.dtmInicio.TabIndex = 10;
            this.dtmInicio.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dtmFin
            // 
            this.dtmFin.CustomFormat = "dd/MM/yy H:mm";
            this.dtmFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmFin.Location = new System.Drawing.Point(444, 217);
            this.dtmFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtmFin.Name = "dtmFin";
            this.dtmFin.ShowUpDown = true;
            this.dtmFin.Size = new System.Drawing.Size(170, 20);
            this.dtmFin.TabIndex = 11;
            // 
            // tbEmpresaTableAdapter
            // 
            this.tbEmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbEmpresaTableAdapter = this.tbEmpresaTableAdapter;
            this.tableAdapterManager.tbObjetoTableAdapter = this.tbObjetoTableAdapter;
            this.tableAdapterManager.tbReservaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = appReserva.bdReservaumgDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbObjetoTableAdapter
            // 
            this.tbObjetoTableAdapter.ClearBeforeFill = true;
            // 
            // bdReservaumgDataSet1
            // 
            this.bdReservaumgDataSet1.DataSetName = "bdReservaumgDataSet";
            this.bdReservaumgDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tbReserva";
            this.bindingSource1.DataSource = this.bdReservaumgDataSet;
            // 
            // tbReservaTableAdapter
            // 
            this.tbReservaTableAdapter.ClearBeforeFill = true;
            // 
            // idCliente
            // 
            this.idCliente.DataSource = this.tbClienteBindingSource;
            this.idCliente.DisplayMember = "Nombre";
            this.idCliente.FormattingEnabled = true;
            this.idCliente.Location = new System.Drawing.Point(450, 77);
            this.idCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idCliente.Name = "idCliente";
            this.idCliente.Size = new System.Drawing.Size(150, 21);
            this.idCliente.TabIndex = 12;
            this.idCliente.ValueMember = "idCliente";
            // 
            // tbClienteBindingSource
            // 
            this.tbClienteBindingSource.DataMember = "tbCliente";
            this.tbClienteBindingSource.DataSource = this.bdReservaumgDataSet;
            // 
            // tbClienteTableAdapter
            // 
            this.tbClienteTableAdapter.ClearBeforeFill = true;
            // 
            // btnEliminarR
            // 
            this.btnEliminarR.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarR.Location = new System.Drawing.Point(452, 261);
            this.btnEliminarR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarR.Name = "btnEliminarR";
            this.btnEliminarR.Size = new System.Drawing.Size(162, 36);
            this.btnEliminarR.TabIndex = 13;
            this.btnEliminarR.Text = "Eliminar";
            this.btnEliminarR.UseVisualStyleBackColor = true;
            this.btnEliminarR.Click += new System.EventHandler(this.btnEliminarR_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(478, 128);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(106, 18);
            label1.TabIndex = 14;
            label1.Text = "Fecha de Inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(478, 197);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 18);
            label2.TabIndex = 15;
            label2.Text = "Fecha de Fin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::appReserva.Properties.Resources.pictureBox1_Image;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // frmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(627, 386);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnEliminarR);
            this.Controls.Add(this.idCliente);
            this.Controls.Add(this.dtmFin);
            this.Controls.Add(this.dtmInicio);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.tbObjetoDataGridView);
            this.Controls.Add(idEmpresaLabel);
            this.Controls.Add(this.idEmpresaTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.tbEmpresaBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmReservas";
            this.Text = "frmReservas";
            this.Load += new System.EventHandler(this.frmReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbEmpresaBindingNavigator)).EndInit();
            this.tbEmpresaBindingNavigator.ResumeLayout(false);
            this.tbEmpresaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdReservaumgDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbObjetoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbObjetoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdReservaumgDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bdReservaumgDataSet bdReservaumgDataSet;
        private System.Windows.Forms.BindingSource tbEmpresaBindingSource;
        private bdReservaumgDataSetTableAdapters.tbEmpresaTableAdapter tbEmpresaTableAdapter;
        private bdReservaumgDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbEmpresaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbEmpresaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idEmpresaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private bdReservaumgDataSetTableAdapters.tbObjetoTableAdapter tbObjetoTableAdapter;
        private System.Windows.Forms.BindingSource tbObjetoBindingSource;
        private System.Windows.Forms.DataGridView tbObjetoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.DateTimePicker dtmInicio;
        private System.Windows.Forms.DateTimePicker dtmFin;
        private bdReservaumgDataSet bdReservaumgDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private bdReservaumgDataSetTableAdapters.tbReservaTableAdapter tbReservaTableAdapter;
        private System.Windows.Forms.ComboBox idCliente;
        private System.Windows.Forms.BindingSource tbClienteBindingSource;
        private bdReservaumgDataSetTableAdapters.tbClienteTableAdapter tbClienteTableAdapter;
        private System.Windows.Forms.Button btnEliminarR;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}