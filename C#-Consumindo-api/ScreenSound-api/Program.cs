using ScreenSoundApi.Modelos;
using System.Text.Json;
using ScreenSoundApi.Filtros;

using (HttpClient client = new HttpClient())
{
  try
  {
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

    var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

    LinqFilter.FiltrarMusicasEmCSharp(musicas);
    // musicas[1].ExibirDetalhesDaMusica();
    //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
    //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
    //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
    // LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Coldplay");

    // var musicasPreferidasDoVitor = new MusicasPreferidas("Vitor");
    // musicasPreferidasDoVitor.AdicionarMusicasFavoritas(musicas[22]);
    // musicasPreferidasDoVitor.AdicionarMusicasFavoritas(musicas[55]);
    // musicasPreferidasDoVitor.AdicionarMusicasFavoritas(musicas[455]);
    // musicasPreferidasDoVitor.AdicionarMusicasFavoritas(musicas[81]);
    // musicasPreferidasDoVitor.AdicionarMusicasFavoritas(musicas[30]);

    // musicasPreferidasDoVitor.ExibirMusicasFavoritas();
    // musicasPreferidasDoVitor.GerarArquivoJson();
  }
  catch (Exception ex)
  {
    Console.WriteLine($"Temos um problema: {ex.Message}");
  }
}
