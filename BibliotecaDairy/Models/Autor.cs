using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaDairy.Models
{
    public class Autor
    {
        public int Idautor { get; set; }
        public string nombre { get; set; }
        public string nacionalidad { get; set; }
        public DateTime fechadenacimiento { get; set; }

        public class map
        {
            public map(EntityTypeBuilder<Autor> lb)
            {
                lb.HasKey(x => x.Idautor);
                lb.Property(x => x.nombre).HasMaxLength(100).HasColumnName("nombre");
                lb.Property(x => x.nacionalidad).HasMaxLength(50).HasColumnName("nacionalidad");
                lb.Property(x => x.fechadenacimiento).HasColumnName("fechadenacimiento").HasColumnType("DateTime");
                
            }
        }
    }
}
