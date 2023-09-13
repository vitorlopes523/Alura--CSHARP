// Banda queen = new Banda("Queen");

// Album albumDoQueen = new Album("A night at the opera");

// Musica musica1 = new Musica(queen, "Love of my life")
// {
//   Duracao = 213,
//   Disponivel = true
// };

// Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
// {
//   Duracao = 354,
//   Disponivel = false
// };

// albumDoQueen.AdicionarMusica(musica1);
// albumDoQueen.AdicionarMusica(musica2);
// queen.AdicionarAlbum(albumDoQueen);

// musica1.ExibirFichaTecnica();
// musica2.ExibirFichaTecnica();
// albumDoQueen.ExibirMusicasDoAlbum();
// queen.ExibirDiscografia();

Episodio ep1 = new(3, "Técnica de Falicitação", 45);
ep1.AdicionarConvidados("vitor");
ep1.AdicionarConvidados("lopes");

Episodio ep2 = new(2, "Musculação todo Dia", 60);
ep2.AdicionarConvidados("lucas");
ep2.AdicionarConvidados("lima");

Podcast podcast = new("Cariane", "Musculação");
podcast.AdicionarEpsodio(ep1);
podcast.AdicionarEpsodio(ep2);
podcast.ExibirDetalhes();
