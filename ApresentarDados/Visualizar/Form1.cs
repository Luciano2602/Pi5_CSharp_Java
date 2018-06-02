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

namespace Visualizar
{
    public partial class Form1 : Form
    {
        public List<Filmes> lsFilmow;
        public List<Filmes> lsAdoroCinema;
        public Form1()
        {
            InitializeComponent();
        }

        
        public void AtualizarGrid()
        {
            dgv2.DataSource = null;
            dgvPrincipal.DataSource = null;

            dgvPrincipal.Refresh();
            dgv2.Refresh();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                AtualizarGrid();
                dgv2.DataSource = lsFilmow;
                dgvPrincipal.DataSource = lsAdoroCinema;



            }
            catch (Exception erro)
            {
                
                MessageBox.Show("Erro: " + erro.Message);
                
            }

            
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            try
            {
                
                double mediaFolmow = 0;
                double mediaAdoroCinema = 0;

                double mediaFolmowAvaliado = 0;
                double mediaAdoroCinAvaliado = 0;

                int i = 0;
                int j = 0;
                int k = 0;
                int m = 0;

                foreach (var item in lsFilmow)
                {
                    i++;
                    mediaFolmow += item.nota;

                    if(item.nota > 0)
                    {
                        mediaFolmowAvaliado += item.nota;
                        k++;
                    }


                }

                foreach (var item in lsAdoroCinema)
                {
                    j++;
                    mediaAdoroCinema += item.nota;

                    if (item.nota > 0)
                    {
                        mediaAdoroCinAvaliado += item.nota;
                        m++;
                    }
                }

                mediaFolmow /= i;
                mediaAdoroCinema /= j;

                mediaAdoroCinAvaliado /= m;
                mediaFolmowAvaliado /= k;

                txtAdoroCinema.Text = mediaAdoroCinema.ToString().Substring(0,4);
                txtFilmon.Text = mediaFolmow.ToString().Substring(0, 4);

                txtAvaliadosAdoroCinema.Text = mediaAdoroCinAvaliado.ToString().Substring(0, 4);
                txtAvalidosFilmow.Text = mediaFolmowAvaliado.ToString().Substring(0, 4);

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro: " + erro.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LivrosNovos livroNovo = new LivrosNovos();

            var ln = livroNovo.GetFilmes();


            int idSite1 = 0;
            int idSite2 = 0;


            lsFilmow = new List<Filmes>();
            lsAdoroCinema = new List<Filmes>();

            foreach (var item in ln)
            {
                Filmes f = new Filmes();
                if (item.site == "filmow.com")
                {
                    idSite1++;

                    if (item.nota.ToUpper() == "VAZIO")
                        item.nota = "0";

                    f.id = idSite1;
                    f.comentario = item.comentario.Replace(",", "").Replace("K", "00");
                    f.nota = Convert.ToDouble(item.nota.Replace(".", ","));
                    //f.nota = item.nota;
                    f.titulo = item.titulo;
                    f.site = "filmow".ToUpper();
                    lsFilmow.Add(f);
                }
                else
                {
                    idSite2++;

                    if (item.nota.ToUpper() == "VAZIO")
                        item.nota = "0";

                    f.id = idSite2;
                    f.nota = Convert.ToDouble(item.nota.Replace(".", ","));
                    //f.nota = item.nota;
                    f.titulo = item.titulo;
                    f.site = "adoro cinema".ToUpper();
                    lsAdoroCinema.Add(f);
                }
            }
        }

        private void btnTop10_Click(object sender, EventArgs e)
        {

            try
            {
                AtualizarGrid();

                List<Filmes> lsAdoroCinemaTop10 = new List<Filmes>();
                List<Filmes> lsFilmowTop10 = new List<Filmes>();

                double maiorNotaAdoro = 0;
                double maiorNotaFilmow = 0;


                foreach (var item in lsAdoroCinema)
                {
                    if (item.nota > maiorNotaAdoro)
                        maiorNotaAdoro = item.nota;
                }

                foreach (var item in lsFilmow)
                {
                    if (item.nota > maiorNotaFilmow)
                        maiorNotaFilmow = item.nota;
                }


                
                lsAdoroCinemaTop10 = lsAdoroCinema.OrderByDescending(ac => ac.nota).ToList();
                lsFilmowTop10 = lsFilmow.OrderByDescending(ac => ac.nota).ToList();

                var lsSite1 = new List<Filmes>();
                var lsSite2 = new List<Filmes>();

                
                for (int i = 0; i < 10; i++)
                {
                    lsSite1.Add(lsAdoroCinemaTop10[i]);
                }

                for (int i = 0; i < 10; i++)
                {
                    lsSite2.Add(lsFilmowTop10[i]);
                }



                txtMaiorNotaAdoroCinema.Text = maiorNotaAdoro.ToString();
                txtMaiorNotaFolmow.Text = maiorNotaFilmow.ToString();

                dgvPrincipal.DataSource = lsSite1;
                dgv2.DataSource = lsSite2;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro: " + erro.Message);
            }

            

        }

        private void btnFilmesIguais_Click(object sender, EventArgs e)
        {
            try
            {

                btnFilmesIguais.Enabled = false;
                DateTime comecou = DateTime.Now;
                                
                dgvIgual.Refresh();
                dgvIgual.DataSource = null;
                List<Filmes> lsFilmesIguais = new List<Filmes>();

                //bool achou = false;
               // MessageBox.Show("Filmou " + lsFilmow.Count + " " + lsAdoroCinema[0].titulo + " Adoro " + lsAdoroCinema.Count + " " + lsAdoroCinema[0].titulo);
                
                for (int i = 0; i < lsFilmow.Count; i++)
                {
                    for (int j = 0; j < lsAdoroCinema.Count; j++)
                    {
                        if (lsFilmow[i].titulo.ToUpper() == lsAdoroCinema[j].titulo.ToUpper()  )
                        {
                            lsFilmesIguais.Add(lsAdoroCinema[j]);                            
                            j = lsAdoroCinema.Count;
                        }

                       
                    }
                    
                    
                    
                }

                DateTime terminou = DateTime.Now;
                

                MessageBox.Show("Comecou " + comecou.ToString() + " Terminou " + terminou.ToString() + " Foram incontrados " + lsFilmesIguais.Count + " filmes iguais");

                dgvIgual.DataSource = lsFilmesIguais;

                btnFilmesIguais.Enabled = true;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro: " + erro.Message);
            }

            
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            Grafico g = new Grafico(lsFilmow, lsAdoroCinema);
            g.Show();
        }
    }
}
