
namespace Sistema_parque_fam_linares.Modulos.reportes
{
    partial class FormTotalPagar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.lblTiempoTranscurrido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Arial Narrow", 199.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(630, 351);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(677, 383);
            this.lblTotalPagar.TabIndex = 16;
            this.lblTotalPagar.Text = "Q20";
            this.lblTotalPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTiempoTranscurrido
            // 
            this.lblTiempoTranscurrido.AutoSize = true;
            this.lblTiempoTranscurrido.Font = new System.Drawing.Font("Arial Narrow", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoTranscurrido.Location = new System.Drawing.Point(37, 91);
            this.lblTiempoTranscurrido.Name = "lblTiempoTranscurrido";
            this.lblTiempoTranscurrido.Size = new System.Drawing.Size(731, 69);
            this.lblTiempoTranscurrido.TabIndex = 17;
            this.lblTiempoTranscurrido.Text = "Tiempo transcurrido: 01:01:01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(863, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 69);
            this.label2.TabIndex = 18;
            this.label2.Text = "Total a pagar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTotalPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1224, 774);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTiempoTranscurrido);
            this.Controls.Add(this.lblTotalPagar);
            this.Name = "FormTotalPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTotalPagar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label lblTiempoTranscurrido;
        private System.Windows.Forms.Label label2;
    }
}