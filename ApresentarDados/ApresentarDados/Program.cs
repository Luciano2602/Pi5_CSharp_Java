using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
namespace ApresentarDados
{
    class Program
    {
        public static void Main(string[] args)
        {
            BsonClassMap.RegisterClassMap<LivrosNovos>();

            MongoClient mongo = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase db = mongo.GetDatabase("Luciano");
            IMongoCollection <LivrosNovos> table = db.GetCollection<LivrosNovos>("LivrosNovos");
            BsonDocument filtro1 = new BsonDocument();
            FilterDefinition<LivrosNovos> filtro2 = FilterDefinition<LivrosNovos>.Empty;

            List<LivrosNovos> dados2 = table.Find(filtro2).ToList();

            foreach (var item in dados2)
            {
                Console.WriteLine(item.comentario + " <- Comentario " + 
                                    item.nota + " <- Nota " + item.site + " <- Site " + 
                                    item.titulo + " <- Titulo");
            }
        }
    }
}
