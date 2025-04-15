using Gestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2PrograIII
{
    public partial class SeccionMarca : Form
    {
        public SeccionMarca()
        {
            InitializeComponent();
        }

        private void SeccionMarca_Load(object sender, EventArgs e)
        {
            GestionMarca marca = new GestionMarca();
            dgvMarcas.DataSource = marca.listarMarca();

        }
    }
}
