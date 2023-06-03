namespace appReserva
{
    partial class frmObjetos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObjetos));
            System.Windows.Forms.Label idEmpresaLabel;
            System.Windows.Forms.Label nombreLabel;
            this.bdReservaumgDataSet = new appReserva.bdReservaumgDataSet();
            this.tbEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbEmpresaTableAdapter = new appReserva.bdReservaumgDataSetTableAdapters.tbEmpresaTableAdapter();
            this.tableAdapterManager = new appReserva.bdReservaumgDataSetTableAdapters.TableAdapterManager();
            this.tbEmpresaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tbEmpresaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idEmpresaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.tbObjetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbObjetoTableAdapter = new appReserva.bdReservaumgDataSetTableAdapters.tbObjetoTableAdapter();
            this.frmObjeto = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idEmpresaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdReservaumgDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmpresaBindingNavigator)).BeginInit();
            this.tbEmpresaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbObjetoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmObjeto)).BeginInit();
            this.SuspendLayout();
            // 
            // bdReservaumgDataSet
            // 
            this.bdReservaumgDataSet.DataSetName = "bdReservaumgDataSet";
            this.bdReservaumgDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbEmpresaBindingSource
            // 
            this.tbEmpresaBindingSource.DataMember = "tbEmpresa";
            this.tbEmpresaBindingSource.DataSource = this.bdReservaumgDataSet;
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
            this.tbEmpresaBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.tbEmpresaBindingNavigator.TabIndex = 0;
            this.tbEmpresaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // tbEmpresaBindingNavigatorSaveItem
            // 
            this.tbEmpresaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbEmpresaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbEmpresaBindingNavigatorSaveItem.Image")));
            this.tbEmpresaBindingNavigatorSaveItem.Name = "tbEmpresaBindingNavigatorSaveItem";
            this.tbEmpresaBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.tbEmpresaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.tbEmpresaBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbEmpresaBindingNavigatorSaveItem_Click_1);
            // 
            // idEmpresaLabel
            // 
            idEmpresaLabel.AutoSize = true;
            idEmpresaLabel.Location = new System.Drawing.Point(235, 74);
            idEmpresaLabel.Name = "idEmpresaLabel";
            idEmpresaLabel.Size = new System.Drawing.Size(79, 16);
            idEmpresaLabel.TabIndex = 1;
            idEmpresaLabel.Text = "id Empresa:";
            // 
            // idEmpresaTextBox
            // 
            this.idEmpresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbEmpresaBindingSource, "idEmpresa", true));
            this.idEmpresaTextBox.Location = new System.Drawing.Point(320, 71);
            this.idEmpresaTextBox.Name = "idEmpresaTextBox";
            this.idEmpresaTextBox.Size = new System.Drawing.Size(100, 22);
            this.idEmpresaTextBox.TabIndex = 2;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(235, 102);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(59, 16);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbEmpresaBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(320, 99);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 22);
            this.nombreTextBox.TabIndex = 4;
            // 
            // tbObjetoBindingSource
            // 
            this.tbObjetoBindingSource.DataMember = "tbEmpresa_tbObjeto";
            this.tbObjetoBindingSource.DataSource = this.tbEmpresaBindingSource;
            // 
            // tbObjetoTableAdapter
            // 
            this.tbObjetoTableAdapter.ClearBeforeFill = true;
            // 
            // frmObjeto
            // 
            this.frmObjeto.AutoGenerateColumns = false;
            this.frmObjeto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frmObjeto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.frmObjeto.DataSource = this.tbObjetoBindingSource;
            this.frmObjeto.Location = new System.Drawing.Point(238, 192);
            this.frmObjeto.Name = "frmObjeto";
            this.frmObjeto.RowHeadersWidth = 51;
            this.frmObjeto.RowTemplate.Height = 24;
            this.frmObjeto.Size = new System.Drawing.Size(300, 220);
            this.frmObjeto.TabIndex = 5;
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
            // frmObjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.frmObjeto);
            this.Controls.Add(idEmpresaLabel);
            this.Controls.Add(this.idEmpresaTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.tbEmpresaBindingNavigator);
            this.Name = "frmObjetos";
            this.Text = "frmObjetos";
            this.Load += new System.EventHandler(this.frmObjetos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdReservaumgDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmpresaBindingNavigator)).EndInit();
            this.tbEmpresaBindingNavigator.ResumeLayout(false);
            this.tbEmpresaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbObjetoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmObjeto)).EndInit();
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
        private System.Windows.Forms.DataGridView frmObjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}