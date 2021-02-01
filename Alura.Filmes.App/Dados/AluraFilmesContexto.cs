using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Dados
{
    public class AluraFilmesContexto : DbContext
    {
        public DbSet<Ator> Atores { get; set; }

        public DbSet<Filme> Filmes { get; set; }

        public DbSet<FilmeAtor> Elenco { get; set; }

        public DbSet<Idioma> Idiomas { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Funcionario> Funcionarios { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AluraFilmes;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new AtorConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeAtorConfiguration());
            modelBuilder.ApplyConfiguration(new IdiomaConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());


            // trecho transferido para classe de configuração


            //modelBuilder.Entity<Ator>()
            //    .ToTable("actor");

            //modelBuilder.Entity<Ator>()
            //    .Property(a => a.Id)
            //    .HasColumnName("actor_id");

            //modelBuilder.Entity<Ator>()
            //.Property(a => a.PrimeiroNome)
            //    .HasColumnName("first_name")
            //    .HasColumnType("varchar(45)")
            //    .IsRequired();

            //modelBuilder.Entity<Ator>()
            //    .Property(a => a.UltimoNome)
            //    .HasColumnType("varchar(45)")
            //    .IsRequired();

            //modelBuilder.Entity<Ator>()
            //   .Property<DateTime>("last_update")
            //   .HasColumnType("datetime")
            //   .IsRequired()
            //   .HasDefaultValueSql("Getdate()");

            // filme

            //modelBuilder.Entity<Filme>()
            //    .ToTable("Film");


            //modelBuilder.Entity<Filme>()
            //   .Property(f => f.Id)
            //   .HasColumnName("film_id");

            //modelBuilder.Entity<Filme>()
            //    .Property(f => f.Titulo)
            //    .HasColumnName("title")
            //    .HasColumnType("varchar(255)")
            //    .IsRequired();

            //modelBuilder.Entity<Filme>()
            //    .Property(f => f.Descricao)
            //    .HasColumnName("description")
            //    .HasColumnType("text");

            //modelBuilder.Entity<Filme>()
            //    .Property(f => f.AnoLancamento)
            //    .HasColumnName("release_year")
            //    .HasColumnType("varchar(4)");

            //modelBuilder.Entity<Filme>()
            //    .Property(f => f.Duracao)
            //    .HasColumnName("length");

            //modelBuilder.Entity<Filme>()
            //    .Property<DateTime>("last_update")
            //    .HasColumnType("datetime")
            //    .IsRequired();



        }
    }
}