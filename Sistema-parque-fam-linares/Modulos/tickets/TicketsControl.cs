using Sistema_parque_fam_linares.Models;
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
            timer1.Enabled = true;
            // this.timerActualizadorFecha.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e) { 
        
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void TicketsControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //verificamos si ya hay un carro con esta placa en el parqueo
            if (Ticket.existePlaca(txtPlaca.Text))
            {
                MessageBox.Show("Ya existe un ticket en curso para la placa ingresada, finalice dicho ticket para poder crear uno nuevo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Ticket ticket = new Ticket();
                ticket.fechaIngreso = DateTime.Now;
                ticket.placa = txtPlaca.Text;
                ticket.tipoVehiculo = comboTipoVehiculo.SelectedItem.ToString();
                ticket.guardarTicket();
            }

            MessageBox.Show("Ticket guardado con éxito!.", "i", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
