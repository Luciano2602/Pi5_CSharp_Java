package br.pro.grupo.pi.webscraping;

import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.databind.SerializationFeature;
import com.gargoylesoftware.htmlunit.BrowserVersion;
import com.gargoylesoftware.htmlunit.WebClient;
import com.gargoylesoftware.htmlunit.html.DomElement;
import com.gargoylesoftware.htmlunit.html.HtmlAnchor;
import com.gargoylesoftware.htmlunit.html.HtmlPage;
import com.machinepublishers.jbrowserdriver.JBrowserDriver;
import com.mongodb.DB;
import com.mongodb.DBCollection;
import com.mongodb.DBObject;
import com.mongodb.MongoClient;
import com.mongodb.util.JSON;
import com.sun.webkit.WebPageClient;
import java.io.IOException;
import java.util.HashSet;
import java.util.List;
import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;
import org.jsoup.nodes.Element;
import org.jsoup.select.Elements;
import org.openqa.selenium.By;
import org.openqa.selenium.WebElement;

public class Program {

    public static void GetSitefilmow() throws JsonProcessingException, IOException, InterruptedException {

        ObjectMapper mapper = new ObjectMapper();
        mapper.enable(SerializationFeature.INDENT_OUTPUT);
        mapper.setSerializationInclusion(JsonInclude.Include.NON_NULL);
        mapper.setSerializationInclusion(JsonInclude.Include.NON_EMPTY);

        MongoClient mongo = new MongoClient("localhost", 27017);
        DB db = mongo.getDB("Luciano");
        DBCollection lv = db.getCollection("LivrosNovos");

        String site = "https://filmow.com/filmes-em-dvd/";

        for (int pg = 367; pg <= 1076; pg++) {
            Document pagina = Jsoup.connect(site + "?pagina=" + pg).userAgent("Mozila/5.0").get();
            Elements itens = pagina.select("#movies-list li");
            System.out.println("Estamos na página <- " + pg + "     -------------------------------------------------------------------------------------------------------------------------------------");
            System.out.println("");
            System.out.println("");
            
            if(pg%200 == 0)
                Thread.sleep(40000);
            
            for (Element item : itens) {

                if ((item.select("li.span2 movie_list_item").text().isEmpty() || item.select("span.title").text().isEmpty())) {

                    String li = item.select("li.span2 movie_list_item").text();
                    String titulo = item.select("span.title").text();
                    String nota = item.select("span.movie-rating-average").text();//legend ws
                    String comentario = item.select("span.badge.badge-num-comments.tip").text();
                    String subTitulo = item.select("span.legend.ws").text();

                    Filme l = new Filme();

                    if (li.length() == 0) {
                        li = "Vazio";
                    }

                    if (titulo.length() == 0) {
                        titulo = "Vazio";
                    }

                    if (nota.length() == 0) {
                        nota = "Vazio";
                    }

                    if (comentario.length() == 0) {
                        comentario = "Vazio";
                    }

                    if (subTitulo.length() == 0) {
                        subTitulo = "Vazio";
                    }

                    l.setLi(li);
                    l.setTitulo(titulo);
                    l.setNota(nota);
                    l.setSubTitulo(subTitulo);
                    l.setComentario(comentario);
                    l.setSite("filmow.com");

                    mapper.writeValueAsString(l);
                    String json = mapper.writeValueAsString(l);
                    System.out.println(json);

                    DBObject obj = (DBObject) JSON.parse(json);
                    lv.insert(obj);

                }

            }

        }

        System.out.println("Acabou +++++++++++++++++++++++++++++");
    }

    public static void GetSiteAdorocinema() throws JsonProcessingException, IOException, InterruptedException {
        ObjectMapper mapper = new ObjectMapper();
        mapper.enable(SerializationFeature.INDENT_OUTPUT);
        mapper.setSerializationInclusion(JsonInclude.Include.NON_NULL);
        mapper.setSerializationInclusion(JsonInclude.Include.NON_EMPTY);

        MongoClient mongo = new MongoClient("localhost", 27017);
        DB db = mongo.getDB("PI5");
        DBCollection lv = db.getCollection("Filmes");

        String site = "http://www.adorocinema.com/filmes/todos-filmes/notas-espectadores/";

        for (int pg = 1; pg <= 1567; pg++) {
            
            if(pg == 1371)
                Thread.sleep(400000);
            
            
            Document pagina = Jsoup.connect(site + "?page=" + pg).userAgent("Mozila/5.0").get();
            Elements itens = pagina.select("#col_content div.content");

            System.out.println("Estamos na página <- " + pg + "     -------------------------------------------------------------------------------------------------------------------------------------");
            System.out.println("");
            System.out.println("");
            
            if(pg % 200 == 0)
                Thread.sleep(40000);
                       
            
            for (Element item : itens) {

                String titulo = item.select("h2").text();
                String nota = item.select("span.note").text();
                //System.out.println(titulo + " <- filme " + nota + " <- Nota" );
                String lancamento = item.select("div.oflow_a").text();
                String diretor = item.select("a.xXx").text();
                String tipo = item.select("span.genre").text();
                
                System.out.println("lancamento -> " + lancamento + " diretor -> " + diretor + " diretor -> " + tipo);
                
                
                Filme l = new Filme();

                if (titulo.length() == 0) {
                    titulo = "Vazio";
                }

                if (nota.length() == 0) {
                    nota = "0";
                } else {

                    nota = nota.replace(",", ".");
                    String v[] = new String[2];
                    v = nota.split(" ");

                    if (v.length == 1) {
                        nota = v[0];
                    } else if (v.length == 2) {
                        nota = v[1];
                    } else {
                        nota = v[2];
                    }
                }

                l.setTitulo(titulo);
                l.setNota(nota);
                l.setSite("adorocinema");
                mapper.writeValueAsString(l);
                String json = mapper.writeValueAsString(l);
                System.out.println(json);

                DBObject obj = (DBObject) JSON.parse(json);
                lv.insert(obj);

            }

        }

    }

    public static void main(String[] args) throws IOException, JsonProcessingException, InterruptedException {

        System.out.println("Olá mundo");
       // System.out.println("SITE  FILMOW");
        //GetSitefilmow();
        
        
        
        //System.out.println("Olá mundo");
        //System.out.println("SITE  ADOROCINEMA");
        //GetSiteAdorocinema();
        
        //pegando a pagia de funcionarios passando como parametro o cód unidade
        JBrowserDriver driver = new JBrowserDriver();

        // carrega a página principal
        String url = "http://www.adorocinema.com/filmes/todos-filmes/notas-espectadores/?page=1";
        driver.get(url);

        // decobre os links dos mantidos
        List<WebElement> links = driver.findElementsByCssSelector("a");
        
        for (WebElement link : links) {
            System.out.println(link);
            System.out.println("");
            System.out.println("");
            System.out.println("");
            System.out.println("=========");
            System.out.println(link.toString());
            System.out.println("");
            System.out.println("");
            System.out.println("");
            System.out.println("=========");
            System.out.println(link.getText());
        }
    }
}
