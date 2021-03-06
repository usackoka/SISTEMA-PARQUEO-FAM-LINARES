using MySql.Data.MySqlClient;
using Sistema_parque_fam_linares.DB;
using Sistema_parque_fam_linares.Models;
using Sistema_parque_fam_linares.Modulos.reportes;
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

                comboTipoVehiculo.SelectedValue = 2;
                
                ConexionMySQL.cerrarBD();
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
            Ticket ticket = new Ticket();
            ticket.fechaIngreso = DateTime.Now;
            ticket.placa = txtPlaca.Text ?? "";
            ticket.idTipoVehiculo = Convert.ToInt32(comboTipoVehiculo.SelectedValue.ToString());
            try
            {
                ticket.guardarTicket();

                ReportViewer report = new ReportViewer(ticket);
                report.Show();

                this.txtPlaca.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el ticket, inténtelo de nuevo. Error: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ticket ticket = Ticket.getTicketById(txtIdTicket.Text);
            ticket.fechaEgreso = DateTime.Now;
            ticket.cobroTotal = Convert.ToDouble(txtMontoTotal.Text);
            ticket.update();
            //MessageBox.Show("Salida registrada con éxito, Total a pagar: Q"+ticket.cobroTotal, "i", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormTotalPagar f = new FormTotalPagar(ticket.cobroTotal.ToString(), lblTiempoTranscurrido.Text);
            f.Show();

            lblPlaca.Text = "Placa:";
            lblTiempoTranscurrido.Text = "Tiempo: ";
            lblTipoVehiculo.Text = "Tipo vehículo: ";
            txtMontoTotal.Text = "";
        }

        private void txtIdTicket_TextChanged(object sender, EventArgs e)
        {
            Ticket ticket = Ticket.getTicketById(txtIdTicket.Text);
            lblPlaca.Text = "Placa: " + ticket.placa;
            lblTipoVehiculo.Text = "Tipo vehículo: " + ticket.getTipoVehiculo().nombre;

            //se calcula el tiempo que estuvo
            lblTiempoTranscurrido.Text = "Tiempo: ";
            DateTime result = DateTime.Now - new TimeSpan(0, ticket.fechaIngreso.Hour, ticket.fechaIngreso.Minute, ticket.fechaIngreso.Second);
            txtMontoTotal.Text = "";

            lblTiempoTranscurrido.Text = "Tiempo: " + result.Hour.ToString() + ":" + result.Minute.ToString() + ":" + result.Second.ToString();
            //monto a cobrar
            int minutos = result.Minute;
            double fraccion = minutos > 3 ? (ticket.getTipoVehiculo().costoPorHora / 2) : 0;
            fraccion = minutos > 33 ? ticket.getTipoVehiculo().costoPorHora : fraccion;
            fraccion = result.Hour == 0 && fraccion == 0 ? (ticket.getTipoVehiculo().costoPorHora / 2) : fraccion;
            txtMontoTotal.Text = (result.Hour * ticket.getTipoVehiculo().costoPorHora + fraccion).ToString();
        }

        private void txtIdTicket_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdTicket.Text = "";
        }
    }
}
