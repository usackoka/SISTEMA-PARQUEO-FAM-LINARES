using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Sistema_parque_fam_linares.Models
{
    public class Ticket : IAudited
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("ingreso")]
        public DateTime ingreso { get; set; }
        [BsonElement("egreso")]
        public DateTime egreso { get; set; }
        [BsonElement("noPlaca")]
        public string noPlaca { get; set; }
        public string actualizadoPor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string eliminadoPor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string creadoPor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
