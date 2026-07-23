using System;

namespace Exercicio03Diferenca
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;

            Console.Write("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            C = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de D: ");
            D = int.Parse(Console.ReadLine());

            int diferenca = (A * B) - (C * D);

            Console.WriteLine("Diferença = " + diferenca);
        }
    }
}