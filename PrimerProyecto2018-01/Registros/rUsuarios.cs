using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerProyecto2018_01.Registros
{
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ClavetextBox.Text) || String.IsNullOrWhiteSpace(ConfirmarClavetextBox.Text))
            {
                MessageBox.Show("No puede dejar las clave vacias", "Error de validación");
                errorProvider1.SetError(ClavetextBox, "No puede estar vacio");
                ClavetextBox.Focus();
            }

            else if (!ClavetextBox.Text.Equals(ConfirmarClavetextBox.Text))
                MessageBox.Show("las claves no son iguales.", "Error de validación");

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.Load(openFileDialog1.FileName);
        }
    }
}
