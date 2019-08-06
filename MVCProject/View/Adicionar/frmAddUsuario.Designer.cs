namespace MVCProject.View.Adicionar
{
    partial class frmAddUsuario
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
            this.label4 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha: ";
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.Black;
            this.txbEmail.ForeColor = System.Drawing.Color.White;
            this.txbEmail.Location = new System.Drawing.Point(71, 48);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(225, 22);
            this.txbEmail.TabIndex = 4;
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.Black;
            this.txbNome.ForeColor = System.Drawing.Color.White;
            this.txbNome.Location = new System.Drawing.Point(71, 6);
            this.txbNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(225, 22);
            this.txbNome.TabIndex = 4;
            // 
            // txbLogin
            // 
            this.txbLogin.BackColor = System.Drawing.Color.Black;
            this.txbLogin.ForeColor = System.Drawing.Color.White;
            this.txbLogin.Location = new System.Drawing.Point(71, 91);
            this.txbLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(225, 22);
            this.txbLogin.TabIndex = 4;
            // 
            // txbSenha
            // 
            this.txbSenha.BackColor = System.Drawing.Color.Black;
            this.txbSenha.ForeColor = System.Drawing.Color.White;
            this.txbSenha.Location = new System.Drawing.Point(71, 134);
            this.txbSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(225, 22);
            this.txbSenha.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(33)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(47, 214);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmAddUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(327, 305);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmAddUsuario";
            this.Text = "Adicionar Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Button button1;
    }
}