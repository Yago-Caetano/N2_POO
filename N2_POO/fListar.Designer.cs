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
            this.btnListar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnListarDepartamento = new System.Windows.Forms.Button();
            this.nupCodigoDepartamento = new System.Windows.Forms.NumericUpDown();
            this.nupeCodGerente = new System.Windows.Forms.NumericUpDown();
            this.btnCodGerente = new System.Windows.Forms.Button();
            this.btnListarGerentes = new System.Windows.Forms.Button();
            this.rtxtdados = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nupMes = new System.Windows.Forms.NumericUpDown();
            this.btnListarTotal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nupCodigoDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupeCodGerente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.FlatAppearance.BorderSize = 0;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.Color.Yellow;
            this.btnListar.Location = new System.Drawing.Point(0, 0);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(192, 80);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listagem Geral:";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Blue;
            this.btnLimpar.Location = new System.Drawing.Point(194, 392);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(366, 59);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnListarDepartamento
            // 
            this.btnListarDepartamento.FlatAppearance.BorderSize = 0;
            this.btnListarDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarDepartamento.ForeColor = System.Drawing.Color.Yellow;
            this.btnListarDepartamento.Location = new System.Drawing.Point(0, 74);
            this.btnListarDepartamento.Name = "btnListarDepartamento";
            this.btnListarDepartamento.Size = new System.Drawing.Size(192, 80);
            this.btnListarDepartamento.TabIndex = 5;
            this.btnListarDepartamento.Text = "Listagem Por Departamento:";
            this.btnListarDepartamento.UseVisualStyleBackColor = true;
            this.btnListarDepartamento.Click += new System.EventHandler(this.btnListarDepartamento_Click);
            // 
            // nupCodigoDepartamento
            // 
            this.nupCodigoDepartamento.Location = new System.Drawing.Point(6, 107);
            this.nupCodigoDepartamento.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupCodigoDepartamento.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupCodigoDepartamento.Name = "nupCodigoDepartamento";
            this.nupCodigoDepartamento.Size = new System.Drawing.Size(120, 20);
            this.nupCodigoDepartamento.TabIndex = 6;
            this.nupCodigoDepartamento.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupeCodGerente
            // 
            this.nupeCodGerente.Location = new System.Drawing.Point(6, 183);
            this.nupeCodGerente.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupeCodGerente.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupeCodGerente.Name = "nupeCodGerente";
            this.nupeCodGerente.Size = new System.Drawing.Size(120, 20);
            this.nupeCodGerente.TabIndex = 10;
            this.nupeCodGerente.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCodGerente
            // 
            this.btnCodGerente.FlatAppearance.BorderSize = 0;
            this.btnCodGerente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCodGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodGerente.ForeColor = System.Drawing.Color.Yellow;
            this.btnCodGerente.Location = new System.Drawing.Point(0, 150);
            this.btnCodGerente.Name = "btnCodGerente";
            this.btnCodGerente.Size = new System.Drawing.Size(192, 80);
            this.btnCodGerente.TabIndex = 9;
            this.btnCodGerente.Text = "Listagem Por Gerente:";
            this.btnCodGerente.UseVisualStyleBackColor = true;
            this.btnCodGerente.Click += new System.EventHandler(this.btnCodGerente_Click);
            // 
            // btnListarGerentes
            // 
            this.btnListarGerentes.FlatAppearance.BorderSize = 0;
            this.btnListarGerentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarGerentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarGerentes.ForeColor = System.Drawing.Color.Yellow;
            this.btnListarGerentes.Location = new System.Drawing.Point(0, 223);
            this.btnListarGerentes.Name = "btnListarGerentes";
            this.btnListarGerentes.Size = new System.Drawing.Size(192, 80);
            this.btnListarGerentes.TabIndex = 13;
            this.btnListarGerentes.Text = "Listagem Gerentes";
            this.btnListarGerentes.UseVisualStyleBackColor = true;
            this.btnListarGerentes.Click += new System.EventHandler(this.btnListarGerentes_Click);
            // 
            // rtxtdados
            // 
            this.rtxtdados.Location = new System.Drawing.Point(194, 10);
            this.rtxtdados.Name = "rtxtdados";
            this.rtxtdados.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtxtdados.Size = new System.Drawing.Size(365, 381);
            this.rtxtdados.TabIndex = 14;
            this.rtxtdados.Text = "";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(0, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 80);
            this.button1.TabIndex = 16;
            this.button1.Text = "Listagem por mês";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nupMes
            // 
            this.nupMes.Location = new System.Drawing.Point(6, 329);
            this.nupMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nupMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupMes.Name = "nupMes";
            this.nupMes.Size = new System.Drawing.Size(120, 20);
            this.nupMes.TabIndex = 20;
            this.nupMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnListarTotal
            // 
            this.btnListarTotal.FlatAppearance.BorderSize = 0;
            this.btnListarTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTotal.ForeColor = System.Drawing.Color.Yellow;
            this.btnListarTotal.Location = new System.Drawing.Point(0, 375);
            this.btnListarTotal.Name = "btnListarTotal";
            this.btnListarTotal.Size = new System.Drawing.Size(192, 80);
            this.btnListarTotal.TabIndex = 21;
            this.btnListarTotal.Text = "Listagem Total";
            this.btnListarTotal.UseVisualStyleBackColor = true;
            this.btnListarTotal.Click += new System.EventHandler(this.btnListarTotal_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.btnListarTotal);
            this.panel1.Controls.Add(this.btnListar);
            this.panel1.Controls.Add(this.btnListarDepartamento);
            this.panel1.Controls.Add(this.btnCodGerente);
            this.panel1.Controls.Add(this.btnListarGerentes);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 458);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.rtxtdados);
            this.panel2.Controls.Add(this.nupCodigoDepartamento);
            this.panel2.Controls.Add(this.btnLimpar);
            this.panel2.Controls.Add(this.nupMes);
            this.panel2.Controls.Add(this.nupeCodGerente);
            this.panel2.Location = new System.Drawing.Point(193, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 455);
            this.panel2.TabIndex = 23;
            // 
            // fListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar";
            this.Load += new System.EventHandler(this.fListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupCodigoDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupeCodGerente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnListarDepartamento;
        private System.Windows.Forms.NumericUpDown nupCodigoDepartamento;
        private System.Windows.Forms.NumericUpDown nupeCodGerente;
        private System.Windows.Forms.Button btnCodGerente;
        private System.Windows.Forms.Button btnListarGerentes;
        private System.Windows.Forms.RichTextBox rtxtdados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nupMes;
        private System.Windows.Forms.Button btnListarTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}