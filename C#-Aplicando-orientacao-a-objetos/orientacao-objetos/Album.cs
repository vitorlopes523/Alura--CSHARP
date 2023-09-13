class Album
{
  private List<Musica> musicas = new List<Musica>();

  public Album(string nome)
  {
    Nome = nome;
  }
  public string Nome { get; }
  public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);

  public void AdicionarMusica(Musica musica)
  {
    musicas.Add(musica);
  }

  public void ExibirMusicasDoAlbum()
  {
    System.Console.WriteLine($"Lista de músicas do álbum {Nome}: ");
    foreach(var musica in musicas)
    {
      System.Console.WriteLine($"Música: {musica.Nome}");
    }

    System.Console.WriteLine($"\nPara ouvir este álbum interiro você precisa de {DuracaoTotal}");
  }
}