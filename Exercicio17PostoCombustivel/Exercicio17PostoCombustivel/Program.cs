using System;

class Program
{
    static void Main(string[] args)
    {
        int quantidadeAlcool = 0;
        int quantidadeGasolina = 0;
        int quantidadeDiesel = 0;

        int codigoCombustivel = int.Parse(Console.ReadLine());

        while (codigoCombustivel != 4)
        {
            if (codigoCombustivel == 1)
            {
                quantidadeAlcool++;
            }
            else if (codigoCombustivel == 2)
            {
                quantidadeGasolina++;
            }
            else if (codigoCombustivel == 3)
            {
                quantidadeDiesel++;
            }

            codigoCombustivel = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + quantidadeAlcool);
        Console.WriteLine("Gasolina: " + quantidadeGasolina);
        Console.WriteLine("Diesel: " + quantidadeDiesel);
    }
}