using System;
using TrabalhoEsteban;

class Exercicio6 : IExercicio
{
    public void Executar()
    {
        char[,] tabuleiro = new char[3, 3];
        int jogadas = 0;
        char jogadorAtual = 'X';

        while (true)
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tabuleiro[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Vez do jogador {jogadorAtual}");
            Console.WriteLine("Digite a linha (0, 1, 2):");
            int linha = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a coluna (0, 1, 2):");
            int coluna = int.Parse(Console.ReadLine());

            if (tabuleiro[linha, coluna] == '\0')
            {
                tabuleiro[linha, coluna] = jogadorAtual;
                jogadas++;

                if (VerificarVitoria(tabuleiro, jogadorAtual))
                {
                    Console.Clear();
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(tabuleiro[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine($"Jogador {jogadorAtual} venceu!");
                    break;
                }

                if (jogadas == 9)
                {
                    Console.Clear();
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(tabuleiro[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Empate!");
                    break;
                }

                jogadorAtual = jogadorAtual == 'X' ? 'O' : 'X';
            }
            else
            {
                Console.WriteLine("Posição já ocupada. Tente novamente.");
                Console.ReadLine();
            }
        }
    }

    private bool VerificarVitoria(char[,] tabuleiro, char jogador)
    {
        for (int i = 0; i < 3; i++)
        {
            if (
                tabuleiro[i, 0] == jogador
                && tabuleiro[i, 1] == jogador
                && tabuleiro[i, 2] == jogador
            )
                return true;

            if (
                tabuleiro[0, i] == jogador
                && tabuleiro[1, i] == jogador
                && tabuleiro[2, i] == jogador
            )
                return true;
        }

        if (tabuleiro[0, 0] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 2] == jogador)
            return true;

        if (tabuleiro[0, 2] == jogador && tabuleiro[1, 1] == jogador && tabuleiro[2, 0] == jogador)
            return true;

        return false;
    }
}
