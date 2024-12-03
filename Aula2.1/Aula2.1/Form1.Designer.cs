namespace Aula2._1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Titulo = new System.Windows.Forms.TextBox();
            this.textBox_Genero = new System.Windows.Forms.TextBox();
            this.textBox_Ano = new System.Windows.Forms.TextBox();
            this.textBox_Avaliacao = new System.Windows.Forms.TextBox();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.label_Avaliacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE FILMES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Título";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gênero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ano";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Avaliação";
            // 
            // textBox_Titulo
            // 
            this.textBox_Titulo.Location = new System.Drawing.Point(237, 91);
            this.textBox_Titulo.Name = "textBox_Titulo";
            this.textBox_Titulo.Size = new System.Drawing.Size(237, 20);
            this.textBox_Titulo.TabIndex = 1;
            this.textBox_Titulo.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox_Genero
            // 
            this.textBox_Genero.Location = new System.Drawing.Point(237, 127);
            this.textBox_Genero.Name = "textBox_Genero";
            this.textBox_Genero.Size = new System.Drawing.Size(237, 20);
            this.textBox_Genero.TabIndex = 2;
            // 
            // textBox_Ano
            // 
            this.textBox_Ano.Location = new System.Drawing.Point(237, 163);
            this.textBox_Ano.Name = "textBox_Ano";
            this.textBox_Ano.Size = new System.Drawing.Size(237, 20);
            this.textBox_Ano.TabIndex = 3;
            // 
            // textBox_Avaliacao
            // 
            this.textBox_Avaliacao.Location = new System.Drawing.Point(237, 198);
            this.textBox_Avaliacao.Name = "textBox_Avaliacao";
            this.textBox_Avaliacao.Size = new System.Drawing.Size(237, 20);
            this.textBox_Avaliacao.TabIndex = 4;
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.Location = new System.Drawing.Point(271, 241);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.button_cadastrar.TabIndex = 6;
            this.button_cadastrar.Text = "Cadastrar";
            this.button_cadastrar.UseVisualStyleBackColor = true;
            this.button_cadastrar.Click += new System.EventHandler(this.button_cadastrar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(352, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Location = new System.Drawing.Point(530, 354);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(0, 13);
            this.label_Titulo.TabIndex = 8;
            // 
            // label_Avaliacao
            // 
            this.label_Avaliacao.AutoSize = true;
            this.label_Avaliacao.Location = new System.Drawing.Point(530, 386);
            this.label_Avaliacao.Name = "label_Avaliacao";
            this.label_Avaliacao.Size = new System.Drawing.Size(0, 13);
            this.label_Avaliacao.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Avaliacao);
            this.Controls.Add(this.label_Titulo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_cadastrar);
            this.Controls.Add(this.textBox_Avaliacao);
            this.Controls.Add(this.textBox_Ano);
            this.Controls.Add(this.textBox_Genero);
            this.Controls.Add(this.textBox_Titulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Aula2.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Titulo;
        private System.Windows.Forms.TextBox textBox_Genero;
        private System.Windows.Forms.TextBox textBox_Ano;
        private System.Windows.Forms.TextBox textBox_Avaliacao;
        private System.Windows.Forms.Button button_cadastrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.Label label_Avaliacao;
    }
}

