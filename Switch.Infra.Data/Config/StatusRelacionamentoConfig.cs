using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using System;

namespace Switch.Infra.Data.Config
{
    public class StatusRelacionamentoConfiguration : IEntityTypeConfiguration<StatusRelacionamento>
    {
        public void Configure(EntityTypeBuilder<StatusRelacionamento> builder)
        {
            builder.HasKey(sr => sr.Id);

            builder.Property(sr => sr.Descricao)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasData(
                new StatusRelacionamento { Id=1, Descricao="Nao Especificado"},
                new StatusRelacionamento { Id = 2, Descricao = "Solteiro" },
                new StatusRelacionamento { Id = 3, Descricao = "Casado" },
                new StatusRelacionamento { Id = 4, Descricao = "EmRelacionamento" }
            );

 
        }
    }
}
