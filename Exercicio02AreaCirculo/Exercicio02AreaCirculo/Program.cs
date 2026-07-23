using System;
using System.Globalization;

namespace Exercicio02AreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area;
            double pi = 3.14159;

            Console.Write("Digite o valor do raio: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * Math.Pow(raio, 2);

            Console.WriteLine("A área do círculo é: " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}