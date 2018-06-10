using ApresentarDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Visualizar
{
    public partial class Grafico : Form
    {
        //essas listas serão carregadas quando o a tela for chamada
        public List<Filmes> lsFilmow;
        public List<Filmes> lsAdoroCinema;
        
        public Grafico(List<Filmes> fl, List<Filmes> ad)
        {

            InitializeComponent();
            //carregando a lista que vieram da tela principal
            lsFilmow = new List<Filmes>();
            lsAdoroCinema = new List<Filmes>();

            lsFilmow = fl;
            lsAdoroCinema = ad;

            
        }

        private void btnGerarGrid_Click(object sender, EventArgs e)
        {
            //caso passando para chart o tipo de gráfico que será gerado
            string nomeGrafico = cmbGrafico.Text;

            switch (nomeGrafico)
            {
                case "Pizza":
                    chAdoro.Series[0].ChartType = SeriesChartType.Pie;
                    chFilow.Series[0].ChartType = SeriesChartType.Pie;
                    break;

                case "Colunas":
                    chAdoro.Series[0].ChartType = SeriesChartType.Column;
                    chFilow.Series[0].ChartType = SeriesChartType.Column;
                    break;

                case "Circulo":
                    chAdoro.Series[0].ChartType = SeriesChartType.Doughnut;
                    chFilow.Series[0].ChartType = SeriesChartType.Doughnut;
                    break;
                default:
                    chAdoro.Series[0].ChartType = SeriesChartType.Pie;
                    chFilow.Series[0].ChartType = SeriesChartType.Pie;
                    break;
            }

            //funcao para carregar o chart, no caso dessa funcao o default é de 0 a 5
            MostrarGrafico(cmbValoresNotas.Text);

            if(txtValor2.Text != "" && txtValor1.Text !="") 
                MostrarGraficoComTxt(Double.Parse(txtValor1.Text), Double.Parse(txtValor2.Text));


        }

        private void Grafico_Load(object sender, EventArgs e)
        {
            
        }

        public void MostrarGraficoComTxt(Double num1, Double num2)
        {
            LimparChart();
            //agrupando os valores , estamos juntando as notas e contando 
            var gpFilmow = from item in lsFilmow
                           group item by item.nota into agru
                           select new
                           {
                               Nota = agru.Key,
                               Qtd = agru.Count()
                           };


            var gpAdoro = from item in lsAdoroCinema
                          group item by item.nota into agru
                          select new
                          {
                              Nota = agru.Key,
                              Qtd = agru.Count()
                          };

            //ordenando as notas, para poder mostrar no gráfico
            gpFilmow = gpFilmow.OrderByDescending(c => c.Nota);
            gpAdoro = gpAdoro.OrderByDescending(c => c.Nota);

            //percorrendo a lista gerada, e adicionando no x e y do gráfico somente os valores passados pelo combobox
            foreach (var gpFl in gpFilmow)
            {
                if (gpFl.Nota >= num1 && gpFl.Nota <= num2)
                    chAdoro.Series[0].Points.AddXY(gpFl.Nota, gpFl.Qtd);
            }


            foreach (var gpAd in gpAdoro)
            {
                if (gpAd.Nota >= num1 && gpAd.Nota <= num2)
                    chFilow.Series[0].Points.AddXY(gpAd.Nota, gpAd.Qtd);
            }

        }

        public void LimparChart()
        {
            //limpando o chart
            chAdoro.Series[0].Points.Clear();
            chFilow.Series[0].Points.Clear();
        }

        public void MostrarGrafico(string qualValor)
        {
            LimparChart();

            //para variaveis criadas para poder fazer o intervalo
            double valor1 = 0, valor2 = 0;
            #region switch
            switch (qualValor)
            {
                case "De 0 a 1":
                    valor1 = 0;
                    valor2 = 1;
                    break;

                case "De 1 a 2":
                    valor1 = 1;
                    valor2 = 2;
                    break;

                case "De 2 a 3":
                    valor1 = 2;
                    valor2 = 3;
                    break;

                case "De 3 a 4":
                    valor1 = 3;
                    valor2 = 4;
                    break;

                case "De 4 a 5":
                    valor1 = 4;
                    valor2 = 5;
                    break;

                case "Todas":
                    valor1 = 0;
                    valor2 = 5;
                    break;
                default:
                    valor1 = 0;
                    valor2 = 5;
                    break;
            }
            #endregion

            MostrarGraficoComTxt(valor1, valor2);

        }

        private void txtValor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esse campo so aceita numero e virgula
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
            }
            
        }

        private void txtValor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esse campo so aceita numero e virgula
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
            }
            
        }
    }
}
