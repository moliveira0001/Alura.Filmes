using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
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


                var filmeInserido = contexto.Filmes.First(f => f.Titulo == "Cassino Royale");
                Console.WriteLine(filmeInserido.Classificacao.ParaString());

            }

            Console.ReadKey();
        }
    }
}