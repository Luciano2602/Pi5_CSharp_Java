namespace Visualizar
{
    partial class Grafico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chAdoro = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chFilow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGrafico = new System.Windows.Forms.ComboBox();
            this.btnGerarGrid = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbValoresNotas = new System.Windows.Forms.ComboBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chAdoro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFilow)).BeginInit();
            this.SuspendLayout();
            // 
            // chAdoro
            // 
            chartArea9.Name = "ChartArea1";
            this.chAdoro.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chAdoro.Legends.Add(legend9);
            this.chAdoro.Location = new System.Drawing.Point(618, 71);
            this.chAdoro.Name = "chAdoro";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chAdoro.Series.Add(series9);
            this.chAdoro.Size = new System.Drawing.Size(600, 300);
            this.chAdoro.TabIndex = 0;
            this.chAdoro.Text = "chart1";
            // 
            // chFilow
            // 
            chartArea10.Name = "ChartArea1";
            this.chFilow.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chFilow.Legends.Add(legend10);
            this.chFilow.Location = new System.Drawing.Point(12, 71);
            this.chFilow.Name = "chFilow";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chFilow.Series.Add(series10);
            this.chFilow.Size = new System.Drawing.Size(600, 300);
            this.chFilow.TabIndex = 1;
            this.chFilow.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gaficos";
            // 
            // cmbGrafico
            // 
            this.cmbGrafico.FormattingEnabled = true;
            this.cmbGrafico.Items.AddRange(new object[] {
            "Pizza",
            "Colunas",
            "Circulo"});
            this.cmbGrafico.Location = new System.Drawing.Point(61, 12);
            this.cmbGrafico.Name = "cmbGrafico";
            this.cmbGrafico.Size = new System.Drawing.Size(142, 21);
            this.cmbGrafico.TabIndex = 3;
            // 
            // btnGerarGrid
            // 
            this.btnGerarGrid.Location = new System.Drawing.Point(777, 7);
            this.btnGerarGrid.Name = "btnGerarGrid";
            this.btnGerarGrid.Size = new System.Drawing.Size(75, 23);
            this.btnGerarGrid.TabIndex = 4;
            this.btnGerarGrid.Text = "Pesquisar";
            this.btnGerarGrid.UseVisualStyleBackColor = true;
            this.btnGerarGrid.Click += new System.EventHandler(this.btnGerarGrid_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filow";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adoro Cinema";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Notas";
            // 
            // cmbValoresNotas
            // 
            this.cmbValoresNotas.FormattingEnabled = true;
            this.cmbValoresNotas.Items.AddRange(new object[] {
            "Todas",
            "De 0 a 1",
            "De 1 a 2",
            "De 2 a 3",
            "De 3 a 4",
            "De 4 a 5"});
            this.cmbValoresNotas.Location = new System.Drawing.Point(301, 9);
            this.cmbValoresNotas.Name = "cmbValoresNotas";
            this.cmbValoresNotas.Size = new System.Drawing.Size(142, 21);
            this.cmbValoresNotas.TabIndex = 8;
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(532, 6);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(53, 20);
            this.txtValor1.TabIndex = 9;
            this.txtValor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor1_KeyPress);
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(532, 32);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(53, 20);
            this.txtValor2.TabIndex = 10;
            this.txtValor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor2_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ou escolha ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "o intervalo";
            // 
            // Grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 480);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.cmbValoresNotas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGerarGrid);
            this.Controls.Add(this.cmbGrafico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chFilow);
            this.Controls.Add(this.chAdoro);
            this.Name = "Grafico";
            this.Text = "Grafico";
            this.Load += new System.EventHandler(this.Grafico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chAdoro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFilow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chAdoro;
        private System.Windows.Forms.DataVisualization.Charting.Chart chFilow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGrafico;
        private System.Windows.Forms.Button btnGerarGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbValoresNotas;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}