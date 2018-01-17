using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto2018_01.Entidades
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }
        public string Nombres { get; set; }

        public Personas()
        {
            this.PersonaId = 0;
            this.Nombres = string.Empty;
        }

        public Personas(int personaId, string nombres)
        {
            this.PersonaId = personaId;
            this.Nombres = nombres;
        }
    }
}
