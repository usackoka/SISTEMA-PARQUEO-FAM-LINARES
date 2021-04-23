
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEgresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cobroTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.parqueofaustinoDataSet = new Sistema_parque_fam_linares.parqueofaustinoDataSet();
            this.ticketTableAdapter = new Sistema_parque_fam_linares.parqueofaustinoDataSetTableAdapters.ticketTableAdapter();
            this.buscar_activosToolStrip = new System.Windows.Forms.ToolStrip();
            this.buscar_activosToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parqueofaustinoDataSet)).BeginInit();
            this.buscar_activosToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(58, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 52);
            this.label2.TabIndex = 3;
            this.label2.Text = "Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(367, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hasta";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dateTimePicker1.Location = new System.Drawing.Point(67, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(294, 56);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dateTimePicker2.Location = new System.Drawing.Point(376, 81);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(275, 56);
            this.dateTimePicker2.TabIndex = 6;
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
            this.dataGridView1.Location = new System.Drawing.Point(67, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(584, 255);
            this.dataGridView1.TabIndex = 7;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
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
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // buscar_activosToolStrip
            // 
            this.buscar_activosToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.buscar_activosToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.buscar_activosToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscar_activosToolStripButton});
            this.buscar_activosToolStrip.Location = new System.Drawing.Point(83, 0);
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
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(67, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Exportar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReportsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buscar_activosToolStrip);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ReportsControl";
            this.Size = new System.Drawing.Size(715, 502);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parqueofaustinoDataSet)).EndInit();
            this.buscar_activosToolStrip.ResumeLayout(false);
            this.buscar_activosToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
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
    }
}
