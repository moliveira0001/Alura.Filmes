using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Alura.Filmes.App.Dados
{
    public class PessoaConfiguration<T> : IEntityTypeConfiguration<T> where T : Pessoa
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {

            builder
               .Property(a => a.PrimeiroNome).HasColumnName("first_name").IsRequired();
            builder
               .Property(a => a.UltimoNome).HasColumnName("last_name").IsRequired();
            builder
               .Property(a => a.Email).HasColumnName("email");
            builder
               .Property(a => a.Ativo).HasColumnName("active").IsRequired();

            builder
                .Property<DateTime>("last_update")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()")
                .IsRequired();
        }
    }

}
