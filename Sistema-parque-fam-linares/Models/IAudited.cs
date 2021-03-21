using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_parque_fam_linares.Models
{
    interface IAudited
    {
        string actualizadoPor { get; set; }
        string eliminadoPor { get; set; }
        string creadoPor { get; set; }
    }
}
