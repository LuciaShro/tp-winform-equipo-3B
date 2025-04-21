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
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnEditarMarca = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.panelMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMarcas
            // 
            this.panelMarcas.BackColor = System.Drawing.Color.CadetBlue;
            this.panelMarcas.Controls.Add(this.lblMarcas);
            this.panelMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMarcas.Location = new System.Drawing.Point(0, 0);
            this.panelMarcas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMarcas.Name = "panelMarcas";
            this.panelMarcas.Size = new System.Drawing.Size(800, 48);
            this.panelMarcas.TabIndex = 1;
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Font = new System.Drawing.Font("Myanmar Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMarcas.Location = new System.Drawing.Point(3, 6);
            this.lblMarcas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(134, 48);
            this.lblMarcas.TabIndex = 2;
            this.lblMarcas.Text = "MARCAS";
            // 
            // lblBuscarMarca
            // 
            this.lblBuscarMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBuscarMarca.AutoSize = true;
            this.lblBuscarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarMarca.Location = new System.Drawing.Point(67, 79);
            this.lblBuscarMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarMarca.Name = "lblBuscarMarca";
            this.lblBuscarMarca.Size = new System.Drawing.Size(70, 20);
            this.lblBuscarMarca.TabIndex = 2;
            this.lblBuscarMarca.Text = "Buscar:";
            // 
            // txtBoxBusMarca
            // 
            this.txtBoxBusMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxBusMarca.Location = new System.Drawing.Point(138, 82);
            this.txtBoxBusMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxBusMarca.Name = "txtBoxBusMarca";
            this.txtBoxBusMarca.Size = new System.Drawing.Size(138, 20);
            this.txtBoxBusMarca.TabIndex = 0;
            this.txtBoxBusMarca.TextChanged += new System.EventHandler(this.txtBoxBusMarca_TextChanged);
            this.txtBoxBusMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBusMarca_KeyPress);
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvMarcas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarcas.Location = new System.Drawing.Point(71, 118);
            this.dgvMarcas.MultiSelect = false;
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 62;
            this.dgvMarcas.RowTemplate.Height = 28;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(531, 209);
            this.dgvMarcas.TabIndex = 14;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMarca.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnAgregarMarca.Location = new System.Drawing.Point(71, 356);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(144, 32);
            this.btnAgregarMarca.TabIndex = 1;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarMarca.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnEditarMarca.Location = new System.Drawing.Point(270, 356);
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.Size = new System.Drawing.Size(144, 32);
            this.btnEditarMarca.TabIndex = 2;
            this.btnEditarMarca.Text = "Editar";
            this.btnEditarMarca.UseVisualStyleBackColor = true;
            this.btnEditarMarca.Click += new System.EventHandler(this.btnEditarMarca_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMarca.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnEliminarMarca.Location = new System.Drawing.Point(457, 356);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(144, 32);
            this.btnEliminarMarca.TabIndex = 3;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // SeccionMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnEditarMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.txtBoxBusMarca);
            this.Controls.Add(this.lblBuscarMarca);
            this.Controls.Add(this.panelMarcas);
            this.Name = "SeccionMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeccionMarca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SeccionMarca_Load);
            this.panelMarcas.ResumeLayout(false);
            this.panelMarcas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMarcas;
        private System.Windows.Forms.Label lblBuscarMarca;
        private System.Windows.Forms.TextBox txtBoxBusMarca;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnEditarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Label lblMarcas;
    }
}