namespace Actividad2PrograIII
{
    partial class SeccionCategorias
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
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.lblBuscarCategoria = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscarCategoria = new System.Windows.Forms.Button();
            this.lblFiltrarCategoria = new System.Windows.Forms.Label();
            this.txtboxFiltrarCategoria = new System.Windows.Forms.TextBox();
            this.btnFiltrarCategoria = new System.Windows.Forms.Button();
            this.btnLimpiarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnEditarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoriaFisico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategorias.Location = new System.Drawing.Point(169, 212);
            this.dgvCategorias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 62;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(794, 312);
            this.dgvCategorias.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.lblCategorias);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 74);
            this.panel1.TabIndex = 2;
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Font = new System.Drawing.Font("Myanmar Text", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCategorias.Location = new System.Drawing.Point(3, 9);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(291, 75);
            this.lblCategorias.TabIndex = 1;
            this.lblCategorias.Text = "CATEGORIAS";
            // 
            // lblBuscarCategoria
            // 
            this.lblBuscarCategoria.AutoSize = true;
            this.lblBuscarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCategoria.Location = new System.Drawing.Point(545, 136);
            this.lblBuscarCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarCategoria.Name = "lblBuscarCategoria";
            this.lblBuscarCategoria.Size = new System.Drawing.Size(100, 29);
            this.lblBuscarCategoria.TabIndex = 3;
            this.lblBuscarCategoria.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(643, 137);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(205, 26);
            this.txtBuscar.TabIndex = 4;
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.Location = new System.Drawing.Point(859, 129);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Size = new System.Drawing.Size(104, 42);
            this.btnBuscarCategoria.TabIndex = 5;
            this.btnBuscarCategoria.Text = "Buscar";
            this.btnBuscarCategoria.UseVisualStyleBackColor = true;
            // 
            // lblFiltrarCategoria
            // 
            this.lblFiltrarCategoria.AutoSize = true;
            this.lblFiltrarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarCategoria.Location = new System.Drawing.Point(65, 137);
            this.lblFiltrarCategoria.Name = "lblFiltrarCategoria";
            this.lblFiltrarCategoria.Size = new System.Drawing.Size(89, 29);
            this.lblFiltrarCategoria.TabIndex = 6;
            this.lblFiltrarCategoria.Text = "Filtrar:";
            // 
            // txtboxFiltrarCategoria
            // 
            this.txtboxFiltrarCategoria.Location = new System.Drawing.Point(155, 140);
            this.txtboxFiltrarCategoria.Name = "txtboxFiltrarCategoria";
            this.txtboxFiltrarCategoria.Size = new System.Drawing.Size(205, 26);
            this.txtboxFiltrarCategoria.TabIndex = 8;
            this.txtboxFiltrarCategoria.TextChanged += new System.EventHandler(this.txtboxFiltrarCategoria_TextChanged);
            this.txtboxFiltrarCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxFiltrarCategoria_KeyPress);
            // 
            // btnFiltrarCategoria
            // 
            this.btnFiltrarCategoria.Location = new System.Drawing.Point(383, 132);
            this.btnFiltrarCategoria.Name = "btnFiltrarCategoria";
            this.btnFiltrarCategoria.Size = new System.Drawing.Size(104, 42);
            this.btnFiltrarCategoria.TabIndex = 9;
            this.btnFiltrarCategoria.Text = "Filtrar";
            this.btnFiltrarCategoria.UseVisualStyleBackColor = true;
            this.btnFiltrarCategoria.Click += new System.EventHandler(this.btnFiltrarCategoria_Click);
            // 
            // btnLimpiarCategoria
            // 
            this.btnLimpiarCategoria.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLimpiarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCategoria.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarCategoria.Location = new System.Drawing.Point(1008, 123);
            this.btnLimpiarCategoria.Name = "btnLimpiarCategoria";
            this.btnLimpiarCategoria.Size = new System.Drawing.Size(118, 48);
            this.btnLimpiarCategoria.TabIndex = 10;
            this.btnLimpiarCategoria.Text = "Limpiar";
            this.btnLimpiarCategoria.UseVisualStyleBackColor = false;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategoria.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(144, 589);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(216, 49);
            this.btnAgregarCategoria.TabIndex = 11;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCategoria.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnEditarCategoria.Location = new System.Drawing.Point(476, 589);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(216, 49);
            this.btnEditarCategoria.TabIndex = 12;
            this.btnEditarCategoria.Text = "Editar";
            this.btnEditarCategoria.UseVisualStyleBackColor = true;
            this.btnEditarCategoria.Click += new System.EventHandler(this.btnEditarCategoria_Click);
            // 
            // btnEliminarCategoriaFisico
            // 
            this.btnEliminarCategoriaFisico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCategoriaFisico.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnEliminarCategoriaFisico.Location = new System.Drawing.Point(815, 589);
            this.btnEliminarCategoriaFisico.Name = "btnEliminarCategoriaFisico";
            this.btnEliminarCategoriaFisico.Size = new System.Drawing.Size(216, 49);
            this.btnEliminarCategoriaFisico.TabIndex = 13;
            this.btnEliminarCategoriaFisico.Text = "Eliminar";
            this.btnEliminarCategoriaFisico.UseVisualStyleBackColor = true;
            this.btnEliminarCategoriaFisico.Click += new System.EventHandler(this.btnEliminarCategoriaFisico_Click);
            // 
            // SeccionCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnEliminarCategoriaFisico);
            this.Controls.Add(this.btnEditarCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.btnLimpiarCategoria);
            this.Controls.Add(this.btnFiltrarCategoria);
            this.Controls.Add(this.txtboxFiltrarCategoria);
            this.Controls.Add(this.lblFiltrarCategoria);
            this.Controls.Add(this.btnBuscarCategoria);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscarCategoria);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCategorias);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SeccionCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeccionCategorias";
            this.Load += new System.EventHandler(this.SeccionCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.Label lblBuscarCategoria;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscarCategoria;
        private System.Windows.Forms.Label lblFiltrarCategoria;
        private System.Windows.Forms.TextBox txtboxFiltrarCategoria;
        private System.Windows.Forms.Button btnFiltrarCategoria;
        private System.Windows.Forms.Button btnLimpiarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnEditarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoriaFisico;
    }
}