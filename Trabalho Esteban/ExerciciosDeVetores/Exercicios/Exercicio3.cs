using System;
using TrabalhoEsteban;

class Exercicio3 : IExercicio
{
    public void Executar()
    {
        int[,] matriz = new int[3, 5];

        Console.WriteLine("Digite 15 números inteiros para preencher a matriz 3x5:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < 3; i++)
        {
            int soma = 0;
            for (int j = 0; j < 5; j++)
            {
                soma += matriz[i, j];
            }
            Console.WriteLine($"Soma da linha {i + 1}: {soma}");
        }
    }
}
