using System;

class Exercicio19_ValoresDentroFora
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== CONTADOR DE INTERVALO ===");
        Console.Write("Quantos valores você deseja informar? ");
        int n = int.Parse(Console.ReadLine());

        int dentro = 0;
        int fora = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Digite o {i}º valor: ");
            int x = int.Parse(Console.ReadLine());

            if (x >= 10 && x <= 20)
            {
                dentro++;
            }
            else
            {
                fora++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("=== RESULTADO ===");
        Console.WriteLine($"Valores dentro do intervalo [10,20]: {dentro}");
        Console.WriteLine($"Valores fora do intervalo [10,20]: {fora}");

        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}