namespace DataGridViewDoSocorro.Edicao
{
    partial class frmEdicaoUsuarios
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
            this.usuariosTableAdapter1 = new DataGridViewDoSocorro.ParteFinalLocadoraTSQLDataSetTableAdapters.UsuariosTableAdapter();
            this.Salvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usuariosTableAdapter1
            // 
            this.usuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // Salvar
            // 
            this.Salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.Salvar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Salvar.FlatAppearance.BorderSize = 5;
            this.Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salvar.Location = new System.Drawing.Point(93, 145);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(207, 60);
            this.Salvar.TabIndex = 0;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = false;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome: ";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(93, 39);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(207, 22);
            this.txbNome.TabIndex = 2;
            // 
            // frmEdicaoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(120)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(390, 223);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Salvar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(64)))));
            this.Name = "frmEdicaoUsuarios";
            this.Text = "frmEdicaoUsuarios";
            this.Load += new System.EventHandler(this.FrmEdicaoUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ParteFinalLocadoraTSQLDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter1;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNome;
    }
}