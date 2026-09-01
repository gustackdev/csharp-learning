using System;

class Exercicio20_MediaPonderada
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== CALCULADORA DE MÉDIA PONDERADA ===");
        Console.Write("Quantos casos de teste você deseja informar? ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine();

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"--- Caso de teste {i} ---");

            Console.Write("Digite o primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            double valor3 = double.Parse(Console.ReadLine());

            double media = (valor1 * 2 + valor2 * 3 + valor3 * 5) / 10;

            Console.WriteLine($"Média ponderada: {media:F1}");
            Console.WriteLine();
        }

        Console.WriteLine("Todos os casos foram calculados.");
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}