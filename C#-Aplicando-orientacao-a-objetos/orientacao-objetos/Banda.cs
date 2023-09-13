class Banda
{
  private List<Album> albuns = new List<Album>();

  public Banda(string nome)
  {
    Nome = nome;
  }
  public string Nome { get; }

  public void AdicionarAlbum(Album album)
  {
    albuns.Add(album);
  }

  public void ExibirDiscografia()
  {
    System.Console.WriteLine($"Discografia da banda {Nome}");
    foreach (Album album in albuns)
    {
      System.Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
    }
  }
}