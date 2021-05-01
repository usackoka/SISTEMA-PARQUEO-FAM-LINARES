using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;
using Sistema_parque_fam_linares.DB;
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
    public partial class ReciboForm : Form
    {
        ReportDocument crystal = new ReportDocument();
        string placa;
        DateTime fechaIngreso;
        string idTicket;

        public ReciboForm(string placa, DateTime fechaIngreso, string idTicket)
        {
            InitializeComponent();
            this.placa = placa;
            this.fechaIngreso = fechaIngreso;
            this.idTicket = idTicket;
        }

        private void ReciboForm_Load(object sender, EventArgs e)
        {
            crystal.Load(@"D:\Users\oscar\Documents\GitHub\SISTEMA-PARQUEO-FAM-LINARES\Sistema-parque-fam-linares\Modulos\reportes\CrystalReportRecibo.rpt");
            TextObject txtObj = (TextObject)crystal.ReportDefinition.Sections["Section2"].ReportObjects["id"];
            TextObject txtObj2 = (TextObject)crystal.ReportDefinition.Sections["Section3"].ReportObjects["txtPlacaFecha"];
            txtObj.Text = this.idTicket;
            txtObj2.Text = "Placa: " + this.placa + "\n" + "Ingreso: " + this.fechaIngreso.ToString();
            /*
            string sql = "select * from ticket where id=3";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, ConexionMySQL.AbrirBD());
            DataSet ds = new DataSet();
            da.Fill(ds, "Tickets");
            crystal.SetDataSource(ds);
            crystalReportViewer1.ReportSource = crystal;
            */
            crystalReportViewer1.ReportSource = crystal;
        }
    }
}
