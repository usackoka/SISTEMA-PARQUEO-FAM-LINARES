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
                try
                {
                    ticket.guardarTicket();

                    /*
                    clsFunciones.CreaTicket tk = new clsFunciones.CreaTicket();
                    tk.TextoIzquierda("Dirc: 7ma calle 9-69 Z.1, Guatemala C.A.\n");
                    tk.TextoCentro("Parqueo Multiservicios Faustino\n");
                    tk.TextoIzquierda("No Ticket: " + ticket.id.ToString());
                    tk.TextoIzquierda("Fecha: " + DateTime.Now.ToShortDateString() + " Hora: " + DateTime.Now.ToShortTimeString());
                    tk.TextoIzquierda("Placa: " + ticket.placa);
                    clsFunciones.CreaTicket.LineasGuion();
                    tk.TextoCentro("ESTE VEHICULO HA SIDO RECIBIDO BAJO LAS SIGUIENTES CONDICIONES\n");
                    tk.TextoIzquierda("1) El vehículo se estaciona por cuenta y riesgo del propietario.\n");
                    tk.TextoIzquierda("2) Si el cliente extravía el ticket, deberá demostrar fehacientemente cual es su vehículo para poder retirarlo.\n");
                    tk.TextoIzquierda("3) La empresa no se responsabiliza por daños causados a propiedad de terceras personas cuando estos sean producidos en circunstancias ajenas a este establecimiento.\n");
                    tk.TextoIzquierda("4) Favor NO DEJAR objetos de valor dentro del vehículo.\n");
                    tk.TextoIzquierda("5) Por extravío de ticket se cobrará\n");
                    tk.TextoIzquierda("   Q25.00");
                    clsFunciones.CreaTicket.LineasGuion();
                    tk.TextoCentro("Gracias por preferirnos");
                    tk.ImprimirTiket(config.impresoraSeleccionada);
                    */

                    ReportViewer report = new ReportViewer(ticket);
                    report.Show();


                    MessageBox.Show("Ticket guardado con éxito!.", "i", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtPlaca.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al guardar el ticket, inténtelo de nuevo. Error: "+ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ticket ticket = Ticket.getTicketById(txtIdTicket.Text);
            ticket.fechaEgreso = DateTime.Now;
            ticket.cobroTotal = Convert.ToDouble(txtMontoTotal.Text);
            ticket.update();
            MessageBox.Show("Salida registrada con éxito!.", "i", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
  
            if (ticket.placa != "" && ticket.placa != null) {
                lblTiempoTranscurrido.Text = "Tiempo: " + result.Hour.ToString() + ":" + result.Minute.ToString() + ":" + result.Second.ToString();
                //monto a cobrar
                int minutos = result.Minute;
                double fraccion = minutos > 5 ? (ticket.getTipoVehiculo().costoPorHora/2) : 0;
                fraccion = minutos > 35 ? ticket.getTipoVehiculo().costoPorHora : fraccion;
                txtMontoTotal.Text = (result.Hour * ticket.getTipoVehiculo().costoPorHora + fraccion).ToString();
            }

        }

        private void txtIdTicket_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdTicket.Text = "";
        }
    }
}
