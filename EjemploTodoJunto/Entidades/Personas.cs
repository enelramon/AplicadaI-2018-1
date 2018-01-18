using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace EjemploTodoJunto
{
    public class Personas
    {
        [Key]//Es obligatorio indicar cual es la clave primaria de la entidad
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
