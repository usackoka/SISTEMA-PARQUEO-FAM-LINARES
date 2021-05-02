
namespace Sistema_parque_fam_linares.Modulos.reportes
{
    partial class ReportsControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEgresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cobroTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.parqueofaustinoDataSet = new Sistema_parque_fam_linares.parqueofaustinoDataSet();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.buscar_activosToolStrip = new System.Windows.Forms.ToolStrip();
            this.buscar_activosToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.ventas_totales_mes_actualToolStrip = new System.Windows.Forms.ToolStrip();
            this.ventas_totales_mes_actualToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ticketTableAdapter = new Sistema_parque_fam_linares.parqueofaustinoDataSetTableAdapters.ticketTableAdapter();
            this.total_dia_actualToolStrip = new System.Windows.Forms.ToolStrip();
            this.total_dia_actualToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parqueofaustinoDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.buscar_activosToolStrip.SuspendLayout();
            this.ventas_totales_mes_actualToolStrip.SuspendLayout();
            this.total_dia_actualToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fechaIngresoDataGridViewTextBoxColumn,
            this.fechaEgresoDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.cobroTotalDataGridViewTextBoxColumn,
            this.idTipoVehiculoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ticketBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(67, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(584, 335);
            this.dataGridView1.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaIngresoDataGridViewTextBoxColumn
            // 
            this.fechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "fechaIngreso";
            this.fechaIngresoDataGridViewTextBoxColumn.HeaderText = "fechaIngreso";
            this.fechaIngresoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaIngresoDataGridViewTextBoxColumn.Name = "fechaIngresoDataGridViewTextBoxColumn";
            this.fechaIngresoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaEgresoDataGridViewTextBoxColumn
            // 
            this.fechaEgresoDataGridViewTextBoxColumn.DataPropertyName = "fechaEgreso";
            this.fechaEgresoDataGridViewTextBoxColumn.HeaderText = "fechaEgreso";
            this.fechaEgresoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaEgresoDataGridViewTextBoxColumn.Name = "fechaEgresoDataGridViewTextBoxColumn";
            this.fechaEgresoDataGridViewTextBoxColumn.Width = 125;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "placa";
            this.placaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            this.placaDataGridViewTextBoxColumn.Width = 125;
            // 
            // cobroTotalDataGridViewTextBoxColumn
            // 
            this.cobroTotalDataGridViewTextBoxColumn.DataPropertyName = "cobroTotal";
            this.cobroTotalDataGridViewTextBoxColumn.HeaderText = "cobroTotal";
            this.cobroTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cobroTotalDataGridViewTextBoxColumn.Name = "cobroTotalDataGridViewTextBoxColumn";
            this.cobroTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // idTipoVehiculoDataGridViewTextBoxColumn
            // 
            this.idTipoVehiculoDataGridViewTextBoxColumn.DataPropertyName = "idTipoVehiculo";
            this.idTipoVehiculoDataGridViewTextBoxColumn.HeaderText = "idTipoVehiculo";
            this.idTipoVehiculoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idTipoVehiculoDataGridViewTextBoxColumn.Name = "idTipoVehiculoDataGridViewTextBoxColumn";
            this.idTipoVehiculoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ticketBindingSource1
            // 
            this.ticketBindingSource1.DataMember = "ticket";
            this.ticketBindingSource1.DataSource = this.parqueofaustinoDataSet;
            // 
            // parqueofaustinoDataSet
            // 
            this.parqueofaustinoDataSet.DataSetName = "parqueofaustinoDataSet";
            this.parqueofaustinoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(19, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(111, 27);
            this.fillByToolStrip.TabIndex = 8;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(98, 24);
            this.fillByToolStripButton.Text = "Buscar todos";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // buscar_activosToolStrip
            // 
            this.buscar_activosToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.buscar_activosToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.buscar_activosToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscar_activosToolStripButton});
            this.buscar_activosToolStrip.Location = new System.Drawing.Point(102, 0);
            this.buscar_activosToolStrip.Name = "buscar_activosToolStrip";
            this.buscar_activosToolStrip.Size = new System.Drawing.Size(119, 27);
            this.buscar_activosToolStrip.TabIndex = 9;
            this.buscar_activosToolStrip.Text = "buscar_activosToolStrip";
            // 
            // buscar_activosToolStripButton
            // 
            this.buscar_activosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buscar_activosToolStripButton.Name = "buscar_activosToolStripButton";
            this.buscar_activosToolStripButton.Size = new System.Drawing.Size(106, 24);
            this.buscar_activosToolStripButton.Text = "Buscar activos";
            this.buscar_activosToolStripButton.Click += new System.EventHandler(this.buscar_activosToolStripButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(67, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Exportar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ventas_totales_mes_actualToolStrip
            // 
            this.ventas_totales_mes_actualToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.ventas_totales_mes_actualToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ventas_totales_mes_actualToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventas_totales_mes_actualToolStripButton});
            this.ventas_totales_mes_actualToolStrip.Location = new System.Drawing.Point(19, 31);
            this.ventas_totales_mes_actualToolStrip.Name = "ventas_totales_mes_actualToolStrip";
            this.ventas_totales_mes_actualToolStrip.Size = new System.Drawing.Size(134, 27);
            this.ventas_totales_mes_actualToolStrip.TabIndex = 11;
            this.ventas_totales_mes_actualToolStrip.Text = "ventas_totales_mes_actualToolStrip";
            // 
            // ventas_totales_mes_actualToolStripButton
            // 
            this.ventas_totales_mes_actualToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ventas_totales_mes_actualToolStripButton.Name = "ventas_totales_mes_actualToolStripButton";
            this.ventas_totales_mes_actualToolStripButton.Size = new System.Drawing.Size(121, 24);
            this.ventas_totales_mes_actualToolStripButton.Text = "Total mes actual";
            this.ventas_totales_mes_actualToolStripButton.Click += new System.EventHandler(this.ventas_totales_mes_actualToolStripButton_Click);
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // total_dia_actualToolStrip
            // 
            this.total_dia_actualToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.total_dia_actualToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.total_dia_actualToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.total_dia_actualToolStripButton});
            this.total_dia_actualToolStrip.Location = new System.Drawing.Point(115, 31);
            this.total_dia_actualToolStrip.Name = "total_dia_actualToolStrip";
            this.total_dia_actualToolStrip.Size = new System.Drawing.Size(128, 27);
            this.total_dia_actualToolStrip.TabIndex = 12;
            this.total_dia_actualToolStrip.Text = "total_dia_actualToolStrip";
            // 
            // total_dia_actualToolStripButton
            // 
            this.total_dia_actualToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.total_dia_actualToolStripButton.Name = "total_dia_actualToolStripButton";
            this.total_dia_actualToolStripButton.Size = new System.Drawing.Size(115, 24);
            this.total_dia_actualToolStripButton.Text = "Total día actual";
            this.total_dia_actualToolStripButton.Click += new System.EventHandler(this.total_dia_actualToolStripButton_Click);
            // 
            // ReportsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.total_dia_actualToolStrip);
            this.Controls.Add(this.ventas_totales_mes_actualToolStrip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buscar_activosToolStrip);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReportsControl";
            this.Size = new System.Drawing.Size(715, 502);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parqueofaustinoDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.buscar_activosToolStrip.ResumeLayout(false);
            this.buscar_activosToolStrip.PerformLayout();
            this.ventas_totales_mes_actualToolStrip.ResumeLayout(false);
            this.ventas_totales_mes_actualToolStrip.PerformLayout();
            this.total_dia_actualToolStrip.ResumeLayout(false);
            this.total_dia_actualToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ticketBindingSource1;
        private parqueofaustinoDataSet parqueofaustinoDataSet;
        private parqueofaustinoDataSetTableAdapters.ticketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEgresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cobroTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStrip buscar_activosToolStrip;
        private System.Windows.Forms.ToolStripButton buscar_activosToolStripButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip ventas_totales_mes_actualToolStrip;
        private System.Windows.Forms.ToolStripButton ventas_totales_mes_actualToolStripButton;
        private System.Windows.Forms.ToolStrip total_dia_actualToolStrip;
        private System.Windows.Forms.ToolStripButton total_dia_actualToolStripButton;
    }
}
