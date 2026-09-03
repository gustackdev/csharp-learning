using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira um número para calcular o fatorial: ");
        int n = int.Parse(Console.ReadLine());

        int fatorial = 1;

        for (int i = 1; i <= n; i++)
        {
            fatorial *= i;
        }

        Console.WriteLine($"Fatorial de {n}: {fatorial}");

        Console.WriteLine("\nPressione qualquer tecla para encerrar...");
        Console.ReadKey();
    }
}