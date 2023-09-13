// Screen Sound
string mensegemDeBoasVindas = "Boas Vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string> { "Coldplay", "Gun's Roses" };
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int>{10, 8, 6});
bandasRegistradas.Add("The Beatles", new List<int>());

void ExibirLogo()
{
  Console.WriteLine(mensegemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
  ExibirLogo();
  Console.WriteLine("\nDigite 1 para registrar uma banda");
  Console.WriteLine("Digite 2 para mostrar todas a bandas");
  Console.WriteLine("Digite 3 para avaliar uma banda");
  Console.WriteLine("Digite 4 para exibir a média de uma banda");
  Console.WriteLine("Digite -1 para sair");

  Console.Write("\nDigite uma opção: ");
  string opcaoEscolhida = Console.ReadLine()!;
  int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

  switch (opcaoEscolhidaNumerica)
  {
    case 1:
      RegistroDeBanda();
      break;
    case 2:
      MostrarBandasRegistradas();
      break;
    case 3:
      AvaliarUmaBanda();
      break;
    case 4:
      ExibirMedia();
      break;
    case -1:
      Console.WriteLine("Você saiu");
      break;
    default:
      Console.WriteLine("Opção inválida!");
      break;
  }
}

void RegistroDeBanda()
{
  Console.Clear();
  ExibirTituloDaOpcao("Registro de Bandas");
  Console.Write("\nDigite o nome da banda que deseja cadastrar: ");
  string nomeDaBanda = Console.ReadLine()!;
  bandasRegistradas.Add(nomeDaBanda, new List<int>());
  Console.WriteLine($"A banda {nomeDaBanda} foi resgistrada com sucesso!");
  Thread.Sleep(2500);
  Console.Clear();
  ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
  Console.Clear();
  ExibirTituloDaOpcao("Exibindo Bandas Registradas");

  foreach (string banda in bandasRegistradas.Keys)
  {
    Console.WriteLine($"Banda: {banda}");
  }

  Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal");
  Console.ReadKey();
  Console.Clear();
  ExibirOpcoesDoMenu();
}

void AvaliarUmaBanda()
{
  Console.Clear();
  ExibirTituloDaOpcao("Avaliar Banda");
  Console.Write("Digite o nome da banda que deseja avaliar: ");
  string nomeDaBanda = Console.ReadLine()!;
  
  if(bandasRegistradas.ContainsKey(nomeDaBanda))
  {
    Console.Write($"Digite a nota que a banda {nomeDaBanda} merece: ");
    int nota = int.Parse(Console.ReadLine()!);
    bandasRegistradas[nomeDaBanda].Add(nota);
    Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}!");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
  } else
  {
    Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
  }
}

void ExibirMedia()
{
  Console.Clear();
  ExibirTituloDaOpcao("Exibir média da banda");
  Console.Write("Digite o nome da banda que deseja ver a média: ");
  string nomeDaBanda = Console.ReadLine()!;
  if (bandasRegistradas.ContainsKey (nomeDaBanda))
  {
    List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
    Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
  } else
  {
    Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
  }
}

void ExibirTituloDaOpcao(string titulo)
{
  int quantidadeDeLetras = titulo.Length;
  string asteristicos = string.Empty.PadLeft(quantidadeDeLetras, '*');
  Console.WriteLine(asteristicos);
  Console.WriteLine(titulo);
  Console.WriteLine(asteristicos + "\n");
}
ExibirLogo();
ExibirOpcoesDoMenu();