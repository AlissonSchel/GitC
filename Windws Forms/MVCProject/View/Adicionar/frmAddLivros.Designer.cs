﻿namespace MVCProject.View.Adicionar
{
    partial class frmAddLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddLivros));
            this.label1 = new System.Windows.Forms.Label();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numRegistro = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txbIsbn = new System.Windows.Forms.TextBox();
            this.boxGenero = new System.Windows.Forms.ComboBox();
            this.generosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaBibliotecaDBDataSet = new MVCProject.SistemaBibliotecaDBDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxEditora = new System.Windows.Forms.ComboBox();
            this.editorasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txbSinopse = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbObs = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.generosTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.GenerosTableAdapter();
            this.editorasTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.EditorasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // txbTitulo
            // 
            this.txbTitulo.BackColor = System.Drawing.Color.Black;
            this.txbTitulo.ForeColor = System.Drawing.Color.White;
            this.txbTitulo.Location = new System.Drawing.Point(173, 50);
            this.txbTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(528, 22);
            this.txbTitulo.TabIndex = 1;
            this.txbTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Registro";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numRegistro
            // 
            this.numRegistro.BackColor = System.Drawing.Color.Black;
            this.numRegistro.ForeColor = System.Drawing.Color.White;
            this.numRegistro.Location = new System.Drawing.Point(365, 106);
            this.numRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numRegistro.Name = "numRegistro";
            this.numRegistro.Size = new System.Drawing.Size(120, 22);
            this.numRegistro.TabIndex = 2;
            this.numRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "ISBN";
            // 
            // txbIsbn
            // 
            this.txbIsbn.BackColor = System.Drawing.Color.Black;
            this.txbIsbn.ForeColor = System.Drawing.Color.White;
            this.txbIsbn.Location = new System.Drawing.Point(173, 167);
            this.txbIsbn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbIsbn.Name = "txbIsbn";
            this.txbIsbn.Size = new System.Drawing.Size(528, 22);
            this.txbIsbn.TabIndex = 1;
            this.txbIsbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxGenero
            // 
            this.boxGenero.BackColor = System.Drawing.Color.Black;
            this.boxGenero.DataSource = this.generosBindingSource;
            this.boxGenero.DisplayMember = "Tipo";
            this.boxGenero.ForeColor = System.Drawing.Color.White;
            this.boxGenero.FormattingEnabled = true;
            this.boxGenero.Location = new System.Drawing.Point(301, 228);
            this.boxGenero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxGenero.Name = "boxGenero";
            this.boxGenero.Size = new System.Drawing.Size(269, 24);
            this.boxGenero.TabIndex = 3;
            this.boxGenero.ValueMember = "Id";
            // 
            // generosBindingSource
            // 
            this.generosBindingSource.DataMember = "Generos";
            this.generosBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // sistemaBibliotecaDBDataSet
            // 
            this.sistemaBibliotecaDBDataSet.DataSetName = "SistemaBibliotecaDBDataSet";
            this.sistemaBibliotecaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gênero";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Editora";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxEditora
            // 
            this.boxEditora.BackColor = System.Drawing.Color.Black;
            this.boxEditora.DataSource = this.editorasBindingSource;
            this.boxEditora.DisplayMember = "Nome";
            this.boxEditora.ForeColor = System.Drawing.Color.White;
            this.boxEditora.FormattingEnabled = true;
            this.boxEditora.Location = new System.Drawing.Point(301, 293);
            this.boxEditora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxEditora.Name = "boxEditora";
            this.boxEditora.Size = new System.Drawing.Size(269, 24);
            this.boxEditora.TabIndex = 3;
            this.boxEditora.ValueMember = "Id";
            // 
            // editorasBindingSource
            // 
            this.editorasBindingSource.DataMember = "Editoras";
            this.editorasBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // txbSinopse
            // 
            this.txbSinopse.BackColor = System.Drawing.Color.Black;
            this.txbSinopse.ForeColor = System.Drawing.Color.White;
            this.txbSinopse.Location = new System.Drawing.Point(12, 369);
            this.txbSinopse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSinopse.Name = "txbSinopse";
            this.txbSinopse.Size = new System.Drawing.Size(839, 118);
            this.txbSinopse.TabIndex = 4;
            this.txbSinopse.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sinópse";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Observações";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbObs
            // 
            this.txbObs.BackColor = System.Drawing.Color.Black;
            this.txbObs.ForeColor = System.Drawing.Color.White;
            this.txbObs.Location = new System.Drawing.Point(12, 526);
            this.txbObs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbObs.Name = "txbObs";
            this.txbObs.Size = new System.Drawing.Size(839, 110);
            this.txbObs.TabIndex = 4;
            this.txbObs.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(33)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(173, 661);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(528, 78);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // generosTableAdapter
            // 
            this.generosTableAdapter.ClearBeforeFill = true;
            // 
            // editorasTableAdapter
            // 
            this.editorasTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(861, 750);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbObs);
            this.Controls.Add(this.txbSinopse);
            this.Controls.Add(this.boxEditora);
            this.Controls.Add(this.boxGenero);
            this.Controls.Add(this.numRegistro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbIsbn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbTitulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmAddLivros";
            this.Text = "Cadastrar Livros";
            this.Load += new System.EventHandler(this.FrmAddLivros_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numRegistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbIsbn;
        private System.Windows.Forms.ComboBox boxGenero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox boxEditora;
        private System.Windows.Forms.RichTextBox txbSinopse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txbObs;
        private System.Windows.Forms.Button button1;
        private SistemaBibliotecaDBDataSet sistemaBibliotecaDBDataSet;
        private System.Windows.Forms.BindingSource generosBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.GenerosTableAdapter generosTableAdapter;
        private System.Windows.Forms.BindingSource editorasBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.EditorasTableAdapter editorasTableAdapter;
    }
}