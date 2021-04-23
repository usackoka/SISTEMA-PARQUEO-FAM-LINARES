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
        public ReciboForm()
        {
            InitializeComponent();
        }

        private void ReciboForm_Load(object sender, EventArgs e)
        {
            crystal.Load(@"D:\Users\oscar\Documents\GitHub\SISTEMA-PARQUEO-FAM-LINARES\Sistema-parque-fam-linares\Modulos\reportes\CrystalReportRecibo.rpt");
            string sql = "select * from ticket where id=3";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, ConexionMySQL.AbrirBD());
            DataSet ds = new DataSet();
            da.Fill(ds, "Tickets");
            crystal.SetDataSource(ds);
            crystalReportViewer1.ReportSource = crystal;
        }
    }
}
