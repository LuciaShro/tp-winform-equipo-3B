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
    public partial class SeccionArticulos : Form
    {
        public SeccionArticulos()
        {
            InitializeComponent();
        }

        private void SeccionArticulos_Load(object sender, EventArgs e)
        {
            GestionArticulos gestion = new GestionArticulos();
            dgvArticulos.DataSource = gestion.listar(); //DataSourse -> grilla de datos
        }
    }
}
