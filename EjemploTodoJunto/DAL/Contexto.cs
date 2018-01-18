﻿using System;
using System.Data.Entity;

namespace EjemploTodoJunto
{
    /// <summary>
    /// Esta clase es el contexto que nos permite conectarnos a la base de datos
    /// Solo necesitamos crear las entidades con las que interactuaremos
    /// Ademas hay que indicarle el conexion string que permite llegar a la data
    /// </summary>
    public class Contexto : DbContext
    {
        public DbSet<Personas> Persona { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }


}
