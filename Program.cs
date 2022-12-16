using System;

class Desafio
{
  static void Main()
  {
    int quantidadeEntradas = 3;

    while (quantidadeEntradas-- > 0)
    {
      int numeroQuantidade = Int32.Parse(Console.ReadLine());
      string[] tartarugas = Console.ReadLine().Split(" ");
      var maiorVelocidade = Int32.Parse(tartarugas[0]);

      for (int i = 0; i < tartarugas.Length; i++)
      {
        var tartaruga = Int32.Parse(tartarugas[i]);

        if (tartaruga > maiorVelocidade)
        {
          maiorVelocidade = tartaruga;
        }
      }

      if (maiorVelocidade < 10)
      {
        Console.WriteLine(1);
      }
      else if (maiorVelocidade >= 10 && maiorVelocidade < 20)
      {
        Console.WriteLine(2);
      }
      else
      {
        Console.WriteLine(3);
      }
    }
  }
}
