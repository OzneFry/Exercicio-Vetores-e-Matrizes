using System;
using System.Collections.Generic;
using TrabalhoEsteban;

public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<int, IExercicio> exercicios = new Dictionary<int, IExercicio>
        {
            { 1, new Exercicio1() },
            { 2, new Exercicio2() },
            { 3, new Exercicio3() },
            { 4, new Exercicio4() },
            { 5, new Exercicio5() },
            { 6, new Exercicio6() },
        };

        Console.WriteLine("Digite o número do exercício que deseja executar (ex: 1):");
        int numeroExercicio = int.Parse(Console.ReadLine());

        if (exercicios.ContainsKey(numeroExercicio))
        {
            exercicios[numeroExercicio].Executar();
        }
        else
        {
            Console.WriteLine("Exercício não encontrado.");
        }
    }
}
