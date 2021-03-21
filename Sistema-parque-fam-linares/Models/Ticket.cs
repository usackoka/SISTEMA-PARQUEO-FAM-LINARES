using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Sistema_parque_fam_linares.Models
{
    public class Ticket : MongoRegister<Ticket>
    {
        [BsonElement("ingreso")]
        public DateTime ingreso { get; set; }
        [BsonElement("egreso")]
        public DateTime egreso { get; set; }
        [BsonElement("noPlaca")]
        public string noPlaca { get; set; }
    }
}
