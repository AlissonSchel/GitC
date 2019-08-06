namespace MVCProject.View.Editar
{
    partial class frmEditLocacao
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
            this.numTipo = new System.Windows.Forms.NumericUpDown();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.boxUsuario = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaBibliotecaDBDataSet = new MVCProject.SistemaBibliotecaDBDataSet();
            this.boxLivro = new System.Windows.Forms.ComboBox();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.livrosTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.LivrosTableAdapter();
            this.usuariosTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.UsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // numTipo
            // 
            this.numTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.numTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTipo.Location = new System.Drawing.Point(163, 140);
            this.numTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numTipo.Name = "numTipo";
            this.numTipo.Size = new System.Drawing.Size(160, 22);
            this.numTipo.TabIndex = 14;
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(119)))), ((int)(((byte)(93)))));
            this.dtpDevolucao.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(119)))), ((int)(((byte)(93)))));
            this.dtpDevolucao.Location = new System.Drawing.Point(112, 197);
            this.dtpDevolucao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(265, 22);
            this.dtpDevolucao.TabIndex = 13;
            // 
            // boxUsuario
            // 
            this.boxUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.boxUsuario.DataSource = this.usuariosBindingSource;
            this.boxUsuario.DisplayMember = "Nome";
            this.boxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxUsuario.FormattingEnabled = true;
            this.boxUsuario.Location = new System.Drawing.Point(81, 84);
            this.boxUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxUsuario.Name = "boxUsuario";
            this.boxUsuario.Size = new System.Drawing.Size(331, 24);
            this.boxUsuario.TabIndex = 11;
            this.boxUsuario.ValueMember = "Id";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // sistemaBibliotecaDBDataSet
            // 
            this.sistemaBibliotecaDBDataSet.DataSetName = "SistemaBibliotecaDBDataSet";
            this.sistemaBibliotecaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boxLivro
            // 
            this.boxLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.boxLivro.DataSource = this.livrosBindingSource;
            this.boxLivro.DisplayMember = "Titulo";
            this.boxLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxLivro.FormattingEnabled = true;
            this.boxLivro.Location = new System.Drawing.Point(81, 31);
            this.boxLivro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxLivro.Name = "boxLivro";
            this.boxLivro.Size = new System.Drawing.Size(331, 24);
            this.boxLivro.TabIndex = 12;
            this.boxLivro.ValueMember = "Id";
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Devolução";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Usuario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Livro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(33)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(49, 251);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(396, 69);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // frmEditLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(499, 370);
            this.Controls.Add(this.numTipo);
            this.Controls.Add(this.dtpDevolucao);
            this.Controls.Add(this.boxUsuario);
            this.Controls.Add(this.boxLivro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEditLocacao";
            this.Text = "frmEditLocacao";
            this.Load += new System.EventHandler(this.FrmEditLocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numTipo;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.ComboBox boxUsuario;
        private System.Windows.Forms.ComboBox boxLivro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private SistemaBibliotecaDBDataSet sistemaBibliotecaDBDataSet;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
    }
}