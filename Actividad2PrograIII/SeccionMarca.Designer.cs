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
            this.panelMarcas.Margin = new System.Windows.Forms.Padding(2);
            this.panelMarcas.Name = "panelMarcas";
            this.panelMarcas.Size = new System.Drawing.Size(846, 48);
            this.panelMarcas.TabIndex = 1;
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcas.Location = new System.Drawing.Point(2, 12);
            this.lblMarcas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(136, 31);
            this.lblMarcas.TabIndex = 1;
            this.lblMarcas.Text = "MARCAS";
            // 
            // lblBuscarMarca
            // 
            this.lblBuscarMarca.AutoSize = true;
            this.lblBuscarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarMarca.Location = new System.Drawing.Point(11, 63);
            this.lblBuscarMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarMarca.Name = "lblBuscarMarca";
            this.lblBuscarMarca.Size = new System.Drawing.Size(70, 20);
            this.lblBuscarMarca.TabIndex = 2;
            this.lblBuscarMarca.Text = "Buscar:";
            // 
            // txtBoxBusMarca
            // 
            this.txtBoxBusMarca.Location = new System.Drawing.Point(85, 63);
            this.txtBoxBusMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxBusMarca.Name = "txtBoxBusMarca";
            this.txtBoxBusMarca.Size = new System.Drawing.Size(138, 20);
            this.txtBoxBusMarca.TabIndex = 7;
            this.txtBoxBusMarca.TextChanged += new System.EventHandler(this.txtBoxBusMarca_TextChanged);
            this.txtBoxBusMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBusMarca_KeyPress);
            // 
            // btnBuscarMarca
            // 
            this.btnBuscarMarca.Location = new System.Drawing.Point(239, 61);
            this.btnBuscarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarMarca.Name = "btnBuscarMarca";
            this.btnBuscarMarca.Size = new System.Drawing.Size(69, 27);
            this.btnBuscarMarca.TabIndex = 8;
            this.btnBuscarMarca.Text = "Buscar";
            this.btnBuscarMarca.UseVisualStyleBackColor = true;
            this.btnBuscarMarca.Click += new System.EventHandler(this.btnBuscarMarca_Click);
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarcas.Location = new System.Drawing.Point(15, 132);
            this.dgvMarcas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMarcas.MultiSelect = false;
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 62;
            this.dgvMarcas.RowTemplate.Height = 28;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(531, 209);
            this.dgvMarcas.TabIndex = 14;
            // 
            // lblFiltrarMarca
            // 
            this.lblFiltrarMarca.AutoSize = true;
            this.lblFiltrarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarMarca.Location = new System.Drawing.Point(332, 63);
            this.lblFiltrarMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltrarMarca.Name = "lblFiltrarMarca";
            this.lblFiltrarMarca.Size = new System.Drawing.Size(61, 20);
            this.lblFiltrarMarca.TabIndex = 15;
            this.lblFiltrarMarca.Text = "Filtrar:";
            // 
            // txtboxFiltrarMarca
            // 
            this.txtboxFiltrarMarca.Location = new System.Drawing.Point(397, 63);
            this.txtboxFiltrarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxFiltrarMarca.Name = "txtboxFiltrarMarca";
            this.txtboxFiltrarMarca.Size = new System.Drawing.Size(138, 20);
            this.txtboxFiltrarMarca.TabIndex = 16;
            // 
            // btnFiltrarMarca
            // 
            this.btnFiltrarMarca.Location = new System.Drawing.Point(551, 61);
            this.btnFiltrarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrarMarca.Name = "btnFiltrarMarca";
            this.btnFiltrarMarca.Size = new System.Drawing.Size(69, 27);
            this.btnFiltrarMarca.TabIndex = 17;
            this.btnFiltrarMarca.Text = "Filtrar";
            this.btnFiltrarMarca.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarMarca
            // 
            this.btnLimpiarMarca.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLimpiarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarMarca.Location = new System.Drawing.Point(652, 58);
            this.btnLimpiarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarMarca.Name = "btnLimpiarMarca";
            this.btnLimpiarMarca.Size = new System.Drawing.Size(79, 31);
            this.btnLimpiarMarca.TabIndex = 18;
            this.btnLimpiarMarca.Text = "Limpiar";
            this.btnLimpiarMarca.UseVisualStyleBackColor = false;
            // 
            // pictureBoxMarca
            // 
            this.pictureBoxMarca.BackColor = System.Drawing.Color.Ivory;
            this.pictureBoxMarca.Location = new System.Drawing.Point(594, 132);
            this.pictureBoxMarca.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxMarca.Name = "pictureBoxMarca";
            this.pictureBoxMarca.Size = new System.Drawing.Size(195, 209);
            this.pictureBoxMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMarca.TabIndex = 19;
            this.pictureBoxMarca.TabStop = false;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMarca.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnAgregarMarca.Location = new System.Drawing.Point(15, 376);
            this.btnAgregarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(144, 32);
            this.btnAgregarMarca.TabIndex = 20;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarMarca.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnEditarMarca.Location = new System.Drawing.Point(179, 376);
            this.btnEditarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.Size = new System.Drawing.Size(144, 32);
            this.btnEditarMarca.TabIndex = 21;
            this.btnEditarMarca.Text = "Editar";
            this.btnEditarMarca.UseVisualStyleBackColor = true;
            this.btnEditarMarca.Click += new System.EventHandler(this.btnEditarMarca_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMarca.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnEliminarMarca.Location = new System.Drawing.Point(345, 376);
            this.btnEliminarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(144, 32);
            this.btnEliminarMarca.TabIndex = 22;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // SeccionMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(846, 427);
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
            this.Location = new System.Drawing.Point(5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeccionMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seccion Marca";
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