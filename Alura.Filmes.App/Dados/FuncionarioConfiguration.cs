using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alura.Filmes.App.Dados
{
    public class FuncionarioConfiguration : PessoaConfiguration<Funcionario>
    {
        public override void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            base.Configure(builder);

            builder.ToTable("staff");           

            builder
            .Property(a => a.Id).HasColumnName("staff_id");

            builder
           .Property(a => a.Login).HasColumnName("username").IsRequired();

            builder
           .Property(a => a.Senha).HasColumnName("password");
        }
    }
}