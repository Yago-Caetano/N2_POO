namespace N2_POO
{
    partial class fCadastrarDepartamento
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
            this.nupCodigo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nupCodigoGerente = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnCadastrarDepartamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCodigoGerente)).BeginInit();
            this.SuspendLayout();
            // 
            // nupCodigo
            // 
            this.nupCodigo.Location = new System.Drawing.Point(21, 31);
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
            this.nupCodigo.TabIndex = 4;
            this.nupCodigo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código:";
            // 
            // nupCodigoGerente
            // 
            this.nupCodigoGerente.Location = new System.Drawing.Point(21, 227);
            this.nupCodigoGerente.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupCodigoGerente.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupCodigoGerente.Name = "nupCodigoGerente";
            this.nupCodigoGerente.Size = new System.Drawing.Size(120, 20);
            this.nupCodigoGerente.TabIndex = 6;
            this.nupCodigoGerente.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Código Gerente :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(21, 79);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(289, 113);
            this.txtDescricao.TabIndex = 7;
            // 
            // btnCadastrarDepartamento
            // 
            this.btnCadastrarDepartamento.Location = new System.Drawing.Point(191, 211);
            this.btnCadastrarDepartamento.Name = "btnCadastrarDepartamento";
            this.btnCadastrarDepartamento.Size = new System.Drawing.Size(119, 49);
            this.btnCadastrarDepartamento.TabIndex = 9;
            this.btnCadastrarDepartamento.Text = "Cadastrar";
            this.btnCadastrarDepartamento.UseVisualStyleBackColor = true;
            this.btnCadastrarDepartamento.Click += new System.EventHandler(this.btnCadastrarDepartamento_Click);
            // 
            // fCadastrarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 296);
            this.Controls.Add(this.btnCadastrarDepartamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.nupCodigoGerente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nupCodigo);
            this.Controls.Add(this.label1);
            this.Name = "fCadastrarDepartamento";
            this.Text = "fCadastrarDepartamento";
            ((System.ComponentModel.ISupportInitialize)(this.nupCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCodigoGerente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nupCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupCodigoGerente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnCadastrarDepartamento;
    }
}