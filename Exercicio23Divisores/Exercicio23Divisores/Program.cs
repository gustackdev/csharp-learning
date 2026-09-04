using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira um número inteiro: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nDivisores de {n}:");

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("\nPressione qualquer tecla para encerrar...");
        Console.ReadKey();
    }
}