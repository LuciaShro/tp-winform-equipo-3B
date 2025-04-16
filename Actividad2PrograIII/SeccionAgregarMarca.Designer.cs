namespace Actividad2PrograIII
{
    partial class SeccionAgregarMarca
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
            this.pnlAgregarMarca = new System.Windows.Forms.Panel();
            this.lblAgregrMarca = new System.Windows.Forms.Label();
            this.lblDescripcionMarca = new System.Windows.Forms.Label();
            this.txtDescripcionMarca = new System.Windows.Forms.TextBox();
            this.btnAceptarMarca = new System.Windows.Forms.Button();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.pnlAgregarMarca.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAgregarMarca
            // 
            this.pnlAgregarMarca.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlAgregarMarca.Controls.Add(this.lblAgregrMarca);
            this.pnlAgregarMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAgregarMarca.Location = new System.Drawing.Point(0, 0);
            this.pnlAgregarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAgregarMarca.Name = "pnlAgregarMarca";
            this.pnlAgregarMarca.Size = new System.Drawing.Size(473, 45);
            this.pnlAgregarMarca.TabIndex = 1;
            // 
            // lblAgregrMarca
            // 
            this.lblAgregrMarca.AutoSize = true;
            this.lblAgregrMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregrMarca.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAgregrMarca.Location = new System.Drawing.Point(14, 13);
            this.lblAgregrMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAgregrMarca.Name = "lblAgregrMarca";
            this.lblAgregrMarca.Size = new System.Drawing.Size(113, 20);
            this.lblAgregrMarca.TabIndex = 1;
            this.lblAgregrMarca.Text = "Nueva Marca";
            // 
            // lblDescripcionMarca
            // 
            this.lblDescripcionMarca.AutoSize = true;
            this.lblDescripcionMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionMarca.Location = new System.Drawing.Point(54, 124);
            this.lblDescripcionMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcionMarca.Name = "lblDescripcionMarca";
            this.lblDescripcionMarca.Size = new System.Drawing.Size(98, 17);
            this.lblDescripcionMarca.TabIndex = 11;
            this.lblDescripcionMarca.Text = "Descripción:";
            // 
            // txtDescripcionMarca
            // 
            this.txtDescripcionMarca.Location = new System.Drawing.Point(169, 123);
            this.txtDescripcionMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionMarca.Name = "txtDescripcionMarca";
            this.txtDescripcionMarca.Size = new System.Drawing.Size(210, 20);
            this.txtDescripcionMarca.TabIndex = 15;
            // 
            // btnAceptarMarca
            // 
            this.btnAceptarMarca.BackColor = System.Drawing.SystemColors.Window;
            this.btnAceptarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarMarca.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAceptarMarca.Location = new System.Drawing.Point(117, 346);
            this.btnAceptarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptarMarca.Name = "btnAceptarMarca";
            this.btnAceptarMarca.Size = new System.Drawing.Size(70, 26);
            this.btnAceptarMarca.TabIndex = 19;
            this.btnAceptarMarca.Text = "Aceptar";
            this.btnAceptarMarca.UseVisualStyleBackColor = false;
            this.btnAceptarMarca.Click += new System.EventHandler(this.btnAceptarMarca_Click);
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelarMarca.Location = new System.Drawing.Point(276, 345);
            this.btnCancelarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(68, 27);
            this.btnCancelarMarca.TabIndex = 20;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = false;
            this.btnCancelarMarca.Click += new System.EventHandler(this.btnCancelarMarca_Click);
            // 
            // SeccionAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 425);
            this.Controls.Add(this.btnCancelarMarca);
            this.Controls.Add(this.btnAceptarMarca);
            this.Controls.Add(this.txtDescripcionMarca);
            this.Controls.Add(this.lblDescripcionMarca);
            this.Controls.Add(this.pnlAgregarMarca);
            this.Name = "SeccionAgregarMarca";
            this.Text = "SeccionAgregarMarca";
            this.pnlAgregarMarca.ResumeLayout(false);
            this.pnlAgregarMarca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAgregarMarca;
        private System.Windows.Forms.Label lblAgregrMarca;
        private System.Windows.Forms.Label lblDescripcionMarca;
        private System.Windows.Forms.TextBox txtDescripcionMarca;
        private System.Windows.Forms.Button btnAceptarMarca;
        private System.Windows.Forms.Button btnCancelarMarca;
    }
}