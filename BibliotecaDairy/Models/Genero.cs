using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaDairy.Models
{
    public class Genero
    {
        public int Idgenero { get; set; }
        public string nombre { get; set; }
        public string definicion { get; set; }
        

        public class map
        {
            public map(EntityTypeBuilder<Genero> lb)
            {
                lb.HasKey(x => x.Idgenero);
                lb.Property(x => x.nombre).HasMaxLength(50).HasColumnName("nombre");
                lb.Property(x => x.definicion).HasMaxLength(1000).HasColumnName("definicion");

            }
        }
    }
}
