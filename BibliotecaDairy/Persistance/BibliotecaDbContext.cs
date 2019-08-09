using BibliotecaDairy.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaDairy.Persistance
{
    public class BibliotecaDbContext : DbContext
    {
        public BibliotecaDbContext(DbContextOptions opciones): base(opciones)
        {

        }

        public virtual DbSet<Libro> Libro { get; set; }
        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<Genero> Genero { get; set; }
        public virtual DbSet<Editoria> Editoria { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            new Libro.map(model.Entity<Libro>());
            new Autor.map(model.Entity<Autor>());
            new Genero.map(model.Entity<Genero>());
            new Editoria.map(model.Entity<Editoria>());
            base.OnModelCreating(model);

        }

    }
}
