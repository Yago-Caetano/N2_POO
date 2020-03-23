namespace N2_POO
{
    partial class fListar
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
            this.btnListar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnListarDepartamento = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nupCodigoDepartamento = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nupeCodGerente = new System.Windows.Forms.NumericUpDown();
            this.btnCodGerente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnListarGerentes = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rtxtdados = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupCodigoDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupeCodGerente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listagem Geral:";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(63, 30);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(79, 39);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Geral";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(506, 401);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(76, 37);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnListarDepartamento
            // 
            this.btnListarDepartamento.Location = new System.Drawing.Point(64, 133);
            this.btnListarDepartamento.Name = "btnListarDepartamento";
            this.btnListarDepartamento.Size = new System.Drawing.Size(89, 42);
            this.btnListarDepartamento.TabIndex = 5;
            this.btnListarDepartamento.Text = "Departamento";
            this.btnListarDepartamento.UseVisualStyleBackColor = true;
            this.btnListarDepartamento.Click += new System.EventHandler(this.btnListarDepartamento_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Listagem Por Departamento:";
            // 
            // nupCodigoDepartamento
            // 
            this.nupCodigoDepartamento.Location = new System.Drawing.Point(144, 107);
            this.nupCodigoDepartamento.Name = "nupCodigoDepartamento";
            this.nupCodigoDepartamento.Size = new System.Drawing.Size(120, 20);
            this.nupCodigoDepartamento.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Código do departamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Código do Gerente:";
            // 
            // nupeCodGerente
            // 
            this.nupeCodGerente.Location = new System.Drawing.Point(143, 219);
            this.nupeCodGerente.Name = "nupeCodGerente";
            this.nupeCodGerente.Size = new System.Drawing.Size(120, 20);
            this.nupeCodGerente.TabIndex = 10;
            // 
            // btnCodGerente
            // 
            this.btnCodGerente.Location = new System.Drawing.Point(63, 249);
            this.btnCodGerente.Name = "btnCodGerente";
            this.btnCodGerente.Size = new System.Drawing.Size(89, 42);
            this.btnCodGerente.TabIndex = 9;
            this.btnCodGerente.Text = "Gerente";
            this.btnCodGerente.UseVisualStyleBackColor = true;
            this.btnCodGerente.Click += new System.EventHandler(this.btnCodGerente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Listagem Por Gerente:";
            // 
            // btnListarGerentes
            // 
            this.btnListarGerentes.Location = new System.Drawing.Point(63, 320);
            this.btnListarGerentes.Name = "btnListarGerentes";
            this.btnListarGerentes.Size = new System.Drawing.Size(89, 42);
            this.btnListarGerentes.TabIndex = 13;
            this.btnListarGerentes.Text = "Listar";
            this.btnListarGerentes.UseVisualStyleBackColor = true;
            this.btnListarGerentes.Click += new System.EventHandler(this.btnListarGerentes_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Listagem Gerentes:";
            // 
            // rtxtdados
            // 
            this.rtxtdados.Location = new System.Drawing.Point(453, 11);
            this.rtxtdados.Name = "rtxtdados";
            this.rtxtdados.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtxtdados.Size = new System.Drawing.Size(325, 381);
            this.rtxtdados.TabIndex = 14;
            this.rtxtdados.Text = "";
            // 
            // fListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxtdados);
            this.Controls.Add(this.btnListarGerentes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nupeCodGerente);
            this.Controls.Add(this.btnCodGerente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nupCodigoDepartamento);
            this.Controls.Add(this.btnListarDepartamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.label1);
            this.Name = "fListar";
            this.Text = "fListar";
            ((System.ComponentModel.ISupportInitialize)(this.nupCodigoDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupeCodGerente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnListarDepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupCodigoDepartamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupeCodGerente;
        private System.Windows.Forms.Button btnCodGerente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnListarGerentes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtxtdados;
    }
}