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
        //variaveis com o as listas dos filmes
        public List<Filmes> lsFilmow;
        public List<Filmes> lsAdoroCinema;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            i = 0;
        }

        
        public void AtualizarGrid()
        {
            //adicinando o null, pq se tiver alguma coisa no grid, ele é limpado
            dgv2.DataSource = null;
            dgvPrincipal.DataSource = null;

            //atualizando o gride
            dgvPrincipal.Refresh();
            dgv2.Refresh();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // no load da página está carregado as listas
                //limpando o grid
                AtualizarGrid();
                //adicionando ao grid nossa lista
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
                //variaveis usadas para cálculo da média
                double mediaFolmow = 0;
                double mediaAdoroCinema = 0;

                double mediaFolmowAvaliado = 0;
                double mediaAdoroCinAvaliado = 0;

                //essas variaveis serão usadas para "contar a qtd de livros", sendo assim dividindo 
                int i = 0;
                int j = 0;
                int k = 0;
                int m = 0;

                foreach (var item in lsFilmow)
                {
                    //pegando a média de todas as notas
                    i++;
                    mediaFolmow += item.nota;

                    //pegando a média das notas maiores que zero
                    if(item.nota > 0)
                    {
                        mediaFolmowAvaliado += item.nota;
                        k++;
                    }


                }

                //idem o de cima
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

                //atribuindo a média                
                mediaFolmow /= i;
                mediaAdoroCinema /= j;

                //atribuindo a média dos avaliados
                mediaAdoroCinAvaliado /= m;
                mediaFolmowAvaliado /= k;

                //pegando a varianca
                double soma2 = 0;
                foreach (var fl in lsFilmow)
                {
                    soma2 += Math.Pow(((double) fl.nota - mediaFolmowAvaliado),2);
                }

                //desvio
                double mediaVariancaFilmow = soma2 / lsFilmow.Count;



                double soma3 = 0;
                foreach (var fl in lsAdoroCinema)
                {
                    soma3 += Math.Pow(((double)fl.nota - mediaAdoroCinAvaliado), 2);
                }
                double mediaVariancaAdoroFilme= soma3 / lsAdoroCinema.Count;


                txtAdoroCinema.Text = mediaAdoroCinema.ToString().Substring(0,4);
                txtFilmon.Text = mediaFolmow.ToString().Substring(0, 4);

                txtAvaliadosAdoroCinema.Text = mediaAdoroCinAvaliado.ToString().Substring(0, 4);
                txtAvalidosFilmow.Text = mediaFolmowAvaliado.ToString().Substring(0, 4);

                txtVariancaNotaFilmow.Text = mediaVariancaFilmow.ToString().Substring(0, 4);
                txtVariancaAdoroFilme.Text = mediaVariancaAdoroFilme.ToString().Substring(0, 4);

                txtDesvioAdoro.Text = Math.Sqrt(mediaVariancaAdoroFilme).ToString().Substring(0, 4);
                txtDesvioFilmow.Text = Math.Sqrt(mediaVariancaFilmow).ToString().Substring(0, 4);



            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro: " + erro.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //carregando os livros
            LivrosNovos livroNovo = new LivrosNovos();

            var ln = livroNovo.GetFilmes();

            //criando um id artificial, só para visualização no grig
            int idSite1 = 0;
            int idSite2 = 0;


            lsFilmow = new List<Filmes>();
            lsAdoroCinema = new List<Filmes>();

            foreach (var item in ln)
            {
                //pegando os filmes com so site filmow
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
                    //pengando os filmes do site adoroCinema
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
                //limpando o grid
                AtualizarGrid();

                List<Filmes> lsAdoroCinemaTop10 = new List<Filmes>();
                List<Filmes> lsFilmowTop10 = new List<Filmes>();

                double maiorNotaAdoro = 0;
                double maiorNotaFilmow = 0;

                //pegando a maior nota
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


                //ordenando a lista para exibir os 10 filmes 
                lsAdoroCinemaTop10 = lsAdoroCinema.OrderByDescending(ac => ac.nota).ToList();
                lsFilmowTop10 = lsFilmow.OrderByDescending(ac => ac.nota).ToList();

                var lsSite1 = new List<Filmes>();
                var lsSite2 = new List<Filmes>();

                //adicionando os 10 filmes na lista
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
                //adicionando os elementos ao grid
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
                //abrindo um mensagem dialogo do windwos, para confirmar o processamento
                DialogResult resultado = MessageBox.Show("Esse processo demora em torno de 4 minutos, seja continuar ?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //se resposnder sim, vai entrar no if
                if (resultado == DialogResult.Yes)
                {
                    //desabilitando o botão 
                    btnFilmesIguais.Enabled = false;
                    //pegando a hora em que iniciou
                    DateTime comecou = DateTime.Now;

                    //id artificial
                    int idFI = 0;
                    //limpando o grid
                    dgvIgual.Refresh();
                    dgvIgual.DataSource = null;
                    //criando a lista com o elemento que vai ser o grid
                    List<FilmesIguais> lsFilmesIguais = new List<FilmesIguais>();

                    

                    //estou pegando um elemento da lista que esta em i, e percorrendo todo o vetor do j procurando esse elemento
                    for (i = 0; i < lsFilmow.Count; i++)
                    {
                        for (int j = 0; j < lsAdoroCinema.Count; j++)
                        {
                            if (lsFilmow[i].titulo.ToUpper() == lsAdoroCinema[j].titulo.ToUpper())
                            {
                                                               
                                idFI++;
                                FilmesIguais fi = new FilmesIguais();
                                fi.id = idFI;
                                fi.notaAdoro = lsAdoroCinema[j].nota;
                                fi.notaFilmow = lsFilmow[i].nota;
                                fi.titulo = lsFilmow[i].titulo;
                                fi.comentario = lsFilmow[i].comentario;
                                //caso seja igual adiciona em uma lista
                                lsFilmesIguais.Add(fi);
                                j = lsAdoroCinema.Count;
                            }


                        }



                    }
                    //pegando a hora em que terminou o processo
                    DateTime terminou = DateTime.Now;

                    //mostrando o horario que t=começou e terminiou ao usuario
                    MessageBox.Show("Comecou " + comecou.ToString() + " Terminou " + terminou.ToString() + " Foram incontrados " + lsFilmesIguais.Count + " filmes iguais");

                    //adicionando ao grid a lista com os filmes iguais
                    dgvIgual.DataSource = lsFilmesIguais;

                    //habilitando o botão 
                    btnFilmesIguais.Enabled = true;
                }

                

            }
            catch (Exception erro)
            {
                var x = i;
                MessageBox.Show("Erro: " + erro.Message);
            }

            
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            //criando o formulário, e passando para o gráfico as listas já preenchidas 
            Grafico g = new Grafico(lsFilmow, lsAdoroCinema);
            g.Show();
        }
    }
}
