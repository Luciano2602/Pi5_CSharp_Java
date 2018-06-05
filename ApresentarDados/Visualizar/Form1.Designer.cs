namespace Visualizar
{
    partial class Form1
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnTop10 = new System.Windows.Forms.Button();
            this.btnFilmesIguais = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdoroCinema = new System.Windows.Forms.TextBox();
            this.txtFilmon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAvaliadosAdoroCinema = new System.Windows.Forms.TextBox();
            this.txtAvalidosFilmow = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaiorNotaAdoroCinema = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaiorNotaFolmow = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvIgual = new System.Windows.Forms.DataGridView();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.txtVariancaAdoroFilme = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVariancaNotaFilmow = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDesvioAdoro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDesvioFilmow = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgual)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(33, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 52);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "BuscarTodos";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Location = new System.Drawing.Point(33, 112);
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.Size = new System.Drawing.Size(575, 155);
            this.dgvPrincipal.TabIndex = 1;
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(33, 321);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(575, 155);
            this.dgv2.TabIndex = 2;
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(158, 12);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(106, 52);
            this.btnMedia.TabIndex = 3;
            this.btnMedia.Text = "Média das notas";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnTop10
            // 
            this.btnTop10.Location = new System.Drawing.Point(293, 12);
            this.btnTop10.Name = "btnTop10";
            this.btnTop10.Size = new System.Drawing.Size(106, 52);
            this.btnTop10.TabIndex = 4;
            this.btnTop10.Text = "TOP 10";
            this.btnTop10.UseVisualStyleBackColor = true;
            this.btnTop10.Click += new System.EventHandler(this.btnTop10_Click);
            // 
            // btnFilmesIguais
            // 
            this.btnFilmesIguais.Location = new System.Drawing.Point(422, 12);
            this.btnFilmesIguais.Name = "btnFilmesIguais";
            this.btnFilmesIguais.Size = new System.Drawing.Size(106, 52);
            this.btnFilmesIguais.TabIndex = 5;
            this.btnFilmesIguais.Text = "Filmes Iguais e Notas";
            this.btnFilmesIguais.UseVisualStyleBackColor = true;
            this.btnFilmesIguais.Click += new System.EventHandler(this.btnFilmesIguais_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adoro Cinema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filmow";
            // 
            // txtAdoroCinema
            // 
            this.txtAdoroCinema.Location = new System.Drawing.Point(628, 129);
            this.txtAdoroCinema.Name = "txtAdoroCinema";
            this.txtAdoroCinema.Size = new System.Drawing.Size(100, 20);
            this.txtAdoroCinema.TabIndex = 8;
            // 
            // txtFilmon
            // 
            this.txtFilmon.Location = new System.Drawing.Point(628, 337);
            this.txtFilmon.Name = "txtFilmon";
            this.txtFilmon.Size = new System.Drawing.Size(100, 20);
            this.txtFilmon.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Média Geral";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Média Geral";
            // 
            // txtAvaliadosAdoroCinema
            // 
            this.txtAvaliadosAdoroCinema.Location = new System.Drawing.Point(628, 191);
            this.txtAvaliadosAdoroCinema.Name = "txtAvaliadosAdoroCinema";
            this.txtAvaliadosAdoroCinema.Size = new System.Drawing.Size(100, 20);
            this.txtAvaliadosAdoroCinema.TabIndex = 12;
            // 
            // txtAvalidosFilmow
            // 
            this.txtAvalidosFilmow.Location = new System.Drawing.Point(628, 399);
            this.txtAvalidosFilmow.Name = "txtAvalidosFilmow";
            this.txtAvalidosFilmow.Size = new System.Drawing.Size(100, 20);
            this.txtAvalidosFilmow.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(625, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Média dos Avaliados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(625, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Média dos Avaliados";
            // 
            // txtMaiorNotaAdoroCinema
            // 
            this.txtMaiorNotaAdoroCinema.Location = new System.Drawing.Point(752, 129);
            this.txtMaiorNotaAdoroCinema.Name = "txtMaiorNotaAdoroCinema";
            this.txtMaiorNotaAdoroCinema.Size = new System.Drawing.Size(100, 20);
            this.txtMaiorNotaAdoroCinema.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(749, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Maior Nota";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(749, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Maior Nota";
            // 
            // txtMaiorNotaFolmow
            // 
            this.txtMaiorNotaFolmow.Location = new System.Drawing.Point(752, 337);
            this.txtMaiorNotaFolmow.Name = "txtMaiorNotaFolmow";
            this.txtMaiorNotaFolmow.Size = new System.Drawing.Size(100, 20);
            this.txtMaiorNotaFolmow.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 544);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Filmes Iguais";
            // 
            // dgvIgual
            // 
            this.dgvIgual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIgual.Location = new System.Drawing.Point(33, 560);
            this.dgvIgual.Name = "dgvIgual";
            this.dgvIgual.Size = new System.Drawing.Size(575, 154);
            this.dgvIgual.TabIndex = 22;
            // 
            // btnGrafico
            // 
            this.btnGrafico.Location = new System.Drawing.Point(562, 12);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(106, 52);
            this.btnGrafico.TabIndex = 23;
            this.btnGrafico.Text = "Gráfico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // txtVariancaAdoroFilme
            // 
            this.txtVariancaAdoroFilme.Location = new System.Drawing.Point(752, 191);
            this.txtVariancaAdoroFilme.Name = "txtVariancaAdoroFilme";
            this.txtVariancaAdoroFilme.Size = new System.Drawing.Size(100, 20);
            this.txtVariancaAdoroFilme.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(749, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Variância";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(749, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Variância";
            // 
            // txtVariancaNotaFilmow
            // 
            this.txtVariancaNotaFilmow.Location = new System.Drawing.Point(752, 399);
            this.txtVariancaNotaFilmow.Name = "txtVariancaNotaFilmow";
            this.txtVariancaNotaFilmow.Size = new System.Drawing.Size(100, 20);
            this.txtVariancaNotaFilmow.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(625, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Desvio";
            // 
            // txtDesvioAdoro
            // 
            this.txtDesvioAdoro.Location = new System.Drawing.Point(628, 247);
            this.txtDesvioAdoro.Name = "txtDesvioAdoro";
            this.txtDesvioAdoro.Size = new System.Drawing.Size(100, 20);
            this.txtDesvioAdoro.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(625, 440);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Desvio";
            // 
            // txtDesvioFilmow
            // 
            this.txtDesvioFilmow.Location = new System.Drawing.Point(628, 456);
            this.txtDesvioFilmow.Name = "txtDesvioFilmow";
            this.txtDesvioFilmow.Size = new System.Drawing.Size(100, 20);
            this.txtDesvioFilmow.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 749);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDesvioFilmow);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDesvioAdoro);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtVariancaNotaFilmow);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtVariancaAdoroFilme);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.dgvIgual);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaiorNotaFolmow);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaiorNotaAdoroCinema);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAvalidosFilmow);
            this.Controls.Add(this.txtAvaliadosAdoroCinema);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilmon);
            this.Controls.Add(this.txtAdoroCinema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFilmesIguais);
            this.Controls.Add(this.btnTop10);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.dgvPrincipal);
            this.Controls.Add(this.btnBuscar);
            this.Name = "Form1";
            this.Text = "PI-5";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnTop10;
        private System.Windows.Forms.Button btnFilmesIguais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdoroCinema;
        private System.Windows.Forms.TextBox txtFilmon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAvaliadosAdoroCinema;
        private System.Windows.Forms.TextBox txtAvalidosFilmow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaiorNotaAdoroCinema;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaiorNotaFolmow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvIgual;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.TextBox txtVariancaAdoroFilme;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtVariancaNotaFilmow;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDesvioAdoro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDesvioFilmow;
    }
}

