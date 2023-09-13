class Podcast
{
  private List<Episodio> episodios = new();
  public Podcast(string host, string nome)
  {
    Host = host;
    Nome = nome;
  }

  public string Host { get; }
  public string Nome { get; }
  public int TotalEpisodios => episodios.Count;

  public void AdicionarEpsodio(Episodio episodio)
  {
    episodios.Add(episodio);
  }

  public void ExibirDetalhes()
  {
    System.Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");
    foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
    {
      System.Console.WriteLine(episodio.Resumo);
    }
    System.Console.WriteLine($"\n\nEste podcast possui {TotalEpisodios} episódios");
  }
}