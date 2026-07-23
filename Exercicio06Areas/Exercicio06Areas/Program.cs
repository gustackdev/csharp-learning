using System;
using System.Globalization;

namespace Exercicio06Areas
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double C;
            const double pi = 3.14159;

            Console.WriteLine("Calculadora de Áreas");

            Console.Write("Insira o valor de A: ");
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Insira o valor de B: ");
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Insira o valor de C: ");
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("TRIÂNGULO: "+ ((A*C)/2).ToString("F3"));
            Console.WriteLine("CIRCULO: "+ (pi * Math.Pow(C, 2)).ToString("F3"));
            Console.WriteLine("TRAPEZIO: "+ (((A+B)*C)/2).ToString("F3"));
            Console.WriteLine("QUADRADO: "+ (Math.Pow(B, 2)).ToString("F3"));
            Console.WriteLine("RETANGULO: " + (A * B).ToString("F3"));
        }
    }
}