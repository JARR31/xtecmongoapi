using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBApi.Models
{
    public class Profesor
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("primerNombre")]
        public string PrimerNombre { get; set; }

        [BsonElement("segundoNombre")]
        public string SegundoNombre { get; set; }

        [BsonElement("primerApellido")]
        public string PrimerApellido { get; set; }

        [BsonElement("segundoApellido")]
        public string SegundoApellido { get; set; }

        [BsonElement("cedula")]
        public string Cedula { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }
    }
}
