namespace N2_POO
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAumento = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCadastrarDepartamento = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAumento
            // 
            this.btnAumento.FlatAppearance.BorderSize = 0;
            this.btnAumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumento.ForeColor = System.Drawing.Color.Yellow;
            this.btnAumento.Location = new System.Drawing.Point(392, 3);
            this.btnAumento.Name = "btnAumento";
            this.btnAumento.Size = new System.Drawing.Size(190, 97);
            this.btnAumento.TabIndex = 5;
            this.btnAumento.Text = "Dar Aumento:";
            this.btnAumento.UseVisualStyleBackColor = true;
            this.btnAumento.Click += new System.EventHandler(this.btnAumento_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(578, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 97);
            this.button1.TabIndex = 7;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadastrarDepartamento
            // 
            this.btnCadastrarDepartamento.FlatAppearance.BorderSize = 0;
            this.btnCadastrarDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarDepartamento.ForeColor = System.Drawing.Color.Yellow;
            this.btnCadastrarDepartamento.Location = new System.Drawing.Point(205, 3);
            this.btnCadastrarDepartamento.Name = "btnCadastrarDepartamento";
            this.btnCadastrarDepartamento.Size = new System.Drawing.Size(190, 97);
            this.btnCadastrarDepartamento.TabIndex = 3;
            this.btnCadastrarDepartamento.Text = "Cadastrar Departamento:";
            this.btnCadastrarDepartamento.UseVisualStyleBackColor = true;
            this.btnCadastrarDepartamento.Click += new System.EventHandler(this.btnCadastrarDepartamento_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Yellow;
            this.btnCadastrar.Location = new System.Drawing.Point(0, 0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(199, 100);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar Funcionários:";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.btnCadastrarDepartamento);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAumento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 100);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 47);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "N2 POO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lucas Santos Costa - 081190015";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Yago José Barros - 0811900";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Guilherme Tavares - 0811900";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Roger - 0811900";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(244, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Rodrigo Emiliano - 0811900";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 383);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAumento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCadastrarDepartamento;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

