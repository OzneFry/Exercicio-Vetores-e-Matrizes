using System;
using TrabalhoEsteban;

class Exercicio2 : IExercicio
{
    public void Executar()
    {
        string[] nomes = new string[10];
        double[] preços = new double[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Digite o nome do produto {i + 1}:");
            nomes[i] = Console.ReadLine();

            Console.WriteLine($"Digite o preço do produto {i + 1}:");
            preços[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite um valor para pesquisa:");
        double valor = double.Parse(Console.ReadLine());

        Console.WriteLine("Produtos com preço até o valor digitado:");
        for (int i = 0; i < 10; i++)
        {
            if (preços[i] <= valor)
            {
                Console.WriteLine($"{nomes[i]} - R${preços[i]}");
            }
        }
    }
}
