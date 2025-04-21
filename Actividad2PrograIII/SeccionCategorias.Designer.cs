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
            this.lblFiltrarCategoria = new System.Windows.Forms.Label();
            this.txtboxFiltrarCategoria = new System.Windows.Forms.TextBox();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnEditarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoriaFisico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvCategorias.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategorias.Location = new System.Drawing.Point(113, 138);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 62;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(529, 203);
            this.dgvCategorias.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.lblCategorias);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 48);
            this.panel1.TabIndex = 2;
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Font = new System.Drawing.Font("Myanmar Text", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCategorias.Location = new System.Drawing.Point(2, 6);
            this.lblCategorias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(194, 50);
            this.lblCategorias.TabIndex = 1;
            this.lblCategorias.Text = "CATEGORIAS";
            // 
            // lblFiltrarCategoria
            // 
            this.lblFiltrarCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFiltrarCategoria.AutoSize = true;
            this.lblFiltrarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarCategoria.Location = new System.Drawing.Point(109, 102);
            this.lblFiltrarCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltrarCategoria.Name = "lblFiltrarCategoria";
            this.lblFiltrarCategoria.Size = new System.Drawing.Size(70, 20);
            this.lblFiltrarCategoria.TabIndex = 6;
            this.lblFiltrarCategoria.Text = "Buscar:";
            // 
            // txtboxFiltrarCategoria
            // 
            this.txtboxFiltrarCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtboxFiltrarCategoria.Location = new System.Drawing.Point(180, 104);
            this.txtboxFiltrarCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtboxFiltrarCategoria.Name = "txtboxFiltrarCategoria";
            this.txtboxFiltrarCategoria.Size = new System.Drawing.Size(138, 20);
            this.txtboxFiltrarCategoria.TabIndex = 0;
            this.txtboxFiltrarCategoria.TextChanged += new System.EventHandler(this.txtboxFiltrarCategoria_TextChanged);
            this.txtboxFiltrarCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxFiltrarCategoria_KeyPress);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategoria.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(96, 383);
            this.btnAgregarCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(144, 32);
            this.btnAgregarCategoria.TabIndex = 1;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCategoria.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnEditarCategoria.Location = new System.Drawing.Point(325, 383);
            this.btnEditarCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(144, 32);
            this.btnEditarCategoria.TabIndex = 2;
            this.btnEditarCategoria.Text = "Editar";
            this.btnEditarCategoria.UseVisualStyleBackColor = true;
            this.btnEditarCategoria.Click += new System.EventHandler(this.btnEditarCategoria_Click);
            // 
            // btnEliminarCategoriaFisico
            // 
            this.btnEliminarCategoriaFisico.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminarCategoriaFisico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCategoriaFisico.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnEliminarCategoriaFisico.Location = new System.Drawing.Point(543, 383);
            this.btnEliminarCategoriaFisico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarCategoriaFisico.Name = "btnEliminarCategoriaFisico";
            this.btnEliminarCategoriaFisico.Size = new System.Drawing.Size(144, 32);
            this.btnEliminarCategoriaFisico.TabIndex = 3;
            this.btnEliminarCategoriaFisico.Text = "Eliminar";
            this.btnEliminarCategoriaFisico.UseVisualStyleBackColor = true;
            this.btnEliminarCategoriaFisico.Click += new System.EventHandler(this.btnEliminarCategoriaFisico_Click);
            // 
            // SeccionCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarCategoriaFisico);
            this.Controls.Add(this.btnEditarCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.txtboxFiltrarCategoria);
            this.Controls.Add(this.lblFiltrarCategoria);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCategorias);
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
        private System.Windows.Forms.Label lblFiltrarCategoria;
        private System.Windows.Forms.TextBox txtboxFiltrarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnEditarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoriaFisico;
    }
}