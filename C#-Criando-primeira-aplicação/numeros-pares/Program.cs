List<int> listaDeNumeros = new List<int> {1,2,3,4,5,6,7,8,9,10};

foreach (int numero in listaDeNumeros)
{
  if (numero % 2 == 0) {
    Console.WriteLine($"O {numero} é par");
  } 
}