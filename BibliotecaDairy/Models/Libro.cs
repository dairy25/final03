using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaDairy.Models
{

    public class Libro
    {
        public int Idlibro { get; set; }
        public string nombre { get; set; }
        public string sipnosis { get; set; }
        public string contenido { get; set; }
        public int Idautor { get; set; }
        public int Idgenero { get; set; }
        public int Ideditoria { get; set; }
        public Autor Autor { get; set; }
        public Genero Genero { get; set; }
        public Editoria Editoria { get; set; }

        public class map
        {
            public map(EntityTypeBuilder<Libro> lb)
            {
                lb.HasKey(x => x.Idlibro);
                lb.Property(x => x.nombre).HasMaxLength(100).HasColumnName("nombre");
                lb.Property(x => x.sipnosis).HasMaxLength(700).HasColumnName("sipnosis");
                lb.Property(x => x.contenido).HasMaxLength(10000).HasColumnName("contenido");
                lb.Property(x => x.Idautor).HasColumnType("int");
                lb.Property(x => x.Idgenero).HasColumnType("int");
                lb.Property(x => x.Ideditoria).HasColumnType("int");
                lb.HasOne(x => x.Autor);
                lb.HasOne(x => x.Genero);
                lb.HasOne(x => x.Editoria);

            }
        }
    }       
}
