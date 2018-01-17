using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimerProyecto2018_01.DAL;
using PrimerProyecto2018_01.Entidades;

namespace PrimerProyecto2018_01.Registros
{
    public partial class rPersonas : Form
    {
        public rPersonas()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            PersonasDb db = new PersonasDb();

            //ponerlo en una funcion
            int PersonaId = 0;
            int.TryParse(PersonaIdtextBox.Text, out PersonaId);

            Entidades.Personas persona = new Personas();

            persona = db.Persona.Find(PersonaId);
            if (persona == null)
            {
                MessageBox.Show("Persona No encontada");
            }
            else
            {
                //Llenar Campos
                NombrestextBox.Text = persona.Nombres;
            }
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            PersonasDb db = new PersonasDb();

            Entidades.Personas persona = new Personas();

            //Funcion LlenarClase
            persona.PersonaId = 0;
            persona.Nombres = NombrestextBox.Text;

            db.Persona.Add(persona);
            db.SaveChanges();

        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            int PersonaId = 0;
            PersonasDb db = new PersonasDb();

            int.TryParse(PersonaIdtextBox.Text, out PersonaId);


            var persona = db.Persona.Find(PersonaId);

            persona.Nombres = NombrestextBox.Text;

            db.Entry(persona).State = EntityState.Modified;
            db.SaveChanges();

        }


        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int PersonaId = 0;
            PersonasDb db = new PersonasDb();

            int.TryParse(PersonaIdtextBox.Text, out PersonaId);

            var persona = db.Persona.Find(PersonaId);

            db.Persona.Remove(persona);
            db.SaveChanges();
        }
    }
}
