using Sistema_parque_fam_linares.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Sistema_parque_fam_linares.Models
{
    public class MongoRegister<ISchema>
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get ; set ; }
        [BsonElement("actualizadoPor")]
        public string actualizadoPor { get ; set ; }
        [BsonElement("eliminadoPor")]
        public string eliminadoPor { get ; set ; }
        [BsonElement("creadoPor")]
        public string creadoPor { get ; set ; }
    }
}
