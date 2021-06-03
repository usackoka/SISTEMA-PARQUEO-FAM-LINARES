using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Sistema_parque_fam_linares.Models;
using System.Configuration;
using System.IO;

namespace Sistema_parque_fam_linares.Modulos.reportes
{
    public partial class ReportViewer : Form
    {
        Ticket ticket;
        public ReportViewer(Ticket ticket)
        {
            this.ticket = ticket;
            InitializeComponent();
            this.Load += Form1_Load1;
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void Form1_Load1(object sender, EventArgs e)
        {
            CargarReporte();

        }

        /// <summary>
        /// Método para recuperar Datos a una lista
        /// y para mostrar en el ReportViewer
        /// </summary>
        private void CargarReporte()
        {
            List<Ticket> Agregar = new List<Ticket>();
            Agregar.Add(ticket);

            //path del reporte
            Uri file = new Uri(@"c:\reportes\ticketReporte.rdlc");
            // Must end in a slash to indicate folder
            Uri folder = new Uri(@"c:\reportes\");
            string relativePath =
            Uri.UnescapeDataString(
                folder.MakeRelativeUri(file)
                    .ToString()
                    .Replace('/', Path.DirectorySeparatorChar)
                );

            ///Mostrar datos en el reporte
            this.reportViewer1.LocalReport.ReportPath = relativePath;
            ReportDataSource rds1 = new ReportDataSource("Tickets", Agregar);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }
    }
}
