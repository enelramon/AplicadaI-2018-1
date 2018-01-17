using PrimerProyecto2018_01.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerProyecto2018_01
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuarios usuarios = new rUsuarios();
            usuarios.MdiParent = this;
            usuarios.Show();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rPersonas rPersonas = new rPersonas();
            rPersonas.MdiParent = this;
            rPersonas.Show();

        }
    }
}
