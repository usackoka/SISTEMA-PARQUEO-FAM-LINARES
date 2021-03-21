using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace Sistema_parque_fam_linares.Models
{
    public class Usuario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("primerNombre")]
        public string primerNombre { get; set; }

        [BsonElement("segundoNombre")]
        public string segundoNombre { get; set; }
        [BsonElement("primerApellido")]
        public string primerApellido { get; set; }
        [BsonElement("segundoApellido")]
        public string segundoApellido { get; set; }
    }
}
