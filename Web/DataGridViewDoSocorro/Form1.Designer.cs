namespace DataGridViewDoSocorro
{
    partial class Form1
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteCommand = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parteFinalLocadoraTSQLDataSet = new DataGridViewDoSocorro.ParteFinalLocadoraTSQLDataSet();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnCarros = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.clientesTableAdapter = new DataGridViewDoSocorro.ParteFinalLocadoraTSQLDataSetTableAdapters.ClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parteFinalLocadoraTSQLDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnAdicionar.FlatAppearance.BorderSize = 5;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(12, 12);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(92, 72);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar Clientes";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(8)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deleteCommand,
            this.Editar,
            this.idDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.usuIncDataGridViewTextBoxColumn,
            this.usuAltDataGridViewTextBoxColumn,
            this.datIncDataGridViewTextBoxColumn,
            this.datAltDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientesBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(8)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 348);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // deleteCommand
            // 
            this.deleteCommand.DataPropertyName = "DeletCommand";
            this.deleteCommand.HeaderText = "Deletar";
            this.deleteCommand.MinimumWidth = 6;
            this.deleteCommand.Name = "deleteCommand";
            this.deleteCommand.ReadOnly = true;
            this.deleteCommand.Width = 125;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 125;
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
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.clienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuIncDataGridViewTextBoxColumn
            // 
            this.usuIncDataGridViewTextBoxColumn.DataPropertyName = "UsuInc";
            this.usuIncDataGridViewTextBoxColumn.HeaderText = "UsuInc";
            this.usuIncDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuIncDataGridViewTextBoxColumn.Name = "usuIncDataGridViewTextBoxColumn";
            this.usuIncDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuIncDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuAltDataGridViewTextBoxColumn
            // 
            this.usuAltDataGridViewTextBoxColumn.DataPropertyName = "UsuAlt";
            this.usuAltDataGridViewTextBoxColumn.HeaderText = "UsuAlt";
            this.usuAltDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuAltDataGridViewTextBoxColumn.Name = "usuAltDataGridViewTextBoxColumn";
            this.usuAltDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuAltDataGridViewTextBoxColumn.Width = 125;
            // 
            // datIncDataGridViewTextBoxColumn
            // 
            this.datIncDataGridViewTextBoxColumn.DataPropertyName = "DatInc";
            this.datIncDataGridViewTextBoxColumn.HeaderText = "DatInc";
            this.datIncDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datIncDataGridViewTextBoxColumn.Name = "datIncDataGridViewTextBoxColumn";
            this.datIncDataGridViewTextBoxColumn.ReadOnly = true;
            this.datIncDataGridViewTextBoxColumn.Width = 125;
            // 
            // datAltDataGridViewTextBoxColumn
            // 
            this.datAltDataGridViewTextBoxColumn.DataPropertyName = "DatAlt";
            this.datAltDataGridViewTextBoxColumn.HeaderText = "DatAlt";
            this.datAltDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datAltDataGridViewTextBoxColumn.Name = "datAltDataGridViewTextBoxColumn";
            this.datAltDataGridViewTextBoxColumn.ReadOnly = true;
            this.datAltDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.parteFinalLocadoraTSQLDataSet;
            // 
            // parteFinalLocadoraTSQLDataSet
            // 
            this.parteFinalLocadoraTSQLDataSet.DataSetName = "ParteFinalLocadoraTSQLDataSet";
            this.parteFinalLocadoraTSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnClientes
            // 
            this.btnClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnClientes.FlatAppearance.BorderSize = 5;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Location = new System.Drawing.Point(310, 12);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(92, 72);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Usuários";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // btnCarros
            // 
            this.btnCarros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.btnCarros.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCarros.FlatAppearance.BorderSize = 5;
            this.btnCarros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarros.Location = new System.Drawing.Point(409, 12);
            this.btnCarros.Name = "btnCarros";
            this.btnCarros.Size = new System.Drawing.Size(92, 72);
            this.btnCarros.TabIndex = 0;
            this.btnCarros.Text = "Carros";
            this.btnCarros.UseVisualStyleBackColor = false;
            this.btnCarros.Click += new System.EventHandler(this.BtnCarros_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(695, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lixeira";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnLixeira_Click);
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(120)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(799, 446);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCarros);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnAdicionar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parteFinalLocadoraTSQLDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ParteFinalLocadoraTSQLDataSet parteFinalLocadoraTSQLDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private ParteFinalLocadoraTSQLDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCarros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn deleteCommand;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuIncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuAltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datIncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datAltDataGridViewTextBoxColumn;
    }
}

