using System;
using TrabalhoEsteban;

class Exercicio1 : IExercicio
{
    public void Executar()
    {
        int[] vetor = new int[15];

        Console.WriteLine("Digite 15 números inteiros:");
        for (int i = 0; i < 15; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Números nas posições pares:");
        for (int i = 0; i < 15; i += 2)
        {
            Console.WriteLine(vetor[i]);
        }
    }
}
