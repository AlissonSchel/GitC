namespace MVCProject.View.Adicionar
{
    partial class frmAddLocacao
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxLivro = new System.Windows.Forms.ComboBox();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaBibliotecaDBDataSet = new MVCProject.SistemaBibliotecaDBDataSet();
            this.livrosTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.LivrosTableAdapter();
            this.boxUsuario = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.UsuariosTableAdapter();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.numTipo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(33)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(79, 262);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(396, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Livro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Devolução";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxLivro
            // 
            this.boxLivro.BackColor = System.Drawing.Color.Black;
            this.boxLivro.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.livrosBindingSource, "Titulo", true));
            this.boxLivro.DataSource = this.livrosBindingSource;
            this.boxLivro.DisplayMember = "Titulo";
            this.boxLivro.ForeColor = System.Drawing.Color.White;
            this.boxLivro.FormattingEnabled = true;
            this.boxLivro.Location = new System.Drawing.Point(111, 42);
            this.boxLivro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxLivro.Name = "boxLivro";
            this.boxLivro.Size = new System.Drawing.Size(331, 24);
            this.boxLivro.TabIndex = 2;
            this.boxLivro.ValueMember = "Id";
            this.boxLivro.SelectedIndexChanged += new System.EventHandler(this.BoxLivro_SelectedIndexChanged);
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // sistemaBibliotecaDBDataSet
            // 
            this.sistemaBibliotecaDBDataSet.DataSetName = "SistemaBibliotecaDBDataSet";
            this.sistemaBibliotecaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // boxUsuario
            // 
            this.boxUsuario.BackColor = System.Drawing.Color.Black;
            this.boxUsuario.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usuariosBindingSource, "Id", true));
            this.boxUsuario.DataSource = this.usuariosBindingSource;
            this.boxUsuario.DisplayMember = "Nome";
            this.boxUsuario.ForeColor = System.Drawing.Color.White;
            this.boxUsuario.FormattingEnabled = true;
            this.boxUsuario.Location = new System.Drawing.Point(111, 95);
            this.boxUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boxUsuario.Name = "boxUsuario";
            this.boxUsuario.Size = new System.Drawing.Size(331, 24);
            this.boxUsuario.TabIndex = 2;
            this.boxUsuario.ValueMember = "Id";
            this.boxUsuario.SelectedIndexChanged += new System.EventHandler(this.BoxUsuario_SelectedIndexChanged);
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(119)))), ((int)(((byte)(93)))));
            this.dtpDevolucao.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(119)))), ((int)(((byte)(93)))));
            this.dtpDevolucao.Location = new System.Drawing.Point(141, 208);
            this.dtpDevolucao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(265, 22);
            this.dtpDevolucao.TabIndex = 4;
            // 
            // numTipo
            // 
            this.numTipo.BackColor = System.Drawing.Color.Black;
            this.numTipo.ForeColor = System.Drawing.Color.White;
            this.numTipo.Location = new System.Drawing.Point(192, 151);
            this.numTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numTipo.Name = "numTipo";
            this.numTipo.Size = new System.Drawing.Size(160, 22);
            this.numTipo.TabIndex = 5;
            this.numTipo.ValueChanged += new System.EventHandler(this.NumTipo_ValueChanged);
            // 
            // frmAddLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(549, 363);
            this.Controls.Add(this.numTipo);
            this.Controls.Add(this.dtpDevolucao);
            this.Controls.Add(this.boxUsuario);
            this.Controls.Add(this.boxLivro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmAddLocacao";
            this.Text = "Locacao";
            this.Load += new System.EventHandler(this.FrmAddLocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox boxLivro;
        private SistemaBibliotecaDBDataSet sistemaBibliotecaDBDataSet;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private System.Windows.Forms.ComboBox boxUsuario;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpDevolucao;
        private System.Windows.Forms.NumericUpDown numTipo;
    }
}