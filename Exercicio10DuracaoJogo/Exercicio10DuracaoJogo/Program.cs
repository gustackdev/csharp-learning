using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, duracao;

            Console.Write("Digite a hora inicial: ");
            horaInicial = int.Parse(Console.ReadLine());

            Console.Write("Digite a hora final: ");
            horaFinal = int.Parse(Console.ReadLine());

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}