using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_parque_fam_linares.Modulos.reportes
{
    public partial class FormTotalPagar : Form
    {
        public FormTotalPagar(string totalAPagar, string tiempo)
        {
            InitializeComponent();
            this.lblTiempoTranscurrido.Text = tiempo;
            this.lblTotalPagar.Text = "Q" + totalAPagar;
        }
    }
}
