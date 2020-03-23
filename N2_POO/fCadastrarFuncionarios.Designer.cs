﻿namespace N2_POO
{
    partial class fCadastrarFuncionarios
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.nupCodigo = new System.Windows.Forms.NumericUpDown();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.nupSalario = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nupDepartamento = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSalario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(25, 76);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // nupCodigo
            // 
            this.nupCodigo.Location = new System.Drawing.Point(25, 25);
            this.nupCodigo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupCodigo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupCodigo.Name = "nupCodigo";
            this.nupCodigo.Size = new System.Drawing.Size(120, 20);
            this.nupCodigo.TabIndex = 2;
            this.nupCodigo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "F",
            "G"});
            this.cbTipo.Location = new System.Drawing.Point(198, 129);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 3;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(25, 129);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 20);
            this.txtCpf.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data De Nascimento:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(25, 180);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 8;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // nupSalario
            // 
            this.nupSalario.DecimalPlaces = 2;
            this.nupSalario.Location = new System.Drawing.Point(198, 25);
            this.nupSalario.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupSalario.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupSalario.Name = "nupSalario";
            this.nupSalario.Size = new System.Drawing.Size(120, 20);
            this.nupSalario.TabIndex = 11;
            this.nupSalario.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Salário:";
            // 
            // nupDepartamento
            // 
            this.nupDepartamento.Location = new System.Drawing.Point(198, 77);
            this.nupDepartamento.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupDepartamento.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupDepartamento.Name = "nupDepartamento";
            this.nupDepartamento.Size = new System.Drawing.Size(120, 20);
            this.nupDepartamento.TabIndex = 13;
            this.nupDepartamento.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Departamento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tipo";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(198, 180);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(112, 45);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // fCadastrarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 269);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nupDepartamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nupSalario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.nupCodigo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "fCadastrarFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fCadastrarFuncionarios";
            ((System.ComponentModel.ISupportInitialize)(this.nupCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSalario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.NumericUpDown nupCodigo;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.NumericUpDown nupSalario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nupDepartamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCadastrar;
    }
}