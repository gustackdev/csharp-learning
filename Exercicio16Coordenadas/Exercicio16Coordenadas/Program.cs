using System;

class Program
{
    static void Main(string[] args)
    {
        string[] valores;

        while (true)
        {
            valores = Console.ReadLine().Split(' ');

            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            if (x == 0 || y == 0)
            {
                break;
            }

            if (x > 0 && y > 0)
            {
                Console.WriteLine("primeiro");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("quarto");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("terceiro");
            }
            else
            {
                Console.WriteLine("segundo");
            }
        }
    }
}