namespace appReserva
{
    partial class frmEmpresa
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
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.bdReservaumgDataSet1 = new appReserva.bdReservaumgDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbEmpresaTableAdapter = new appReserva.bdReservaumgDataSetTableAdapters.tbEmpresaTableAdapter();
            this.tableAdapterManager = new appReserva.bdReservaumgDataSetTableAdapters.TableAdapterManager();
            this.tbEmpresaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdReservaumgDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmpresaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(194, 86);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(100, 22);
            this.txtEmpresa.TabIndex = 0;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(194, 170);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // bdReservaumgDataSet1
            // 
            this.bdReservaumgDataSet1.DataSetName = "bdReservaumgDataSet";
            this.bdReservaumgDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tbEmpresa";
            this.bindingSource1.DataSource = this.bdReservaumgDataSet1;
            // 
            // tbEmpresaTableAdapter
            // 
            this.tbEmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbEmpresaTableAdapter = null;
            this.tableAdapterManager.tbObjetoTableAdapter = null;
            this.tableAdapterManager.tbReservaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = appReserva.bdReservaumgDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbEmpresaDataGridView
            // 
            this.tbEmpresaDataGridView.AutoGenerateColumns = false;
            this.tbEmpresaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbEmpresaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tbEmpresaDataGridView.DataSource = this.bindingSource1;
            this.tbEmpresaDataGridView.Location = new System.Drawing.Point(150, 232);
            this.tbEmpresaDataGridView.Name = "tbEmpresaDataGridView";
            this.tbEmpresaDataGridView.RowHeadersWidth = 51;
            this.tbEmpresaDataGridView.RowTemplate.Height = 24;
            this.tbEmpresaDataGridView.Size = new System.Drawing.Size(526, 220);
            this.tbEmpresaDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idEmpresa";
            this.dataGridViewTextBoxColumn1.HeaderText = "idEmpresa";
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
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(465, 170);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.tbEmpresaDataGridView);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtEmpresa);
            this.Name = "frmEmpresa";
            this.Text = "frmEmpresa";
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdReservaumgDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmpresaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Button btnInsertar;
        private bdReservaumgDataSet bdReservaumgDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private bdReservaumgDataSetTableAdapters.tbEmpresaTableAdapter tbEmpresaTableAdapter;
        private bdReservaumgDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbEmpresaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnEliminar;
    }
}