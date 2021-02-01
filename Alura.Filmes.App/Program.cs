using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new AluraFilmesContexto())
            {
                contexto.LogSQLToConsole();

                //foreach (var item in contexto.Elenco)
                //{
                //    var entidade = contexto.Entry(item);
                //    var filmId = entidade.Property("film_id").CurrentValue;
                //    var actorId = entidade.Property("actor_id").CurrentValue;
                //    var lastUpd = entidade.Property("last_update").CurrentValue;
                //    Console.WriteLine($"Filme {filmId}, Ator {actorId}, LastUpdate: {lastUpd}");
                //}


                //var filme = contexto.Filmes
                //   .Include(f => f.Atores)
                //   .ThenInclude(a => a.Ator)
                //    .First();

                //Console.WriteLine(filme);
                //Console.WriteLine("Elenco");

                //foreach (var ator in filme.Atores)
                //{
                //    Console.WriteLine(ator.Ator);
                //}

                //var idioma = contexto.Idiomas;

                //foreach (var item in idioma)
                //{
                //    Console.WriteLine(item);
                //}


                //var idiomas = contexto.Idiomas
                //       .Include(i => i.FilmesFalados);

                //foreach (var idioma in idiomas)
                //{
                //    Console.WriteLine(idioma);

                //    foreach (var filme in idioma.FilmesFalados)
                //    {
                //        Console.WriteLine(filme);
                //    }
                //    Console.WriteLine("\n");


                //}


                // var idioma = new Idioma { Nome = "English" };

                //var filme = new Filme();
                //filme.Titulo = "Cassino Royale";
                //filme.Duracao = 120;
                //filme.AnoLancamento = "2000";
                //filme.Classificacao = ClassificacaoIndicativa.MaioresQue14;
                //filme.IdiomaFalado = contexto.Idiomas.First();

                //contexto.Entry(filme).Property("last_update").CurrentValue = DateTime.Now;

                //contexto.Filmes.Add(filme);
                //contexto.SaveChanges();


                //var filmeInserido = contexto.Filmes.First(f => f.Titulo == "Cassino Royale");
                //Console.WriteLine(filmeInserido.Classificacao.ParaString());

                //var sql = @"select a.*
                //from actor a
                //  inner  join
                //  top5_most_starred_actors filmes on filmes.actor_id = a.actor_id";


                //var atoresMaisAtuantes = contexto.Atores
                //    .Include(a => a.Filmografia)
                //    .OrderByDescending(a => a.Filmografia.Count)
                //    .Take(5);


                //var atoresMaisAtuantes = contexto.Atores.FromSql(sql).Include(a => a.Filmografia);


                //foreach (var ator in atoresMaisAtuantes)
                //{
                //    System.Console.WriteLine($"O ator {ator.PrimeiroNome} {ator.UltimoNome} atuou em {ator.Filmografia.Count} filmes");
                //}

                //Console.WriteLine("Clientes");
                //foreach (var cliente in contexto.Clientes)
                //{
                //    Console.WriteLine(cliente);
                //}

                //Console.WriteLine("\nFuncionários");
                //foreach (var func in contexto.Funcionarios)
                //{
                //    Console.WriteLine(func);
                //}


                var categ = "Action"; //36

                var paramCateg = new SqlParameter("category_name", categ);

                var paramTotal = new SqlParameter
                {
                    ParameterName = "@total_actors",
                    Size = 4,
                    Direction = System.Data.ParameterDirection.Output
                };

                contexto.Database
                    .ExecuteSqlCommand("total_actors_from_given_category @category_name, @total_actors OUT", paramCateg, paramTotal);

                System.Console.WriteLine($"O total de atores na categoria {categ} é de {paramTotal.Value}.");

                Console.ReadKey();
            }
        }
    }
}