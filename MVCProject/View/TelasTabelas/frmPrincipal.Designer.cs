namespace MVCProject.View
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gênerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.autorToolStripMenuItem,
            this.gênerosToolStripMenuItem,
            this.livrosToolStripMenuItem,
            this.locaçãoToolStripMenuItem,
            this.editorasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(80, 32);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.usuáriosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.usuáriosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.UsuáriosToolStripMenuItem_Click);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.autorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.autorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.autorToolStripMenuItem.Text = "Autores";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.AutorToolStripMenuItem_Click);
            // 
            // gênerosToolStripMenuItem
            // 
            this.gênerosToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.gênerosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gênerosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gênerosToolStripMenuItem.Name = "gênerosToolStripMenuItem";
            this.gênerosToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.gênerosToolStripMenuItem.Text = "Gêneros";
            this.gênerosToolStripMenuItem.Click += new System.EventHandler(this.GênerosToolStripMenuItem_Click);
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.livrosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.livrosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.livrosToolStripMenuItem.Text = "Livros";
            this.livrosToolStripMenuItem.Click += new System.EventHandler(this.LivrosToolStripMenuItem_Click);
            // 
            // locaçãoToolStripMenuItem
            // 
            this.locaçãoToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.locaçãoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.locaçãoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.locaçãoToolStripMenuItem.Text = "Locação";
            this.locaçãoToolStripMenuItem.Click += new System.EventHandler(this.LocaçãoToolStripMenuItem_Click);
            // 
            // editorasToolStripMenuItem
            // 
            this.editorasToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.editorasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.editorasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editorasToolStripMenuItem.Name = "editorasToolStripMenuItem";
            this.editorasToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.editorasToolStripMenuItem.Text = "Editoras";
            this.editorasToolStripMenuItem.Click += new System.EventHandler(this.EditorasToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(229, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 79);
            this.label1.TabIndex = 1;
            this.label1.Text = "00:00:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "SYSGIOMAR v1.0";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gênerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorasToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}