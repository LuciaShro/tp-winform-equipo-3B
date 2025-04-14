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
    public partial class SeccionCategorias : Form
    {
        public SeccionCategorias()
        {
            InitializeComponent();
        }

        private void SeccionCategorias_Load(object sender, EventArgs e)
        {
            GestionCategoria categoria = new GestionCategoria();
            dgvCategorias.DataSource = categoria.listarCategoria();
        }
    }
}
