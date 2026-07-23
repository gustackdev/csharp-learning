using System;

namespace Exercicio04Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int numfuncionario;
            int horastrabalhadas;
            int valorhora;
            decimal salario;

            Console.WriteLine("Digite o número do funcionário: ");
            numfuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite as horas trabalhadas: ");
            horastrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da hora deste funcionário: ");
            valorhora = int.Parse(Console.ReadLine());

            salario = horastrabalhadas * valorhora;

            Console.WriteLine("Salário: "+salario);
        }
    }
}