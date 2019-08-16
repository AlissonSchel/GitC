namespace DataGridViewDoSocorro.Adicionar
{
    partial class frmAddCarro
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
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.carrosTableAdapter1 = new DataGridViewDoSocorro.ParteFinalLocadoraTSQLDataSetTableAdapters.CarrosTableAdapter();
            this.clientesTableAdapter1 = new DataGridViewDoSocorro.ParteFinalLocadoraTSQLDataSetTableAdapters.ClientesTableAdapter();
            this.estoqueTableAdapter1 = new DataGridViewDoSocorro.ParteFinalLocadoraTSQLDataSetTableAdapters.EstoqueTableAdapter();
            this.locacaoTableAdapter1 = new DataGridViewDoSocorro.ParteFinalLocadoraTSQLDataSetTableAdapters.LocacaoTableAdapter();
            this.usuariosTableAdapter1 = new DataGridViewDoSocorro.ParteFinalLocadoraTSQLDataSetTableAdapters.UsuariosTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.txbObs = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(13, 54);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(277, 22);
            this.tbxNome.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome: ";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(49, 283);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(205, 50);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // carrosTableAdapter1
            // 
            this.carrosTableAdapter1.ClearBeforeFill = true;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // estoqueTableAdapter1
            // 
            this.estoqueTableAdapter1.ClearBeforeFill = true;
            // 
            // locacaoTableAdapter1
            // 
            this.locacaoTableAdapter1.ClearBeforeFill = true;
            // 
            // usuariosTableAdapter1
            // 
            this.usuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Observação:";
            // 
            // txbObs
            // 
            this.txbObs.Location = new System.Drawing.Point(13, 110);
            this.txbObs.Name = "txbObs";
            this.txbObs.Size = new System.Drawing.Size(277, 96);
            this.txbObs.TabIndex = 7;
            this.txbObs.Text = "";
            // 
            // frmAddCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 356);
            this.Controls.Add(this.txbObs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Name = "frmAddCarro";
            this.Text = "Adicionar Carro";
            this.Load += new System.EventHandler(this.FrmAddCarro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private ParteFinalLocadoraTSQLDataSetTableAdapters.CarrosTableAdapter carrosTableAdapter1;
        private ParteFinalLocadoraTSQLDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter1;
        private ParteFinalLocadoraTSQLDataSetTableAdapters.EstoqueTableAdapter estoqueTableAdapter1;
        private ParteFinalLocadoraTSQLDataSetTableAdapters.LocacaoTableAdapter locacaoTableAdapter1;
        private ParteFinalLocadoraTSQLDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txbObs;
    }
}