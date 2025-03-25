namespace pelota
{
    partial class FormPelota
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Salirprograma_click = new System.Windows.Forms.Button();
            this.Canchapelota = new System.Windows.Forms.PictureBox();
            this.botondibujar = new System.Windows.Forms.Button();
            this.timeranimacion = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Canchapelota)).BeginInit();
            this.SuspendLayout();
            // 
            // Salirprograma_click
            // 
            this.Salirprograma_click.Location = new System.Drawing.Point(636, 396);
            this.Salirprograma_click.Name = "Salirprograma_click";
            this.Salirprograma_click.Size = new System.Drawing.Size(108, 44);
            this.Salirprograma_click.TabIndex = 0;
            this.Salirprograma_click.Text = "Salir";
            this.Salirprograma_click.UseVisualStyleBackColor = true;
            this.Salirprograma_click.Click += new System.EventHandler(this.Salirprograma_click_Click);
            // 
            // Canchapelota
            // 
            this.Canchapelota.BackColor = System.Drawing.Color.White;
            this.Canchapelota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Canchapelota.Location = new System.Drawing.Point(16, 21);
            this.Canchapelota.Name = "Canchapelota";
            this.Canchapelota.Size = new System.Drawing.Size(753, 354);
            this.Canchapelota.TabIndex = 1;
            this.Canchapelota.TabStop = false;
            this.Canchapelota.Click += new System.EventHandler(this.Canchapelota_Click);
            this.Canchapelota.Paint += new System.Windows.Forms.PaintEventHandler(this.Canchapelota_Paint);
            // 
            // botondibujar
            // 
            this.botondibujar.Location = new System.Drawing.Point(505, 401);
            this.botondibujar.Name = "botondibujar";
            this.botondibujar.Size = new System.Drawing.Size(118, 37);
            this.botondibujar.TabIndex = 2;
            this.botondibujar.Text = "botondibujar";
            this.botondibujar.UseVisualStyleBackColor = true;
            this.botondibujar.Click += new System.EventHandler(this.botondibujar_Click);
            // 
            // timeranimacion
            // 
            this.timeranimacion.Enabled = true;
            this.timeranimacion.Interval = 10;
            this.timeranimacion.Tick += new System.EventHandler(this.timeranimacion_Tick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(55, 407);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(55, 16);
            this.label.TabIndex = 3;
            this.label.Text = "angulos";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // FormPelota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.botondibujar);
            this.Controls.Add(this.Canchapelota);
            this.Controls.Add(this.Salirprograma_click);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPelota";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Canchapelota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Salirprograma_click;
        private System.Windows.Forms.PictureBox Canchapelota;
        private System.Windows.Forms.Button botondibujar;
        private System.Windows.Forms.Timer timeranimacion;
        private System.Windows.Forms.Label label;
    }
}

