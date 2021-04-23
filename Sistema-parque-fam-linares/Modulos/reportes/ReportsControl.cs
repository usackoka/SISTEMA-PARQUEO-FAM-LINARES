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
    public partial class ReportsControl : UserControl
    {
        public ReportsControl()
        {
            InitializeComponent();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticketTableAdapter.FillBy(this.parqueofaustinoDataSet.ticket);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void buscar_activosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticketTableAdapter.Buscar_activos(this.parqueofaustinoDataSet.ticket);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        Object value = dataGridView1.Rows[i].Cells[j].Value;
                        xcelApp.Cells[i + 2, j + 1] = value!=null?value.ToString():"";
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
