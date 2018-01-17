using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PrimerProyecto2018_01.Entidades;
namespace PrimerProyecto2018_01.DAL
{
   public class PersonasDb:DbContext
    {
        public DbSet<Personas> Persona { get; set; }

        public PersonasDb():base("ConStr")
        {

        }

           }
}
