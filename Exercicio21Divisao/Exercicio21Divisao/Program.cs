using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira a quantidade de pares de números: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"\nPar {i}:");

            Console.Write("Insira o primeiro número: ");
            double primeiro = double.Parse(Console.ReadLine());

            Console.Write("Insira o segundo número: ");
            double segundo = double.Parse(Console.ReadLine());

            if (segundo == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                double resultado = primeiro / segundo;
                Console.WriteLine($"Resultado da divisão: {resultado:F1}");
            }
        }

        Console.WriteLine("\nPressione qualquer tecla para encerrar...");
        Console.ReadKey();
    }
}