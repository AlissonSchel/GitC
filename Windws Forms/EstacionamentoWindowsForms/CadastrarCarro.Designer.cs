namespace EstacionamentoWindowsForms
{
    partial class CadastrarCarro
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.txbPlaca = new System.Windows.Forms.TextBox();
            this.numAno = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Placa";
            // 
            // txbModelo
            // 
            this.txbModelo.Location = new System.Drawing.Point(112, 39);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(191, 22);
            this.txbModelo.TabIndex = 3;
            // 
            // txbPlaca
            // 
            this.txbPlaca.Location = new System.Drawing.Point(112, 124);
            this.txbPlaca.Name = "txbPlaca";
            this.txbPlaca.Size = new System.Drawing.Size(191, 22);
            this.txbPlaca.TabIndex = 3;
            // 
            // numAno
            // 
            this.numAno.Location = new System.Drawing.Point(112, 82);
            this.numAno.Name = "numAno";
            this.numAno.Size = new System.Drawing.Size(191, 22);
            this.numAno.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(71)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(148)))), ((int)(((byte)(77)))));
            this.button1.FlatAppearance.BorderSize = 8;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(58, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 70);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CadastrarCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(384, 264);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numAno);
            this.Controls.Add(this.txbPlaca);
            this.Controls.Add(this.txbModelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CadastrarCarro";
            this.Text = "CadastrarCarro";
            ((System.ComponentModel.ISupportInitialize)(this.numAno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbModelo;
        private System.Windows.Forms.TextBox txbPlaca;
        private System.Windows.Forms.NumericUpDown numAno;
        private System.Windows.Forms.Button button1;
    }
}