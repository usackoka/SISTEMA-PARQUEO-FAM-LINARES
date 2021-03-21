using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Sistema_parque_fam_linares.Models
{
    interface IAudited
    {
        [BsonElement("actualizadoPor")]
        string actualizadoPor { get; set; }
        [BsonElement("eliminadoPor")]
        string eliminadoPor { get; set; }
        [BsonElement("creadoPor")]
        string creadoPor { get; set; }
    }
}
