class Musica
{
  public Musica(Banda artista, string nome)
  {
    Artista = artista;
    Nome = nome;
  }
  public string Nome { get; }
  public Banda Artista { get; }
  public int Duracao { get; set; }
  public bool Disponivel { get; set; }

  public string DescricaoResumida => 
    $"A música {Nome} pertence a banda {Artista}";//lambida
  
  public void ExibirFichaTecnica()
  {
    System.Console.WriteLine($"Nome: {Nome}");
    System.Console.WriteLine($"Artista: {Artista.Nome}");
    System.Console.WriteLine($"Duração: {Duracao}");
    if (Disponivel)
    {
      System.Console.WriteLine("Disponível no Plano");
    }
    else
    {
      System.Console.WriteLine("Adquira o Plano Plus");
    }
  }

  public void ExibirNomeEArtista()
  {
    System.Console.WriteLine($"{Nome} - {Artista}");
  }
}