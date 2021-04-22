using MySql.Data.MySqlClient;
using Sistema_parque_fam_linares.DB;
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
            cargarCatalogos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cargarCatalogos() {
            try
            {
                string sql = "select id, nombre from tipoVehiculo";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, ConexionMySQL.AbrirBD());
                DataSet ds = new DataSet();
                da.Fill(ds, "Tipos");
                comboTipoVehiculo.DisplayMember = "nombre";
                comboTipoVehiculo.ValueMember = "id";
                comboTipoVehiculo.DataSource = ds.Tables["Tipos"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Ocurrió un error al cargar el catálogo de vehículos, inténtelo de nuevo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
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
            if (txtPlaca.Text.Length < 6) {
                MessageBox.Show("El número de placa debe contener al menos 6 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                ticket.idTipoVehiculo = Convert.ToInt32(comboTipoVehiculo.SelectedValue.ToString());
                ticket.guardarTicket();
            }

            MessageBox.Show("Ticket guardado con éxito!.", "i", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.txtPlaca.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtIdTicket_TextChanged(object sender, EventArgs e)
        {
            Ticket ticket = Ticket.getTicketById(txtIdTicket.Text);
            lblPlaca.Text = "Placa: " + ticket.placa;
            lblTipoVehiculo.Text = "Tipo vehículo: " + ticket.getTipoVehiculo().nombre;

            lblTiempoTranscurrido.Text = "Tiempo: ";
            DateTime result = DateTime.Now - new TimeSpan(0, ticket.fechaIngreso.Hour, ticket.fechaIngreso.Minute, ticket.fechaIngreso.Second);
            //se calcula el tiempo que estuvo
            if (ticket.placa != "") {
                lblTiempoTranscurrido.Text = "Tiempo: " + result.Hour.ToString() + ":" + result.Minute.ToString() + ":" + result.Second.ToString();
            }

            //monto a cobrar
            txtMontoTotal.Text = (result.Hour * ticket.getTipoVehiculo().costoPorHora).ToString();
        }

        private void txtIdTicket_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdTicket.Text = "";
        }
    }
}
