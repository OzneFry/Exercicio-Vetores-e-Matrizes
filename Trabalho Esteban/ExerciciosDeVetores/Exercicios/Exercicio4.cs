using System;
using TrabalhoEsteban;

class Exercicio4 : IExercicio
{
    public void Executar()
    {
        int[,] matriz = new int[5, 5];
        int valor = 1;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matriz[i, j] = valor++;
            }
        }

        Console.WriteLine("Valores da diagonal principal:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(matriz[i, i]);
        }

        Console.WriteLine("Valores da diagonal secundária:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(matriz[i, 4 - i]);
        }
    }
}
