namespace Actividad2PrograIII
{
    partial class SeccionArticulos
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
            this.panelArticulos = new System.Windows.Forms.Panel();
            this.lblArticulos = new System.Windows.Forms.Label();
            this.lblBuscarArt = new System.Windows.Forms.Label();
            this.btnFiltroArt = new System.Windows.Forms.Button();
            this.btnLimpiarArt = new System.Windows.Forms.Button();
            this.txtBoxBuscarArt = new System.Windows.Forms.TextBox();
            this.btnAgregarArt = new System.Windows.Forms.Button();
            this.btnEditarArt = new System.Windows.Forms.Button();
            this.btnEliminarArt = new System.Windows.Forms.Button();
            this.pictureBoxArt = new System.Windows.Forms.PictureBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.txtFlitro = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.panelArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelArticulos
            // 
            this.panelArticulos.BackColor = System.Drawing.Color.CadetBlue;
            this.panelArticulos.Controls.Add(this.lblArticulos);
            this.panelArticulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelArticulos.Location = new System.Drawing.Point(0, 0);
            this.panelArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.panelArticulos.Name = "panelArticulos";
            this.panelArticulos.Size = new System.Drawing.Size(771, 48);
            this.panelArticulos.TabIndex = 0;
            // 
            // lblArticulos
            // 
            this.lblArticulos.AutoSize = true;
            this.lblArticulos.Font = new System.Drawing.Font("Myanmar Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


            this.lblArticulos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            //this.lblArticulos.Location = new System.Drawing.Point(3, 9);

            this.lblArticulos.Location = new System.Drawing.Point(2, 6);
            this.lblArticulos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);

            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(168, 48);
            this.lblArticulos.TabIndex = 1;
            this.lblArticulos.Text = "ARTICULOS";
            // 
            // lblBuscarArt
            // 
            this.lblBuscarArt.AutoSize = true;
            this.lblBuscarArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarArt.Location = new System.Drawing.Point(8, 62);
            this.lblBuscarArt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarArt.Name = "lblBuscarArt";
            this.lblBuscarArt.Size = new System.Drawing.Size(70, 20);
            this.lblBuscarArt.TabIndex = 1;
            this.lblBuscarArt.Text = "Buscar:";
            // 
            // btnFiltroArt
            // 
            this.btnFiltroArt.Location = new System.Drawing.Point(222, 58);
            this.btnFiltroArt.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltroArt.Name = "btnFiltroArt";
            this.btnFiltroArt.Size = new System.Drawing.Size(69, 27);
            this.btnFiltroArt.TabIndex = 3;
            this.btnFiltroArt.Text = "Buscar";
            this.btnFiltroArt.UseVisualStyleBackColor = true;

            this.btnFiltroArt.Click += new System.EventHandler(this.btnFiltroArt_Click);

            // 
            // btnLimpiarArt
            // 
            this.btnLimpiarArt.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLimpiarArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarArt.Location = new System.Drawing.Point(662, 55);
            this.btnLimpiarArt.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarArt.Name = "btnLimpiarArt";
            this.btnLimpiarArt.Size = new System.Drawing.Size(79, 31);
            this.btnLimpiarArt.TabIndex = 5;
            this.btnLimpiarArt.Text = "Limpiar";
            this.btnLimpiarArt.UseVisualStyleBackColor = false;
            // 
            // txtBoxBuscarArt
            // 

            this.txtBoxBuscarArt.Location = new System.Drawing.Point(80, 62);
            this.txtBoxBuscarArt.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxBuscarArt.Name = "txtBoxBuscarArt";
            this.txtBoxBuscarArt.Size = new System.Drawing.Size(138, 20);
            this.txtBoxBuscarArt.TabIndex = 6;
            this.txtBoxBuscarArt.TextChanged += new System.EventHandler(this.txtBoxBuscarArt_TextChanged);

            // 
            // btnAgregarArt
            // 
            this.btnAgregarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarArt.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnAgregarArt.Location = new System.Drawing.Point(26, 401);
            this.btnAgregarArt.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarArt.Name = "btnAgregarArt";
            this.btnAgregarArt.Size = new System.Drawing.Size(144, 32);
            this.btnAgregarArt.TabIndex = 9;
            this.btnAgregarArt.Text = "Agregar";
            this.btnAgregarArt.UseVisualStyleBackColor = true;
            this.btnAgregarArt.Click += new System.EventHandler(this.btnAgregarArt_Click);
            // 
            // btnEditarArt
            // 
            this.btnEditarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarArt.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnEditarArt.Location = new System.Drawing.Point(204, 401);
            this.btnEditarArt.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarArt.Name = "btnEditarArt";
            this.btnEditarArt.Size = new System.Drawing.Size(144, 32);
            this.btnEditarArt.TabIndex = 10;
            this.btnEditarArt.Text = "Editar";
            this.btnEditarArt.UseVisualStyleBackColor = true;
            this.btnEditarArt.Click += new System.EventHandler(this.btnEditarArt_Click);
            // 
            // btnEliminarArt
            // 
            this.btnEliminarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarArt.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnEliminarArt.Location = new System.Drawing.Point(371, 401);
            this.btnEliminarArt.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarArt.Name = "btnEliminarArt";
            this.btnEliminarArt.Size = new System.Drawing.Size(144, 32);
            this.btnEliminarArt.TabIndex = 11;
            this.btnEliminarArt.Text = "Eliminar";
            this.btnEliminarArt.UseVisualStyleBackColor = true;
            this.btnEliminarArt.Click += new System.EventHandler(this.btnEliminarArt_Click);
            // 
            // pictureBoxArt
            // 
            this.pictureBoxArt.BackColor = System.Drawing.Color.Ivory;
            this.pictureBoxArt.Location = new System.Drawing.Point(565, 176);
            this.pictureBoxArt.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxArt.Name = "pictureBoxArt";
            this.pictureBoxArt.Size = new System.Drawing.Size(195, 209);
            this.pictureBoxArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArt.TabIndex = 12;
            this.pictureBoxArt.TabStop = false;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(10, 176);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 62;
            this.dgvArticulos.RowTemplate.Height = 28;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(531, 209);
            this.dgvArticulos.TabIndex = 13;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCampo.Location = new System.Drawing.Point(6, 111);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(70, 20);
            this.lblCampo.TabIndex = 14;
            this.lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCriterio.Location = new System.Drawing.Point(224, 111);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(72, 20);
            this.lblCriterio.TabIndex = 15;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFiltro.Location = new System.Drawing.Point(444, 111);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(55, 20);
            this.lblFiltro.TabIndex = 16;
            this.lblFiltro.Text = "Filtro:";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(80, 110);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(138, 21);
            this.cboCampo.TabIndex = 17;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(302, 110);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(138, 21);
            this.cboCriterio.TabIndex = 18;
            // 
            // txtFlitro
            // 
            this.txtFlitro.Location = new System.Drawing.Point(505, 111);
            this.txtFlitro.Name = "txtFlitro";
            this.txtFlitro.Size = new System.Drawing.Size(138, 20);
            this.txtFlitro.TabIndex = 19;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(649, 110);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(92, 23);
            this.btnFiltrar.TabIndex = 20;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // SeccionArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 509);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtFlitro);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.pictureBoxArt);
            this.Controls.Add(this.btnEliminarArt);
            this.Controls.Add(this.btnEditarArt);
            this.Controls.Add(this.btnAgregarArt);
            this.Controls.Add(this.txtBoxBuscarArt);
            this.Controls.Add(this.btnLimpiarArt);
            this.Controls.Add(this.btnFiltroArt);
            this.Controls.Add(this.lblBuscarArt);
            this.Controls.Add(this.panelArticulos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SeccionArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeccionArticulos";
            this.Load += new System.EventHandler(this.SeccionArticulos_Load);
            this.panelArticulos.ResumeLayout(false);
            this.panelArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelArticulos;
        private System.Windows.Forms.Label lblArticulos;
        private System.Windows.Forms.Label lblBuscarArt;
        private System.Windows.Forms.Button btnFiltroArt;
        private System.Windows.Forms.Button btnLimpiarArt;
        private System.Windows.Forms.TextBox txtBoxBuscarArt;
        private System.Windows.Forms.Button btnAgregarArt;
        private System.Windows.Forms.Button btnEditarArt;
        private System.Windows.Forms.Button btnEliminarArt;
        private System.Windows.Forms.PictureBox pictureBoxArt;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.TextBox txtFlitro;
        private System.Windows.Forms.Button btnFiltrar;
    }
}