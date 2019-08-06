namespace MVCProject.View.Adicionar
{
    partial class frmAddGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddGenero));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTipo = new System.Windows.Forms.TextBox();
            this.txbDescricao = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descrição";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbTipo
            // 
            this.txbTipo.BackColor = System.Drawing.Color.Black;
            this.txbTipo.ForeColor = System.Drawing.Color.White;
            this.txbTipo.Location = new System.Drawing.Point(59, 54);
            this.txbTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTipo.Name = "txbTipo";
            this.txbTipo.Size = new System.Drawing.Size(343, 22);
            this.txbTipo.TabIndex = 1;
            // 
            // txbDescricao
            // 
            this.txbDescricao.BackColor = System.Drawing.Color.Black;
            this.txbDescricao.ForeColor = System.Drawing.Color.White;
            this.txbDescricao.Location = new System.Drawing.Point(12, 140);
            this.txbDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(433, 196);
            this.txbDescricao.TabIndex = 2;
            this.txbDescricao.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(33)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(49, 351);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(357, 80);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salvarl";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmAddGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.txbTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmAddGenero";
            this.Text = "Cadastrar Gênero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTipo;
        private System.Windows.Forms.RichTextBox txbDescricao;
        private System.Windows.Forms.Button button1;
    }
}