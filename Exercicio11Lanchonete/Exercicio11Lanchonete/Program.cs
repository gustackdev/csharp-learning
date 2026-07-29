using System;
using System.Globalization;

namespace Exercicio05Lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double total = 0.0;

            Console.Write("Digite o código do item: ");
            codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());

            if (codigo == 1)
            {
                total = quantidade * 4.00;
            }
            else if (codigo == 2)
            {
                total = quantidade * 4.50;
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.00;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.00;
            }
            else if (codigo == 5)
            {
                total = quantidade * 1.50;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}