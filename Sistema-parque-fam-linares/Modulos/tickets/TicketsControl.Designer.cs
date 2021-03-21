
namespace Sistema_parque_fam_linares.Modulos.tickets
{
    partial class TicketsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketsControl));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.horaIngreso = new System.Windows.Forms.DateTimePicker();
            this.btnGenerarTicket = new System.Windows.Forms.Button();
            this.timerActualizadorFecha = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha/Hora Ingreso";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS PGothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(100, 232);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(561, 40);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de placa";
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.Checked = false;
            this.fechaIngreso.Font = new System.Drawing.Font("MS PGothic", 19.8F);
            this.fechaIngreso.Location = new System.Drawing.Point(100, 118);
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.ShowCheckBox = true;
            this.fechaIngreso.Size = new System.Drawing.Size(356, 40);
            this.fechaIngreso.TabIndex = 3;
            // 
            // horaIngreso
            // 
            this.horaIngreso.Checked = false;
            this.horaIngreso.Font = new System.Drawing.Font("MS PGothic", 19.8F);
            this.horaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaIngreso.Location = new System.Drawing.Point(471, 118);
            this.horaIngreso.Name = "horaIngreso";
            this.horaIngreso.ShowCheckBox = true;
            this.horaIngreso.ShowUpDown = true;
            this.horaIngreso.Size = new System.Drawing.Size(190, 40);
            this.horaIngreso.TabIndex = 5;
            // 
            // btnGenerarTicket
            // 
            this.btnGenerarTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarTicket.ForeColor = System.Drawing.Color.DimGray;
            this.btnGenerarTicket.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarTicket.Image")));
            this.btnGenerarTicket.Location = new System.Drawing.Point(322, 320);
            this.btnGenerarTicket.Name = "btnGenerarTicket";
            this.btnGenerarTicket.Size = new System.Drawing.Size(134, 92);
            this.btnGenerarTicket.TabIndex = 6;
            this.btnGenerarTicket.UseVisualStyleBackColor = true;
            this.btnGenerarTicket.Click += new System.EventHandler(this.btnGenerarTicket_Click);
            // 
            // timerActualizadorFecha
            // 
            this.timerActualizadorFecha.Tick += new System.EventHandler(this.timerActualizadorFecha_Tick);
            // 
            // TicketsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.btnGenerarTicket);
            this.Controls.Add(this.horaIngreso);
            this.Controls.Add(this.fechaIngreso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "TicketsControl";
            this.Size = new System.Drawing.Size(894, 628);
            this.Load += new System.EventHandler(this.TicketsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaIngreso;
        private System.Windows.Forms.DateTimePicker horaIngreso;
        private System.Windows.Forms.Button btnGenerarTicket;
        private System.Windows.Forms.Timer timerActualizadorFecha;
    }
}
