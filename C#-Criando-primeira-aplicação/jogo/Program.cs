Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1,10);

do {
  Console.Write("Digite um número entre 1 a 10: ");
  int chute = int.Parse(Console.ReadLine());

  if (chute == numeroSecreto) {
    Console.WriteLine("Parabéns! Você acertou o número");
    break;
  } else if (chute < numeroSecreto) {
    Console.WriteLine("O número é maior");
  } else {
    Console.WriteLine("O número é menor");
  }
} while(true);

Console.WriteLine("O Jogo acabou. Você acertou o número secreto!");