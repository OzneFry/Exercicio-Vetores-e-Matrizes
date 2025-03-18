using System;
using TrabalhoEsteban;

class Exercicio5 : IExercicio
{
    public void Executar()
    {
        string[] nomes = new string[10];
        double[,] notas = new double[10, 3];
        double[] medias = new double[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Digite o nome do aluno {i + 1}:");
            nomes[i] = Console.ReadLine();

            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"Digite a nota {j + 1} do aluno {nomes[i]}:");
                notas[i, j] = double.Parse(Console.ReadLine());
            }

            medias[i] = (notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3;
        }

        for (int i = 0; i < 10; i++)
        {
            if (medias[i] >= 7)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.WriteLine($"Aluno: {nomes[i]}");
            Console.WriteLine($"Notas: {notas[i, 0]}, {notas[i, 1]}, {notas[i, 2]}");
            Console.WriteLine($"Média: {medias[i]}");
            Console.WriteLine($"Status: {(medias[i] >= 7 ? "Aprovado" : "Reprovado")}");
            Console.ResetColor();
        }
    }
}
