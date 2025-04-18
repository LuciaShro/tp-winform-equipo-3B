namespace Actividad2PrograIII
{
    partial class SeccionMarca
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
            this.panelMarcas = new System.Windows.Forms.Panel();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.lblBuscarMarca = new System.Windows.Forms.Label();
            this.txtBoxBusMarca = new System.Windows.Forms.TextBox();
            this.btnBuscarMarca = new System.Windows.Forms.Button();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.lblFiltrarMarca = new System.Windows.Forms.Label();
            this.txtboxFiltrarMarca = new System.Windows.Forms.TextBox();
            this.btnFiltrarMarca = new System.Windows.Forms.Button();
            this.btnLimpiarMarca = new System.Windows.Forms.Button();
            this.pictureBoxMarca = new System.Windows.Forms.PictureBox();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnEditarMarca = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.panelMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMarcas
            // 
            this.panelMarcas.BackColor = System.Drawing.Color.CadetBlue;
            this.panelMarcas.Controls.Add(this.lblMarcas);
            this.panelMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMarcas.Location = new System.Drawing.Point(0, 0);
            this.panelMarcas.Name = "panelMarcas";
            this.panelMarcas.Size = new System.Drawing.Size(1200, 74);
            this.panelMarcas.TabIndex = 1;
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcas.Location = new System.Drawing.Point(3, 18);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(198, 46);
            this.lblMarcas.TabIndex = 1;
            this.lblMarcas.Text = "MARCAS";
            // 
            // lblBuscarMarca
            // 
            this.lblBuscarMarca.AutoSize = true;
            this.lblBuscarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarMarca.Location = new System.Drawing.Point(16, 97);
            this.lblBuscarMarca.Name = "lblBuscarMarca";
            this.lblBuscarMarca.Size = new System.Drawing.Size(100, 29);
            this.lblBuscarMarca.TabIndex = 2;
            this.lblBuscarMarca.Text = "Buscar:";
            // 
            // txtBoxBusMarca
            // 
            this.txtBoxBusMarca.Location = new System.Drawing.Point(128, 97);
            this.txtBoxBusMarca.Name = "txtBoxBusMarca";
            this.txtBoxBusMarca.Size = new System.Drawing.Size(205, 26);
            this.txtBoxBusMarca.TabIndex = 7;
            // 
            // btnBuscarMarca
            // 
            this.btnBuscarMarca.Location = new System.Drawing.Point(358, 94);
            this.btnBuscarMarca.Name = "btnBuscarMarca";
            this.btnBuscarMarca.Size = new System.Drawing.Size(104, 42);
            this.btnBuscarMarca.TabIndex = 8;
            this.btnBuscarMarca.Text = "Buscar";
            this.btnBuscarMarca.UseVisualStyleBackColor = true;
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarcas.Location = new System.Drawing.Point(22, 203);
            this.dgvMarcas.MultiSelect = false;
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 62;
            this.dgvMarcas.RowTemplate.Height = 28;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(796, 322);
            this.dgvMarcas.TabIndex = 14;
            // 
            // lblFiltrarMarca
            // 
            this.lblFiltrarMarca.AutoSize = true;
            this.lblFiltrarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarMarca.Location = new System.Drawing.Point(498, 97);
            this.lblFiltrarMarca.Name = "lblFiltrarMarca";
            this.lblFiltrarMarca.Size = new System.Drawing.Size(89, 29);
            this.lblFiltrarMarca.TabIndex = 15;
            this.lblFiltrarMarca.Text = "Filtrar:";
            // 
            // txtboxFiltrarMarca
            // 
            this.txtboxFiltrarMarca.Location = new System.Drawing.Point(596, 97);
            this.txtboxFiltrarMarca.Name = "txtboxFiltrarMarca";
            this.txtboxFiltrarMarca.Size = new System.Drawing.Size(205, 26);
            this.txtboxFiltrarMarca.TabIndex = 16;
            // 
            // btnFiltrarMarca
            // 
            this.btnFiltrarMarca.Location = new System.Drawing.Point(826, 94);
            this.btnFiltrarMarca.Name = "btnFiltrarMarca";
            this.btnFiltrarMarca.Size = new System.Drawing.Size(104, 42);
            this.btnFiltrarMarca.TabIndex = 17;
            this.btnFiltrarMarca.Text = "Filtrar";
            this.btnFiltrarMarca.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarMarca
            // 
            this.btnLimpiarMarca.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLimpiarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarMarca.Location = new System.Drawing.Point(978, 89);
            this.btnLimpiarMarca.Name = "btnLimpiarMarca";
            this.btnLimpiarMarca.Size = new System.Drawing.Size(118, 48);
            this.btnLimpiarMarca.TabIndex = 18;
            this.btnLimpiarMarca.Text = "Limpiar";
            this.btnLimpiarMarca.UseVisualStyleBackColor = false;
            // 
            // pictureBoxMarca
            // 
            this.pictureBoxMarca.BackColor = System.Drawing.Color.Ivory;
            this.pictureBoxMarca.Location = new System.Drawing.Point(891, 203);
            this.pictureBoxMarca.Name = "pictureBoxMarca";
            this.pictureBoxMarca.Size = new System.Drawing.Size(292, 322);
            this.pictureBoxMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMarca.TabIndex = 19;
            this.pictureBoxMarca.TabStop = false;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMarca.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnAgregarMarca.Location = new System.Drawing.Point(22, 578);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(216, 49);
            this.btnAgregarMarca.TabIndex = 20;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarMarca.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnEditarMarca.Location = new System.Drawing.Point(268, 578);
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.Size = new System.Drawing.Size(216, 49);
            this.btnEditarMarca.TabIndex = 21;
            this.btnEditarMarca.Text = "Editar";
            this.btnEditarMarca.UseVisualStyleBackColor = true;
            this.btnEditarMarca.Click += new System.EventHandler(this.btnEditarMarca_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMarca.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnEliminarMarca.Location = new System.Drawing.Point(518, 578);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(216, 49);
            this.btnEliminarMarca.TabIndex = 22;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            // 
            // SeccionMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnEditarMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.pictureBoxMarca);
            this.Controls.Add(this.btnLimpiarMarca);
            this.Controls.Add(this.btnFiltrarMarca);
            this.Controls.Add(this.txtboxFiltrarMarca);
            this.Controls.Add(this.lblFiltrarMarca);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.btnBuscarMarca);
            this.Controls.Add(this.txtBoxBusMarca);
            this.Controls.Add(this.lblBuscarMarca);
            this.Controls.Add(this.panelMarcas);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SeccionMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeccionMarca";
            this.Load += new System.EventHandler(this.SeccionMarca_Load);
            this.panelMarcas.ResumeLayout(false);
            this.panelMarcas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMarcas;
        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.Label lblBuscarMarca;
        private System.Windows.Forms.TextBox txtBoxBusMarca;
        private System.Windows.Forms.Button btnBuscarMarca;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Label lblFiltrarMarca;
        private System.Windows.Forms.TextBox txtboxFiltrarMarca;
        private System.Windows.Forms.Button btnFiltrarMarca;
        private System.Windows.Forms.Button btnLimpiarMarca;
        private System.Windows.Forms.PictureBox pictureBoxMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnEditarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
    }
}