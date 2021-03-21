using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_parque_fam_linares.Models
{
    public class Ticket : IAudited
    {
        public string Id { get; set; }
        public DateTime ingreso { get; set; }
        public DateTime egreso { get; set; }
        public string noPlaca { get; set; }
        public string actualizadoPor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string eliminadoPor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string creadoPor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
