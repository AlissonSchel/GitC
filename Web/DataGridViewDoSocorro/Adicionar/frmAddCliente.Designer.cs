namespace DataGridViewDoSocorro.Adicionar
{
    partial class frmAddCliente
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.clientesTableAdapter1 = new DataGridViewDoSocorro.ParteFinalLocadoraTSQLDataSetTableAdapters.ClientesTableAdapter();
            this.usuariosTableAdapter1 = new DataGridViewDoSocorro.ParteFinalLocadoraTSQLDataSetTableAdapters.UsuariosTableAdapter();
            this.parteFinalLocadoraTSQLDataSet1 = new DataGridViewDoSocorro.ParteFinalLocadoraTSQLDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.parteFinalLocadoraTSQLDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(71, 104);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(205, 50);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome: ";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(33, 57);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(277, 22);
            this.tbxNome.TabIndex = 2;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // usuariosTableAdapter1
            // 
            this.usuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // parteFinalLocadoraTSQLDataSet1
            // 
            this.parteFinalLocadoraTSQLDataSet1.DataSetName = "ParteFinalLocadoraTSQLDataSet";
            this.parteFinalLocadoraTSQLDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmAddCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 188);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddCliente";
            this.Text = "Adicionar Cliente";
            this.Load += new System.EventHandler(this.FrmAddCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parteFinalLocadoraTSQLDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNome;
        private ParteFinalLocadoraTSQLDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter1;
        private ParteFinalLocadoraTSQLDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter1;
        private ParteFinalLocadoraTSQLDataSet parteFinalLocadoraTSQLDataSet1;
    }
}