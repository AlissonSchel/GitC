namespace DataGridViewDoSocorro
{
    partial class Lixeira
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.restaurarComando = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.parteFinalLocadoraTSQLDataSet = new DataGridViewDoSocorro.ParteFinalLocadoraTSQLDataSet();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new DataGridViewDoSocorro.ParteFinalLocadoraTSQLDataSetTableAdapters.DataTable1TableAdapter();
            this.carrosTableAdapter1 = new DataGridViewDoSocorro.ParteFinalLocadoraTSQLDataSetTableAdapters.CarrosTableAdapter();
            this.clientesTableAdapter1 = new DataGridViewDoSocorro.ParteFinalLocadoraTSQLDataSetTableAdapters.ClientesTableAdapter();
            this.usuariosTableAdapter1 = new DataGridViewDoSocorro.ParteFinalLocadoraTSQLDataSetTableAdapters.UsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parteFinalLocadoraTSQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.restaurarComando,
            this.Column1,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable1BindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // restaurarComando
            // 
            this.restaurarComando.DataPropertyName = "restaurarComando";
            this.restaurarComando.HeaderText = "Restaurar";
            this.restaurarComando.MinimumWidth = 6;
            this.restaurarComando.Name = "restaurarComando";
            this.restaurarComando.ReadOnly = true;
            this.restaurarComando.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.restaurarComando.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.restaurarComando.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Tabela";
            this.Column1.HeaderText = "Tabela";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.parteFinalLocadoraTSQLDataSet;
            // 
            // parteFinalLocadoraTSQLDataSet
            // 
            this.parteFinalLocadoraTSQLDataSet.DataSetName = "ParteFinalLocadoraTSQLDataSet";
            this.parteFinalLocadoraTSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.parteFinalLocadoraTSQLDataSet;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // carrosTableAdapter1
            // 
            this.carrosTableAdapter1.ClearBeforeFill = true;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // usuariosTableAdapter1
            // 
            this.usuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // Lixeira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(127)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(64)))));
            this.Name = "Lixeira";
            this.Text = "Lixeira";
            this.Load += new System.EventHandler(this.Lixeira_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parteFinalLocadoraTSQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ParteFinalLocadoraTSQLDataSet parteFinalLocadoraTSQLDataSet;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private ParteFinalLocadoraTSQLDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private ParteFinalLocadoraTSQLDataSetTableAdapters.CarrosTableAdapter carrosTableAdapter1;
        private ParteFinalLocadoraTSQLDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter1;
        private ParteFinalLocadoraTSQLDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn restaurarComando;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}