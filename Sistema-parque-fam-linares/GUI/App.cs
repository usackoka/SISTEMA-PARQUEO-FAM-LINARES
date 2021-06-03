using IronBarCode;
using Sistema_parque_fam_linares.Modulos.reportes;
using Sistema_parque_fam_linares.Modulos.tickets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_parque_fam_linares
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        //Pantallas
        private TicketsControl ticketsControl;
        private ReportsControl reportsControl;

        public Form1()
        {
            InitializeComponent();
            statusPanel.Height = btnInicio.Height;
            statusPanel.Top = btnInicio.Top;
            this.ticketsControl = new TicketsControl();
            this.reportsControl = new ReportsControl();
            this.panelMaster.Controls.Add(this.ticketsControl);
            // this.GenerateBacode("Hola info a codificar", "filename.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            statusPanel.Height = btnInicio.Height;
            statusPanel.Top = btnInicio.Top;

            this.panelMaster.Controls.RemoveAt(0);
            this.panelMaster.Controls.Add(this.ticketsControl);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            statusPanel.Height = btnUsers.Height;
            statusPanel.Top = btnUsers.Top;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            statusPanel.Height = btnReportes.Height;
            statusPanel.Top = btnReportes.Top;

            this.panelMaster.Controls.RemoveAt(0);
            this.panelMaster.Controls.Add(this.reportsControl);
        }

        //Métodos de movimiento del form
        private void EventMouseDown()
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void EventMouseMove()
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void EventMouseUp()
        {
            dragging = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            EventMouseDown();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            EventMouseMove();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            EventMouseUp();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            EventMouseMove();
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            EventMouseUp();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            EventMouseDown();
        }

        private void btnGenerarTicket_Click(object sender, EventArgs e)
        {
            refreshImpresoras();
        }

        private void GenerateBacode(string _data, string _filename)
        {
            GeneratedBarcode MyBarCode = IronBarCode.BarcodeWriter.CreateBarcode("0123456789", BarcodeWriterEncoding.Code128);
            MyBarCode.SaveAsPng("MyBarCode.png");
            // This line opens the image in your default image viewer
            System.Diagnostics.Process.Start("MyBarCode.png");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshImpresoras();
        }

        private void refreshImpresoras()
        {
            List<string> my_list = new List<string>();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                my_list.Add(printer);
            }
        }

        private void comboImpresoras_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
