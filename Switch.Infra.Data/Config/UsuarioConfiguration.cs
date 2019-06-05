using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using System;

namespace Switch.Infra.Data.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Nome).HasMaxLength(150).IsRequired();
            builder.Property(u => u.Senha).HasMaxLength(10).IsRequired();
            builder.Property(u => u.Sexo).IsRequired();
        }
    }
}
