using EjemploTodoJunto.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjemploTodoJunto.Consultas
{
    public partial class cPersonas : Form
    {
        public cPersonas()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

            if (FiltrarcomboBox.SelectedIndex == 0)
            {
//ponerlo en una funcion
            int id = 0;
            int.TryParse(CriteriotextBox.Text, out id); 

            PersonasdataGridView.DataSource = PersonasBll.GetList(p => p.PersonaId == id);
            }
            
        }
    }
}
