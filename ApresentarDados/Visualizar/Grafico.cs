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
        public List<Filmes> lsFilmow;
        public List<Filmes> lsAdoroCinema;
        
        public Grafico(List<Filmes> fl, List<Filmes> ad)
        {
            InitializeComponent();
            lsFilmow = new List<Filmes>();
            lsAdoroCinema = new List<Filmes>();

            lsFilmow = fl;
            lsAdoroCinema = ad;

            
        }

        private void btnGerarGrid_Click(object sender, EventArgs e)
        {
            
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


            MostrarGrafico(cmbValoresNotas.Text);


        }

        private void Grafico_Load(object sender, EventArgs e)
        {
            
        }

        public void MostrarGrafico(string qualValor)
        {
           
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

            chAdoro.Series[0].Points.Clear();


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


            gpFilmow = gpFilmow.OrderByDescending(c => c.Nota);
            gpAdoro = gpAdoro.OrderByDescending(c => c.Nota);

            foreach (var gpFl in gpFilmow)
            {
                if(gpFl.Nota >= valor1 && gpFl.Nota <= valor2)
                    chAdoro.Series[0].Points.AddXY(gpFl.Nota.ToString(), gpFl.Qtd);
            }


            chFilow.Series[0].Points.Clear();
            foreach (var gpAd in gpAdoro)
            {
                if (gpAd.Nota >= valor1 && gpAd.Nota <= valor2)
                    chFilow.Series[0].Points.AddXY(gpAd.Nota.ToString(), gpAd.Qtd);
            }

        }
    }
}
