namespace MVCProject.View.Editar
{
    partial class frmEditGenero
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txbDescricao = new System.Windows.Forms.RichTextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.generosTableAdapter1 = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.GenerosTableAdapter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nome: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(78)))), ((int)(((byte)(29)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(33)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(35, 369);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 73);
            this.button1.TabIndex = 17;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txbDescricao
            // 
            this.txbDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(119)))), ((int)(((byte)(93)))));
            this.txbDescricao.Location = new System.Drawing.Point(12, 117);
            this.txbDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(341, 237);
            this.txbDescricao.TabIndex = 16;
            this.txbDescricao.Text = "";
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(119)))), ((int)(((byte)(93)))));
            this.txbNome.Location = new System.Drawing.Point(46, 46);
            this.txbNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(271, 22);
            this.txbNome.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Descrição: ";
            // 
            // generosTableAdapter1
            // 
            this.generosTableAdapter1.ClearBeforeFill = true;
            // 
            // frmEditGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(210)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label2);
            this.Name = "frmEditGenero";
            this.Text = "frmEditGenero";
            this.Load += new System.EventHandler(this.FrmEditGenero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txbDescricao;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private SistemaBibliotecaDBDataSetTableAdapters.GenerosTableAdapter generosTableAdapter1;
    }
}