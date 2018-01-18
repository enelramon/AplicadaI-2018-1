using EjemploTodoJunto.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjemploTodoJunto
{
    public partial class rPersonas : Form
    {
        public rPersonas()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Personas persona = LlenaClase();

            if (PersonasBll.Guardar(persona))
                MessageBox.Show("Guardooooooo!!!!!");

        }

        private Personas LlenaClase()
        {
            Personas persona = new Personas();

            persona.PersonaId = 0;
            persona.Nombres = NombrestextBox.Text;

            return persona;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Consultas.cPersonas cpersonas = new Consultas.cPersonas();
            cpersonas.Show();
        }
    }
}
