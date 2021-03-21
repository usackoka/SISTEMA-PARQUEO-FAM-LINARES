using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_parque_fam_linares.Modulos.tickets
{
    public partial class TicketsControl : UserControl
    {
        public TicketsControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            // this.timerActualizadorFecha.Start();
        }

        private void TicketsControl_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkHabilitarFecha_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerarTicket_Click(object sender, EventArgs e)
        {

        }

        private void timerActualizadorFecha_Tick(object sender, EventArgs e)
        {
            this.fechaIngreso.Value = DateTime.Now;
            this.horaIngreso.Value = DateTime.Now;
        }
    }
}
