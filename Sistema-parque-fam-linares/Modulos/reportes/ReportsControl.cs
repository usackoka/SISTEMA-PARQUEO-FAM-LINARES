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

                xcelApp.Cells[dataGridView1.Rows.Count + 3, 2] = "TOTAL DE VENTAS";
                xcelApp.Cells[dataGridView1.Rows.Count + 3, 5] = "=SUMA(E2:E"+ (dataGridView1.Rows.Count).ToString() + ")";
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticketTableAdapter.FillBy1(this.parqueofaustinoDataSet.ticket);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticketTableAdapter.FillBy2(this.parqueofaustinoDataSet.ticket);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ventas_totales_mes_actualToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticketTableAdapter.ventas_totales_mes_actual(this.parqueofaustinoDataSet.ticket);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void total_dia_actualToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticketTableAdapter.total_dia_actual(this.parqueofaustinoDataSet.ticket);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
