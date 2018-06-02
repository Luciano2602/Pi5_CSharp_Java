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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chAdoro = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chFilow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGrafico = new System.Windows.Forms.ComboBox();
            this.btnGerarGrid = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbValoresNotas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chAdoro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chFilow)).BeginInit();
            this.SuspendLayout();
            // 
            // chAdoro
            // 
            chartArea1.Name = "ChartArea1";
            this.chAdoro.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chAdoro.Legends.Add(legend1);
            this.chAdoro.Location = new System.Drawing.Point(618, 71);
            this.chAdoro.Name = "chAdoro";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chAdoro.Series.Add(series1);
            this.chAdoro.Size = new System.Drawing.Size(600, 300);
            this.chAdoro.TabIndex = 0;
            this.chAdoro.Text = "chart1";
            // 
            // chFilow
            // 
            chartArea2.Name = "ChartArea1";
            this.chFilow.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chFilow.Legends.Add(legend2);
            this.chFilow.Location = new System.Drawing.Point(12, 71);
            this.chFilow.Name = "chFilow";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chFilow.Series.Add(series2);
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
            this.btnGerarGrid.Location = new System.Drawing.Point(567, 12);
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
            // Grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 480);
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
    }
}