using System;

namespace Exercicio05Pecas
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2;
            int qnt1, qnt2;
            double valor1, valor2;
            double valortotal;

            Console.WriteLine("Primeira Peça");

            Console.WriteLine("Digite o número da peça: ");
            cod1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de peças: ");
            qnt1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor unitário: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segunda Peça");

            Console.WriteLine("Digite o número da peça: ");
            cod2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de peças: ");
            qnt2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número da peça: ");
            valor2 = int.Parse(Console.ReadLine());

            valortotal = (qnt1 * valor1) + (qnt2 * valor2);

            Console.WriteLine("O valor total a ser pago é igual a: " + valortotal);
        }
    }
}