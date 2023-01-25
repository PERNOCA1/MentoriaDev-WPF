using MentoriaDevSti3.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentoriaDevSti3.Data.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).HasColumnType("varchar(255)").IsRequired();
            builder.Property(p => p.Cep).HasColumnType("varchar(8)").IsRequired();
            builder.Property(p => p.Endereco).HasColumnType("varchar(255)").IsRequired();
            builder.Property(p => p.Cidade).HasColumnType("varchar(100)").IsRequired();
        }
    }
}
