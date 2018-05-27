using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
//using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;

namespace ApresentarDados
{
    [BsonIgnoreExtraElements]
    public class LivrosNovos
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string oid { get; set; }
        public string li { get; set; }
        public string titulo { get; set; }
        public string nota { get; set; }
        public string comentario { get; set; }
        public string subTitulo { get; set; }
        public string site { get; set; }


        public List<LivrosNovos> GetFilmes()
        {
            BsonClassMap.RegisterClassMap<LivrosNovos>();

            MongoClient mongo = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase db = mongo.GetDatabase("Luciano");
            IMongoCollection<LivrosNovos> table = db.GetCollection<LivrosNovos>("LivrosNovos");
            BsonDocument filtro1 = new BsonDocument();
            FilterDefinition<LivrosNovos> filtro2 = FilterDefinition<LivrosNovos>.Empty;

            List<LivrosNovos> dados2 = table.Find(filtro2).ToList();

            return dados2;

        }

    }


}
